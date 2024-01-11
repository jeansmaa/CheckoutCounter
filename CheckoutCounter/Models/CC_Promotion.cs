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
        
        public string Name { get; set; }
        public string Description { get; set; }        
        public CC_Product Product { get; set; }
        public PromotionType PromotionType { get; set; }
        public CC_Promotion(CC_Product product,PromotionType promotionType) 
        {
            this.Product = product;
            this.PromotionType = promotionType;            
        }        
    }
}
