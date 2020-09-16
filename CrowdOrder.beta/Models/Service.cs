using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CrowdOrder.beta.Data.DataHelpers;

namespace CrowdOrder.beta.Models
{
    public class Service : PageObjectBase
    {        
        public string DiscountOffer { get; set; }
        public string ConnectUrl { get; set; }
        public string ConnectContact { get; set; }
        public string ConnectEmail { get; set; }
        public string QualifyingCriteria { get; set; }

        public PartnerSignupType PartnerSignupType { get; set; }
        public virtual Partner Partner{get;set;}
        
        public SubCategory SubCategory { get; set; }

    }
}
