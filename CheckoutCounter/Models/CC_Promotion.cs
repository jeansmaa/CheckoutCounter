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
        
        public string? Name { get; set; }
        public string? Description { get; set; }        
        public CC_Product Product { get; set; }

        //QuantityToDeliver - This is the value the customer want to buy
        public int QuantityToDeliver { get; set; }

        //QuantityToPay - This is the value the customer have to pay according to QuantityToDeliver 
        public int QuantityToPay { get; set; }

        //QuantityAwarded - This is the value for the number of items got for the customers once QuantityToDeliver was proccesed  
        public int QuantityAwarded { get; set; }
        public CC_Promotion(CC_Product product) 
        {
            this.Product = product;                       
        }
        public virtual void CalculatePromotion(int quantityToDeliver)
        { }        
    }
}
