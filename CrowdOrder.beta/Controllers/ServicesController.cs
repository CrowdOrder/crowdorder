using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrowdOrder.beta.Data;
using CrowdOrder.beta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrowdOrder.beta.Controllers
{
    public class ServicesController : Controller
    {
        private readonly ILogger<ServicesController> _logger;
        private readonly CategoryRepository _categoryRepository;
        private readonly ServicesRepository _servicesRepository;
        private readonly PartnerRepository _partnerRepository;

        public ServicesController(ILogger<ServicesController> logger, 
            CategoryRepository categoryRepository, ServicesRepository servicesRepository, PartnerRepository partnerRepository)
        {
            _logger = logger;
            _categoryRepository = categoryRepository;
            _servicesRepository = servicesRepository;
            _partnerRepository = partnerRepository;
        }

        /// <summary>
        /// List Categorys
        /// </summary>
        /// <param name="showall"></param>
        /// <returns></returns>
        public IActionResult Index(string showall)
        {
            var includeEmpty = showall == "true";
            var cats = _categoryRepository.MenuData();
            var featured = _partnerRepository.FindById(2);
            var model = new ServicesVM() { Categories = cats, FeaturedPartner = featured};

            return View(model);
        }

        /// <summary>
        /// List Sub Categorys - by category Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Details (int id)
        {
            var model = _categoryRepository.MenuData().Find(x => x.Id == id);
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var model = _servicesRepository.FindById(id);
            return View(model);
        }

        public IActionResult Create(int id)
        {            
            var model = _servicesRepository.CreateNew(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Url,Name,Title,MetaDescription,H1,Body,DiscountOffer,ConnectUrl,ConnectContact,ConnectEmail,QualifyingCriteria,PartnerSignupType,PartnerId,SubCategoryId")] Service service)
        {
            if (ModelState.IsValid)
            {
                service.Id = null;
                _servicesRepository.Upsert(ref service);
                return RedirectToAction("index", "partners");
            }

            return View(service);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Url,Name,Title,MetaDescription,H1,Body,DiscountOffer,ConnectUrl,ConnectContact,ConnectEmail,QualifyingCriteria,PartnerSignupType,PartnerId,SubCategoryId")] Service service)
        {

            if (ModelState.IsValid)
            {
                _servicesRepository.Upsert(ref service);

                return RedirectToAction("index", "partners");
            }
            return View(service);
        }

        /// <summary>
        /// List Services - By Sub Category Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Services(int id)
        {
            var model = _servicesRepository.FindBySubCategoryId(id);
            return View(model);
        }

        public IActionResult Partner (int id)
        {
            var model = _servicesRepository.FindById(id);
            return View(model);
        }

        public IActionResult PartnerServices(int id)
        {
            var model = _servicesRepository.FindByPartnerId(id);
            return View(model);
        }
    }
}