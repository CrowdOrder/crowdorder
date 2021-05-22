using CrowdOrder.beta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        public IDirectoryContents PhysicalFiles { get; private set; }
        private readonly IFileProvider _fileProvider;
        private readonly ILogger<ImagesController> _logger;
        public ImagesController(ILogger<ImagesController> logger, IFileProvider fileProvider)
        {
            _logger = logger;
            _fileProvider = fileProvider;
        }

        public void OnGet()
        {
            PhysicalFiles = _fileProvider.GetDirectoryContents(string.Empty);
        }

        [HttpPost]
        public IActionResult Post(FileUploadModel model)
        {
            if (new FileExtensionContentTypeProvider().TryGetContentType(model.FileName, out var contentType))
            {
                // This is the point where we should persist the image bytes to a persistent store.
                // This could be anything from storing the image in a database (MySql, SqlServer), disk,
                // or object store (Amazon S3, Azure Blog Storage, Digital Ocean Spaces)

                // Once the image is stored, we'll want to return the url of where the image is stored
                // in the response. For the time being, this image url will be hardcoded so that the
                // TinyMCE editor functions.
                string imageUrl = "https://dustyhoppe-blog-images-prod.sfo2.cdn.digitaloceanspaces.com/cat-image-qf76g35k.jpg";
                return Ok(new { imageUrl });
            }

            return UnprocessableEntity(new { Message = $"Cannot determine content type for file '{model.FileName}'." });
        }
    }
}
