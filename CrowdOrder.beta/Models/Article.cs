using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Models
{
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }
        public string Url { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Abstract { get; set; }
        [Required]
        public string Contents { get; set; }
        public DateTime CreatedDate { get; set; }
        public string AuthorName { get; set; }
        public string AuthorId { get; set; }
        public virtual IdentityUser Author { get; set; }

    }
}
