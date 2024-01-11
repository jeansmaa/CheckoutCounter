using CheckoutCounter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutCounter.Services
{
    public class CC_CheckOutService
    {
        public CC_PromotionService promotionService { get; set; }
        public CC_Sale sale { get; set; }
        public CC_CheckOutService() 
        {
            this.promotionService = new CC_PromotionService();
            this.sale = new CC_Sale();
        }
        public void Scan(CC_Product product)
        {
            this.sale.AddItem(product);
        }
    }
}
