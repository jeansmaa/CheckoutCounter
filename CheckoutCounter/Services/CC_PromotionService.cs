using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckoutCounter.Models;

namespace CheckoutCounter.Services
{
    public class CC_PromotionService
    {
        List<CC_Promotion> promotions;
        public CC_PromotionService() 
        {
            this.promotions = new List<CC_Promotion>();
        }
        public void AddPromotion(CC_Promotion promotion) 
        {
            this.promotions.Add(promotion);
        }
        public CC_Promotion? GetProductPromotion(string ProductCode)
        {
            return this.promotions.FirstOrDefault(x => x.Product.Code == ProductCode);
            
        }
    }
}
