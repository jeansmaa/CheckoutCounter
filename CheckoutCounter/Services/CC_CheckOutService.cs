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
        public CC_PromotionService PromotionService { get; set; }
        public CC_Sale Sale { get; set; }
        public CC_CheckOutService(CC_PromotionService promotionService) 
        {
            this.PromotionService = promotionService;
            this.Sale = new CC_Sale(this.PromotionService);
        }
        public void Scan(CC_Product product)
        {
            this.Sale.AddItem(product);
        }
    }
}
