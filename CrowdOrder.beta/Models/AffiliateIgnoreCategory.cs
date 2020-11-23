using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Models
{
    public class AffiliateIgnoreCategory
    {
        [Key]
        public int Id { get; set; }
        public Affiliate Affiliate { get; set; }
        public Category Category { get; set; }
    }
}
