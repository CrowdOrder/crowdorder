using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static CrowdOrder.beta.Data.DataHelpers;

namespace CrowdOrder.beta.Models
{
    public class Partner : PageObjectBase
    {
        public string About { get; set; }
        public string MainContact { get; set; }
        public string MainContactEmail { get; set; }
        public string MainContactTel { get; set; }
        public string LogoUrl { get; set; }
        public string SiteUrl { get; set; }
        public PartnerSignupType DefaultPartnerSignupType { get; set; }
        public string Notes { get; set; }
        public List<Service> Services { get; set; }
        public bool? InActive { get; set; }

    }
}
