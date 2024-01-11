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
        public CC_CheckOutService(CC_PromotionService promotionService) 
        {
            this.promotionService = promotionService;
            this.sale = new CC_Sale(this.promotionService);
        }
        public void Scan(CC_Product product)
        {
            this.sale.AddItem(product);
        }
    }
}
