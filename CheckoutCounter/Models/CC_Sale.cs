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
        public List<CC_SaleLine> saleLines;
        public decimal TotalPrice{get;set;}
        public CC_Sale()
        {
            this.saleLines = new List<CC_SaleLine>();
        }
        public void AddItem(CC_Product product)
        {
            bool found = false;
            foreach (var line in saleLines) 
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
                saleLines.Add(saleLine);
            }
            this.UpdateTotalPrice();            
        }
        public void PrintReceipt()
        {
            //decimal total = 0;
            foreach (var line in saleLines) 
            {
                Console.WriteLine(line.TextToPrint);
                //total+=line.TotalPrice;
            }
            Console.WriteLine("Total: " + this.TotalPrice.ToString("#,##0.00"));
        }
        private void UpdateTotalPrice()
        {
            this.TotalPrice = 0;
            foreach (var line in saleLines)
            {
                this.TotalPrice += line.TotalPrice;
            }
        }
    }
}
