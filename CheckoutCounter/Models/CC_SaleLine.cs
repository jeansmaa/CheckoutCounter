using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutCounter.Models
{
    public class CC_SaleLine
    {
        public string? TextToPrint{ get; set; }
        public CC_Product Product { get; set; }
        public CC_Promotion Promotion { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal? TotalWeight { get; set; }
        //QuantityToDeliver - This is the value the customer want to buy
        public int QuantityToDeliver { get; set; }

        //QuantityToPay - This is the value the customer have to pay according to QuantityToDeliver 
        public int QuantityToPay { get; set; }

        //QuantityAwarded - This is the value for the number of items got for the customers once QuantityToDeliver was proccesed  
        public int QuantityAwarded { get; set; }
        private void ProductWeighing()
        {
            this.QuantityToDeliver += Decimal.ToInt32(this.Product.Weight);
        }
        private void PlusOneQuantity()
        {
            this.QuantityToDeliver++;
        }
        public void Scanned()
        {
            if (this.Product.SoldBy == SoldBy.Bybulk)
            {
                this.ProductWeighing();
            }
            else
            {
                this.PlusOneQuantity();
            }
            this.ProcessingItem();
        }
        private void ProccesingPromotion()
        {
            //switch (this.Promotion.PromotionType)
            //{
            //    case PromotionType.BuyOneGetOne:
            //        if (this.QuantityToDeliver % 2 == 0)
            //        {
            //            this.QuantityToPay = this.QuantityToDeliver / 2;                        
            //        }
            //        else
            //        {
            //            this.QuantityToPay= (this.QuantityToDeliver / 2)+1;
            //        }
            //        break;
            //    case PromotionType.BuyTwoGetOne:
            //        var memory = decimal.ToInt32(Math.Truncate((decimal)this.QuantityToDeliver / 3)); 
            //        this.QuantityToPay=this.QuantityToDeliver-memory;
            //        break;                
            //}
            //this.QuantityAwarded= this.QuantityToDeliver-this.QuantityToPay;
            //this.TotalPrice = this.QuantityToPay * this.Product.UnitPrice;
        }
        private void ProcessingItem()
        {
            if (this.Promotion != null)
            {
                //Code promotions for this product here
                //this.ProccesingPromotion();
                ///////////////////////////////
                this.Promotion.ProccesingPromotion(this.QuantityToDeliver);
                this.QuantityAwarded = this.Promotion.QuantityAwarded;
                this.QuantityToDeliver = this.Promotion.QuantityToDeliver;
                this.QuantityToPay = this.Promotion.QuantityToPay;
                this.TotalPrice = this.QuantityToPay * this.Product.UnitPrice;
            }
            else
            {
                this.TotalPrice = this.Product.UnitPrice * this.QuantityToDeliver;
                               
            }
            this.TextToPrint = this.Product.Code + " - " + this.Product.Name + " x" +
                    this.QuantityToDeliver + " "+this.Product.MeasurementUnit +" " + this.TotalPrice.ToString("#,##0.00") + 
                    " - " + this.QuantityAwarded +" "+this.Product.MeasurementUnit+" for free";
        }
        public CC_SaleLine(CC_Product product, CC_Promotion? promotion=null)
        {            
            this.Product = product;   
            this.Promotion = promotion;
            Scanned();
        }        
    }
}
