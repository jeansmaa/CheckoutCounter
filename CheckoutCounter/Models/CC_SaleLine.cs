using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutCounter.Models
{
    public class CC_SaleLine
    {
        public string? TextToPrint{ get; set; }
        public CC_Product Product { get; set; }
        CC_Promotion Promotion { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal? TotalWeight { get; set; }
        //QuantityToDeliver - This is the value the customer want to buy
        public int QuantityToDeliver { get; set; }

        //QuantityToPay - This is the value the customer have to pay according to QuantityToDeliver 
        //public int QuantityToPay { get; set; }

        //QuantityAwarded - This is the value for the number of items got for the customers once QuantityToDeliver was proccesed  
        //public int QuantityAwarded { get; set; }
        public void Scanned()
        {
            if (this.Product.SoldBy == SoldBy.Bybulk)
            {
                this.QuantityToDeliver += Decimal.ToInt32(this.Product.Weight);
            }
            else
            {
                this.QuantityToDeliver++;
            }
            this.ProccessingItem();
        }
        private void ProccessingItem()
        {
            if (this.Promotion != null)
            {
                //Code promotions for this product here
            }
            else
            {
                this.TotalPrice = this.Product.UnitPrice * this.QuantityToDeliver;
                this.TextToPrint = this.Product.Code + "-" + this.Product.Name + " x" +
                    this.QuantityToDeliver + " " + this.TotalPrice.ToString("#,##0.00");

                //Console.WriteLine(this.TextToPrint);
                //Console.WriteLine("***************End*****************");
            }
        }
        public CC_SaleLine(CC_Product product, CC_Promotion promotion=null)
        {            
            this.Product = product;   
            this.Promotion = promotion;
            Scanned();
        }        
    }
}
