using CrowdOrder.beta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Models
{
    public class PartnerConnectionVM
    {
        public PartnerConnection PartnerConnection { get; set; }
        public List<Service> Suggestions { get; set; }
    }
}
