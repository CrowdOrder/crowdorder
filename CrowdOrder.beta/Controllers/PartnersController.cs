using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrowdOrder.beta.Data;
using CrowdOrder.beta.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index(int id)
        {
            return View();
        }
        public ActionResult Details(int id)
        {
            var model = _partnerRepository.FindById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Details(Partner model)
        {
            //var model = _partnerRepository.FindById(1);
            return View(model);
        }

    }
}