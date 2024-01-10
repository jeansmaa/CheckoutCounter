using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutCounter.Models
{
    public class CC_Promotion:CC_Entity
    {
        public int Id { get; set; }
        [StringLength(128)]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public decimal QuantityToDeliver { get; set; }
        public int QuantityToPay { get; set; }
        public CC_Product Product { get; set; }
        public PromotionType PromotionType { get; set; }
        public CC_Promotion(CC_Product product,PromotionType promotionType,int QuantityToDeliver) 
        {
            this.Product = product;
            this.PromotionType = promotionType;            
        }
        private void Setup()
        {
            if (this.PromotionType == PromotionType.BuyOneGetOne)
            {
                this.QuantityToPay = Decimal.ToInt32(Math.Truncate(this.QuantityToDeliver / 2));
            }
            if (this.PromotionType == PromotionType.BuyTwoGetOne)
            {
                this.QuantityToDeliver = 3;
                this.QuantityToPay = 2;
            }
        }
    }
}
