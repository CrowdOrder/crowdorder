using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Data
{
    public static class DataHelpers
    {
        public enum PartnerSignupType
        {
            [Display(Name = "Url")]
            Url = 1,
            [Display(Name = "Email")]
            Email = 2
        }

        public static TimeSpan TimeToMidnight(this DateTime dateTime)
        {
            return dateTime.AddDays(1).Date - dateTime;
        }
    }
}
