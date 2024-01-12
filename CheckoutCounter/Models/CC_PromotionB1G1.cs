using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutCounter.Models
{
    public class CC_PromotionB1G1:CC_Promotion
    {
        public CC_PromotionB1G1(CC_Product product/*, PromotionType promotionType*/):
            base(product/*,promotionType*/)
        { }
        public override void CalculatePromotion(int quantityToDeliver)
        {
            this.QuantityToDeliver = quantityToDeliver;
            if (this.QuantityToDeliver % 2 == 0)
            {
                this.QuantityToPay = this.QuantityToDeliver / 2;
            }
            else
            {
                this.QuantityToPay = (this.QuantityToDeliver / 2) + 1;
            }
            this.QuantityAwarded = this.QuantityToDeliver - this.QuantityToPay;
        }
    }
}
