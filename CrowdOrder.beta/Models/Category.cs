using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Models
{
    public class Category : PageObjectBase
    {        
        public List<SubCategory> SubCategories { get; set; }
    }
}
