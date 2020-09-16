using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrowdOrder.beta.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrowdOrder.beta.Controllers
{
    public class ServicesController : Controller
    {
        private readonly ILogger<ServicesController> _logger;
        private readonly CategoryRepository _categoryRepository;
        private readonly ServicesRepository _servicesRepository;
        public ServicesController(ILogger<ServicesController> logger, 
            CategoryRepository categoryRepository, ServicesRepository servicesRepository)
        {
            _logger = logger;
            _categoryRepository = categoryRepository;
            _servicesRepository = servicesRepository;
        }

        /// <summary>
        /// List Categorys
        /// </summary>
        /// <param name="showall"></param>
        /// <returns></returns>
        public IActionResult Index(string showall)
        {
            var includeEmpty = showall == "true";
            var model = _categoryRepository.MenuData();
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
    }
}