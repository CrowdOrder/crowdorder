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
using Microsoft.AspNetCore.Identity.UI.Services;
using CrowdOrder.beta.Infrastructure;
using Microsoft.AspNetCore.Diagnostics;
using System.IO;

namespace CrowdOrder.beta.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CompanyRepository _companyRepository;
        private readonly IEmailSender _emailSender;

        public HomeController(ILogger<HomeController> logger, CompanyRepository companyRepository,
            IEmailSender emailSender)
        {
            _logger = logger;
            _companyRepository = companyRepository;
            this._emailSender = emailSender;
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
            var userEmail =  User.FindFirstValue(ClaimTypes.Name);
            var banned = new List<string> { "@hotmail", "@gmail", "@googlemail", "@live" };

            var result = banned.Any(w => userEmail.Contains(w));
            var model = new Company();
            if (!result)
            {
                model.Email = userEmail;
            }
            return View(model);
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
                //send a thank you signup email
                //send email to user
                var msg = "";
                
                var greeting = $"Hi {model.ContactFirstName},";
                
                ((EmailSender)_emailSender).SendEmailAsync(User.Identity.Name, "Welcome to Crowd Order"
                    , msg, "Explore Exclusive Rates", "https://www.crowdorder.co.uk", greeting, EmailSender.EmailTemplate.Welcome);

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
            // Get the details of the exception that occurred
            var exceptionFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            if (exceptionFeature != null)
            {
                // Get which route the exception occurred at
                //string routeWhereExceptionOccurred = exceptionFeature.Path;

                // Get the exception that occurred
                Exception exceptionThatOccurred = exceptionFeature.Error;

                _logger.LogError(exceptionThatOccurred, exceptionThatOccurred.Message);
            }

            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
