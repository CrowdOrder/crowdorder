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
    public class AdminController : Controller
    {
        private readonly ILogger<ServicesController> _logger;
        private readonly PartnerRepository _partnerRepository;
        public AdminController(ILogger<ServicesController> logger, 
            PartnerRepository partnerRepository)
        {
            _logger = logger;
            _partnerRepository = partnerRepository;
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