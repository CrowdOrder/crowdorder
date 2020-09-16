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
    public class SubCategorysController : Controller
    {
        private readonly ILogger<SubCategorysController> _logger;
        private readonly SubCategoryRepository _subCategoryRepository;

        public SubCategorysController(ILogger<SubCategorysController> logger, 
            SubCategoryRepository subCategoryRepository)
        {
            _logger = logger;
            _subCategoryRepository = subCategoryRepository;

        }
        // GET: SubCategorys
        public ActionResult Index(int id)
        {
            return View();
        }

        // GET: SubCategorys/Details/5
        public ActionResult Details(int id)
        {
            var model = _subCategoryRepository.FindById(id);
            return View(model);
        }

        // GET: SubCategorys/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubCategorys/Create
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

        // GET: SubCategorys/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubCategorys/Edit/5
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

        // GET: SubCategorys/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SubCategorys/Delete/5
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