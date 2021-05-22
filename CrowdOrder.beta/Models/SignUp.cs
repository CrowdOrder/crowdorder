using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace CrowdOrder.beta.Models
{
    public class SignUp
    {
        [Key]
        public int Id { get; set; }
        public virtual Affiliate Affiliate { get; set; }
        public virtual IdentityUser User { get; set; }
        public DateTime TimeStamp { get; set; }
        public DateTime? ReconciledDate { get; set; }
    }
}