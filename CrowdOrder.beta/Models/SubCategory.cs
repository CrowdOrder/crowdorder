using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Models
{
    public class SubCategory : PageObjectBase
    {        
        public List<Service> Services { get; set; }
        public Category Category { get; set; }
    }
}
