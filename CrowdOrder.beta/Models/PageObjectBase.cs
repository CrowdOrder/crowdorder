using System.ComponentModel.DataAnnotations;

namespace CrowdOrder.beta.Models
{
    public abstract class PageObjectBase
    {
        [Key]
        public int? Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string MetaDescription { get; set; }
        public string H1 { get; set; }
        public string Body { get; set; }
    }
}
