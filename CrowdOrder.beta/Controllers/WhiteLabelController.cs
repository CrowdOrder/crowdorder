using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrowdOrder.beta.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CrowdOrder.beta.Controllers
{
    public class WhiteLabelController : Controller
    {
        private readonly ILogger<ServicesController> _logger;
        private readonly CategoryRepository _categoryRepository;
        private readonly ServicesRepository _servicesRepository;
        private readonly IConfiguration _configuration;

        public WhiteLabelController(ILogger<ServicesController> logger,
            CategoryRepository categoryRepository, ServicesRepository servicesRepository, IConfiguration configuration)
        {
            _logger = logger;
            _categoryRepository = categoryRepository;
            _servicesRepository = servicesRepository;
            _configuration = configuration;
        }
        public IActionResult Index(string showall)
        {
            //var affiliate = HttpContext.Session.GetString(_configuration["AffiliateKey"]);
            var includeEmpty = showall == "true";
            var model = _categoryRepository.MenuData();
            return View(model);
        }
        public IActionResult Details(int id)
        {
            var model = _categoryRepository.MenuData().Find(x => x.Id == id);
            return View(model);
        }
    }
}
