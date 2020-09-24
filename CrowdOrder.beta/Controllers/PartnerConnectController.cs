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
                    var email = _configuration["OverrideConnectionEmails"] != "" ? _configuration["OverrideConnectionEmails"] : connect.Service.Partner.MainContactEmail;
                    var recipients = new List<string>() { email, User.Identity.Name };
                    var greeting = $"Hi {connect.Service.Partner.MainContactInformalName},";
                    var body = $"I'd like to introduce you to {company.ContactFirstName} from {company.Name} who is interested in exploring the rates you offer to Crowd Order's users.";

                    var greeting2 = $"Hi {company.ContactFirstName},";
                    var body2 = $"Please meet {connect.Service.Partner.MainContact} from {connect.Service.Partner.Name} who is well placed to talk you through their offering in more detail. " +
                        $"I'm sure {connect.Service.Partner.MainContactInformalName}  will reach out shortly to introduce themselves properly and thanks again for using Crowd Order. ";


                    var dynamicTemplateData = new ExampleTemplateData
                    {                       
                        Subject = "Connection request",
                        Greeting = greeting,
                        Body = body,
                        Greeting2 = greeting2,
                        Body2 = body2
                    };

                    ((EmailSender)_emailSender).SendEmailAsync(recipients, dynamicTemplateData, EmailSender.EmailTemplate.ConnectionEmail);

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
