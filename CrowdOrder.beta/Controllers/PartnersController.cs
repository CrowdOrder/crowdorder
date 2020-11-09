using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrowdOrder.beta.Data;
using CrowdOrder.beta.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CrowdOrder.beta.Controllers
{ 
    public class PartnersController : Controller
    {
        private readonly ILogger<PartnersController> _logger;
        private readonly PartnerRepository _partnerRepository;

        public PartnersController(ILogger<PartnersController> logger, 
            PartnerRepository partnerRepository)
        {
            _logger = logger;
            _partnerRepository = partnerRepository;
        }
        public IActionResult Index()
        {
            var model = _partnerRepository.ListAll();
            return View(model);
        }

        [Authorize]
        public IActionResult Edit(int id)
        {
            var model = _partnerRepository.FindById(id);
            return View(model);
        }

        [Authorize]
        public IActionResult Active(int id)
        {
            _partnerRepository.SetActive(id);
            return RedirectToAction("index", "partners");
        }

        [Authorize]
        public IActionResult Create()
        {
            var model = new Partner();
            return View(model);
        }
        public ActionResult Details(int id)
        {
            var model = _partnerRepository.FindById(id);
            return View(model);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Url,Name,Title,MetaDescription,H1,Body,About,MainContact,MainContactInformalName,MainContactEmail,MainContactTel,LogoUrl,SiteUrl,DefaultPartnerSignupType,DiscountPricing,Notes,Inactive")] Partner partner)
        {
            if (ModelState.IsValid)
            {
                partner.InActive = true;
                Partner model = partner;
                _partnerRepository.Upsert(ref model);

                return RedirectToAction("index", "partners");
            }

            return View(partner);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Url,Name,Title,MetaDescription,H1,Body,About,MainContact,MainContactInformalName,MainContactEmail,MainContactTel,LogoUrl,SiteUrl,DefaultPartnerSignupType,DiscountPricing,Notes,Inactive")] Partner partner)
        {

            if (ModelState.IsValid)
            {
                _partnerRepository.Upsert(ref partner);
             
                return RedirectToAction(nameof(Index));
            }
            return View(partner);
        }
    }
}