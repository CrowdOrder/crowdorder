using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CrowdOrder.beta.Data;
using CrowdOrder.beta.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CrowdOrder.beta.Controllers
{
    [Authorize]
    public class PartnerConnectController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ServicesRepository _serviceRepository;
        private readonly PartnerConnectionRepository _partnerConnectionRepository;
        private readonly SiteDataService _siteDataService;
        private readonly PartnerConnectionsService _partnerConnectionsService;
        private readonly CompanyRepository _companyRepository;
        private readonly IEmailSender _emailSender;
        public PartnerConnectController(IConfiguration configuration, ServicesRepository serviceRepository, PartnerConnectionRepository partnerConnection, SiteDataService siteDataservice, PartnerConnectionsService partnerConnectionsService,
            CompanyRepository companyRepository,
            IEmailSender emailSender)
        {
            this._configuration = configuration;
            this._serviceRepository = serviceRepository;
            this._partnerConnectionRepository = partnerConnection;
            this._siteDataService = siteDataservice;
            this._partnerConnectionsService = partnerConnectionsService;
            this._companyRepository = companyRepository;
            _emailSender = emailSender;
        }
        // GET: PartnerConnectController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PartnerConnectController/Details/5
        public ActionResult Details(int id)
        {
            var service = _serviceRepository.FindById(id);
            var url = service.ConnectUrl;
            var claim = User.FindFirst(ClaimTypes.NameIdentifier);
            var userId = Guid.Parse(claim.Value);
            var company = _companyRepository.FindByUserId(userId);
            
            var connect = new PartnerConnection()
            {
                Service = service,
                UserId = userId,
                Timestamp = DateTime.UtcNow
            };

            var newConnect = _partnerConnectionRepository.Upsert(ref connect);
            if (newConnect)
            {
                //add to cache
                _partnerConnectionsService.SetConnectionToCache(connect);
                if (service.PartnerSignupType == DataHelpers.PartnerSignupType.Email)
                {
                    //send email to user
                    var msg = $"This is just an email to confirm that we’ve just connected you to our Partner, {connect.Service.Partner.Name}, as you requested. "
                        + $"We’ll leave you to discuss your business requirements directly with them, but rest assured that you will now automatically receive the {connect.Service.DiscountOffer} discount should you decide to start working with {connect.Service.Partner.Name}."
                        + "Best of luck and thanks for your using Crowd Order!";
                    var greeting = $"Hi {company.ContactFirstName},";
                    ((EmailSender)_emailSender).SendEmailAsync(User.Identity.Name, "Crowd Order Connection"
                        , msg, "Visit Crowd Order", "https://www.crowdorder.co.uk", greeting
                        );

                    //Override emails and dont send to partner if set in appsettings
                    var email = _configuration["OverrideConnectionEmails"] != "" ? _configuration["OverrideConnectionEmails"] : connect.Service.Partner.MainContactEmail;
                    //send email to partner
                    var connectMsg = $"I'd like to introduce you to {company.ContactFirstName} from {company.Name} who is interested in exploring the rates you offer to Crowd Order's users.";
                    var connectGreeting = $"Hi {connect.Service.Partner.MainContact}";
                    ((EmailSender)_emailSender).SendEmailAsync(email, "Introduction"
                        , connectMsg, "Visit Crowd Order", "https://www.crowdorder.co.uk", connectGreeting
                        );

                }
            }

            var model = new PartnerConnectionVM() { PartnerConnection = connect, Suggestions = _siteDataService.GetSuggestedService(3, 0, connect.Service.Id) };

            return View(model);            
        }

        // GET: PartnerConnectController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PartnerConnectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PartnerConnectController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PartnerConnectController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PartnerConnectController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PartnerConnectController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
