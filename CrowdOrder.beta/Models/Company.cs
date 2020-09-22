using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Models
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = " * ")]
        public string Name { get; set; }
        [Required(ErrorMessage =" * ")]
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string Url { get; set; }
        
        [Required(ErrorMessage = " * ")]
        [RegularExpression(@"^(?:(?!@gmail|@hotmail|@googlemail|@live).)*$\r?\n?", ErrorMessage =" Please do not use your personal email(hotmail. gmail etc)")]
        public string Email { get; set; }
        public string Address { get; set; }

        public Guid UserId { get; set; }
    }
}
