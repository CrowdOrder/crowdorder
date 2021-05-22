using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Models
{
    public class ServicesVM
    {
        public IEnumerable<Category> Categories { get; set; }
        public Partner FeaturedPartner { get; set; }
    }
}
