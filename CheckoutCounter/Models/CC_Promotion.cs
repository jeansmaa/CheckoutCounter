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
        //QuantityToDeliver - This is the value the customer want to buy
        //public int QuantityToDeliver { get; set; }

        //QuantityToPay - This is the value the customer have to pay according to QuantityToDeliver 
        //public int QuantityToPay { get; set; }

        //QuantityAwarded - This is the value for the number of items got for the customers once QuantityToDeliver was proccesed  
        //public int QuantityAwarded { get; set; }
        public CC_Product Product { get; set; }
        public PromotionType PromotionType { get; set; }
        public CC_Promotion(CC_Product product,PromotionType promotionType) 
        {
            this.Product = product;
            this.PromotionType = promotionType;            
        }
        //public void Execute(int QuantityToDeliver)
        //{
        //    this.QuantityToDeliver = QuantityToDeliver;
        //    Setup();
        //}
        //private void Setup()
        //{
        //    if (this.PromotionType == PromotionType.BuyOneGetOne)
        //    {
        //        if (this.QuantityToDeliver == 1)
        //        {
        //            this.QuantityToPay = this.QuantityToDeliver;
        //        }
        //        else
        //        {
        //            if (this.QuantityToDeliver % 2 == 0)
        //            {
        //                this.QuantityToPay = Decimal.ToInt32(Math.Truncate((decimal)this.QuantityToDeliver / 2));
        //            }
        //            else
        //            {
        //                this.QuantityToPay = Decimal.ToInt32(Math.Truncate((decimal)this.QuantityToDeliver / 2))+1;
        //            }                    
                    
        //            this.QuantityAwarded = this.QuantityToDeliver - QuantityToPay;
        //        }
        //    }
        //    if (this.PromotionType == PromotionType.BuyTwoGetOne)
        //    {
        //        if (this.QuantityToDeliver == 1 || this.QuantityToDeliver == 2)
        //        {
        //            this.QuantityToPay = this.QuantityToDeliver;
        //        }
        //        else
        //        {
        //            this.QuantityAwarded = Decimal.ToInt32(Math.Truncate((decimal)this.QuantityToDeliver / 3));
        //            this.QuantityToPay = this.QuantityToDeliver - this.QuantityAwarded;
        //        }
        //    }
        //}
    }
}
