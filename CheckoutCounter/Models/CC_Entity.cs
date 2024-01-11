using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutCounter.Models
{   //Interface to define de contract to all models 
    public interface CC_Entity
    {
        [Key]
        int Id { get; set; }
    }
}
