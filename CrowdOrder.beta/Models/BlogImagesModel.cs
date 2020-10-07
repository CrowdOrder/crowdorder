using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Models
{
    public class BlogImagesModel
    {
        public IFormFile UploadImage { set; get; }
    }
}
