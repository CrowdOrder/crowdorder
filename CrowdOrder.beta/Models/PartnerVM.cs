using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Models
{
    public class PartnerVM : Partner
    {
        public int PrimaryServiceId { get; set; }
    }
}
