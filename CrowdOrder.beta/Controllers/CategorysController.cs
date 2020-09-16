using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrowdOrder.beta.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrowdOrder.beta.Controllers
{
    public class CategorysController : Controller
    {
        private readonly ILogger<ServicesController> _logger;
        private readonly CategoryRepository _categoryRepository;
        public CategorysController(ILogger<ServicesController> logger, 
            CategoryRepository categoryRepository, ServicesRepository servicesRepository)
        {
            _logger = logger;
            _categoryRepository = categoryRepository;
        }
        // GET: Categorys
        public ActionResult Index()
        {
            return View();
        }

        // GET: Categorys/Details/5
        public ActionResult Details(int id)
        {
            var model = _categoryRepository.MenuData().Find(x => x.Id == id);
            return View(model);
        }

        // GET: Categorys/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categorys/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Categorys/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Categorys/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Categorys/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Categorys/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}