using CheckoutCounter.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutCounter.Models
{
    public class CC_Sale : CC_Entity
    {
        public int Id { get; set; }
        public List<CC_SaleLine> SaleLines;
        CC_PromotionService PromotionService { get; set; } 
        public decimal TotalPrice{get;set;}
        public CC_Sale(CC_PromotionService promotionService)
        {
            this.PromotionService = promotionService;
            this.SaleLines = new List<CC_SaleLine>();
        }
        private CC_Promotion FindPromotion(CC_Product product)
        {
            return this.PromotionService.GetProductPromotion(product.Code);
        }
        public void AddItem(CC_Product product)
        {
            bool found = false;
            foreach (var line in SaleLines) 
            {
                if (line.Product.Code == product.Code)
                {
                    line.Scanned();
                    found = true;
                    break;
                }
            }
            if (!found) 
            {
                CC_SaleLine saleLine = new CC_SaleLine(product);

                saleLine.Promotion = this.FindPromotion(product);
                
                SaleLines.Add(saleLine);
            }
            this.UpdateTotalPrice();            
        }
        public void PrintReceipt()
        {
            foreach (var line in SaleLines) 
            {
                Console.WriteLine(line.TextToPrint);                
            }
            Console.WriteLine("Total: " + this.TotalPrice.ToString("#,##0.00"));
        }
        private void UpdateTotalPrice()
        {
            this.TotalPrice = 0;
            foreach (var line in SaleLines)
            {
                this.TotalPrice += line.TotalPrice;
            }
        }
    }
}
