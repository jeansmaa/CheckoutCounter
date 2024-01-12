using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutCounter.Models
{
    public class CC_PromotionB2G1 : CC_Promotion
    {
        public CC_PromotionB2G1(CC_Product product/*, PromotionType promotionType*/) :
            base(product/*, promotionType*/)
        { }
        public override void CalculatePromotion(int quantityToDeliver)
        {
            this.QuantityToDeliver = quantityToDeliver;
            var memory = decimal.ToInt32(Math.Truncate((decimal)this.QuantityToDeliver / 3));
            this.QuantityToPay = this.QuantityToDeliver - memory;
            this.QuantityAwarded = this.QuantityToDeliver - this.QuantityToPay;
        }
    }
}
