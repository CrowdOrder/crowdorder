using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrowdOrder.beta.Data;
using CrowdOrder.beta.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrowdOrder.beta.Controllers
{
    [Authorize]
    public class AffiliateController : Controller
    {
        private readonly AffiliatesRepository _repo;

        public AffiliateController(AffiliatesRepository repo)
        {
            _repo = repo;
        }

        // GET: Articles
        public IActionResult Index()
        {
            return View(_repo.ListAll());
        }

        // GET: Articles/Create
        public IActionResult Create()
        {
            var model = new Affiliate();
            return View(model);
        }

        // POST: Articles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,Email,Telephone,Link,Notes")] Affiliate model)
        {
            if (ModelState.IsValid)
            {               
                _repo.Upsert(ref model);

                return RedirectToAction("index", "Affiliate");
            }
            //ViewData["AuthorId"] = new SelectList(_context.Users, "Id", "Id", article.AuthorId);
            return View(model);
        }

        // GET: Articles/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliate = _repo.FindById((int)id);
            if (affiliate == null)
            {
                return NotFound();
            }
            return View(affiliate);
        }

        // POST: Articles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Name,Email,Telephone,Link,Notes")] Affiliate model)
        {

            if (ModelState.IsValid)
            {
                
                _repo.Upsert(ref model);
                
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
    }
}
