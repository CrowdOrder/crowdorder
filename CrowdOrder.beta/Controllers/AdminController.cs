using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CrowdOrder.beta.Data;
using CrowdOrder.beta.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;

namespace CrowdOrder.beta.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly ILogger<ServicesController> _logger;
        private readonly PartnerRepository _partnerRepository;
        private readonly AffiliatesRepository _affiliateRepository;

        public IDirectoryContents PhysicalFiles { get; private set; }
        private readonly IFileProvider _fileProvider;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;
        public AdminController(ILogger<ServicesController> logger, 
            PartnerRepository partnerRepository, AffiliatesRepository affiliateRepository,
            UserManager<IdentityUser> userManager,
            ApplicationDbContext context, IFileProvider fileProvider)
        {
            _logger = logger;
            _partnerRepository = partnerRepository;
            _affiliateRepository = affiliateRepository;
            _fileProvider = fileProvider;
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {            
            return View();

        }
        public IActionResult BlogImages()
        {
            PhysicalFiles = _fileProvider.GetDirectoryContents(string.Empty);
             
            return View(PhysicalFiles);

        }

        public IActionResult UserList()
        {
            var query = from u in _userManager.Users
                        join c in _context.Companys on u.Id equals c.UserId.ToString() into uc
                        from cu in uc.DefaultIfEmpty()
                        select new UserVM
                        {
                            Id = u.Id,
                            Email = u.Email,
                            Firstname = cu.ContactFirstName ?? string.Empty,
                            Lastname = cu.ContactLastName ?? string.Empty,
                            FullName = $"{cu.ContactFirstName ?? string.Empty} {cu.ContactLastName ?? string.Empty}",
                            Company = cu.Name ?? string.Empty,
                            CompanyEmail = cu.Email ?? string.Empty
                        };
            
            return View(query.OrderByDescending(x => x.Company));
        }

        [HttpPost]
        public IActionResult BlogImages(IFormFile file)
        {
            var fileName = System.IO.Path.GetFileName(file.FileName);
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\blogs", fileName);

            // If file with same name exists delete it
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }

            // Create new local file and copy contents of uploaded file
            using (var localFile = System.IO.File.OpenWrite(filePath))
            using (var uploadedFile = file.OpenReadStream())
            {               
                uploadedFile.CopyTo(localFile);
            }

            ViewBag.Message = "File successfully uploaded";

            PhysicalFiles = _fileProvider.GetDirectoryContents(string.Empty);

            return View(PhysicalFiles);
        }
        public async Task<IActionResult> BlogList()
        {
            var applicationDbContext = _context.Articles.Include(a => a.Author);
            return View(await applicationDbContext.ToListAsync());

        }
        public IActionResult Partners()
        {
            var model = _partnerRepository.ListAll();
            return View(model);
        }

        public IActionResult Details(string id)
        {
            var model = _partnerRepository.FindById(int.Parse(id));
            return View(model);
        }
        [HttpPost]
        public IActionResult Details(Partner model)
        {
            _partnerRepository.Upsert(ref model);
            return View(model);
        }
    }
}