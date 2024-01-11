using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutCounter.Models
{
    public class CC_Product : CC_Entity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public string MeasurementUnit { get; set; }
        public SoldBy SoldBy { get; set; }
        public decimal Weight{get;set;}


        public CC_Product() { }

    }
}
