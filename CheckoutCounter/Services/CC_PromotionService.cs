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
        List<CC_Promotion> Promotions;
        public CC_PromotionService() 
        {
            this.Promotions = new List<CC_Promotion>();
        }
        public void AddPromotion(CC_Promotion promotion) 
        {
            this.Promotions.Add(promotion);
        }
        public CC_Promotion? GetProductPromotion(string productCode)
        {
            return this.Promotions.FirstOrDefault(x => x.Product.Code == productCode);
            
        }
    }
}
