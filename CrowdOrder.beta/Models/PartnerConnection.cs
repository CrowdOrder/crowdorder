using CrowdOrder.beta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Models
{
    public class PartnerConnection
    {
        public int? Id { get; set; }
        public Service Service { get; set; }
        public Guid UserId { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
