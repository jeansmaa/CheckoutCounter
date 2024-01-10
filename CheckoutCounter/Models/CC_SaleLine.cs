using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutCounter.Models
{
    public class CC_SaleLine
    {
        public int QuantityToDeliver { get; set; }
        public string? TextToPrint{ get; set; }
        public CC_Product Product { get; set; }
        public CC_Promotion Promotion { get; set; }

        public CC_SaleLine(int quantityToDeliver, CC_Product product)
        {
            this.QuantityToDeliver = QuantityToDeliver;
            this.Product = product;
            this.Promotion = null;
        }
        public decimal GetTotalPrice()
        {
            if (this.Promotion != null)
            {
                this.Promotion.Execute(this.QuantityToDeliver);
                return this.Promotion.QuantityToPay * this.Product.UnitPrice;
            }
            else
            {
                return this.QuantityToDeliver*this.Product.UnitPrice;
            }
        }
    }
}
