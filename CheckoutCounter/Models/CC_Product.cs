using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutCounter.Models
{
    public class CC_Product:CC_Entity
    {
        public int Id { get; set; }
        [StringLength(128)]
        public string Code { get; set; }
        [StringLength(256)]
        public string Name { get; set; }        
        public string Description { get; set; }
        public decimal? UnitPrice { get; set; }

        public SoldBy SoldBy { get; set; }


        public CC_Product() { }

    }
}
