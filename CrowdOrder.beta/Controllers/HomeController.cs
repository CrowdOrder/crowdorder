using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CrowdOrder.beta.Models;
using System.Security.Claims;
using CrowdOrder.beta.Data;

namespace CrowdOrder.beta.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CompanyRepository _companyRepository;

        public HomeController(ILogger<HomeController> logger, CompanyRepository companyRepository)
        {
            _logger = logger;
            _companyRepository = companyRepository;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var id = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var company = _companyRepository.FindByUserId(Guid.Parse(id));
                if (company == null)
                {
                    //user has not completed registration
                    return RedirectToAction("Company");
                }
            }
            

            return View();
        }
        public IActionResult Company()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Company(Company model)
        {
            //Validate model
            //save model
            model.UserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            bool success = _companyRepository.Upsert(ref model);
            if (success)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Terms()
        {
            return View();
        }
        public IActionResult Cookies()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
