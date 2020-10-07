using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CrowdOrder.beta.Data;
using CrowdOrder.beta.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CrowdOrder.beta.Controllers
{
    public class BlogController : Controller
    {
        private readonly ArticlesRepository _repo;

        public BlogController(ArticlesRepository repo )
        {
            _repo = repo;
        }

        // GET: Articles
        public IActionResult Index()
        {            
            return View(_repo.GetAllActive());
        }

        // GET: Articles/Details/5
        public IActionResult Details(string? id)
        {
            //is this a direct link to Details/int or from rewrite?
            var articleId = 0;
            int.TryParse(id, out articleId);

            Article article;

            if (articleId == 0)
            {
                //it was a rewrite
                if (id == null)
                {
                    return NotFound();
                }
                else
                {
                    article = _repo.FindByUrl(id); 
                }
            }
            else
            {
                article = _repo.FindById(int.Parse(id));
            }

            
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        // GET: Articles/Create
        [Authorize]
        public IActionResult Create()
        {
            //ViewData["AuthorId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Articles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ArticleId,Title,Url,Abstract,Contents,CreatedDate,AuthorId,MainImagePath,AuthorName")] Article article)
        {
            if (ModelState.IsValid)
            {
                article.AuthorId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                article.CreatedDate = DateTime.Now;
                article.InActive = true;
                _repo.Add(article);
                
                return RedirectToAction("BlogList", "Admin");
            }
            //ViewData["AuthorId"] = new SelectList(_context.Users, "Id", "Id", article.AuthorId);
            return View(article);
        }

        // GET: Articles/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = _repo.FindById(id);
            article.InActive = article.InActive == true;
            if (article == null)
            {
                return NotFound();
            }
            //ViewData["AuthorId"] = new SelectList(_context.Users, "Id", "Id", article.AuthorId);
            return View(article);
        }

        // POST: Articles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("ArticleId,Title,Abstract,Contents,CreatedDate,AuthorId,Url,MainImagePath,InActive")] Article article)
        {
            
            if (ModelState.IsValid)
            {
                try
                {
                    _repo.Update(article);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_repo.ArticleExists(article.ArticleId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            //ViewData["AuthorId"] = new SelectList(_context.Users, "Id", "Id", article.AuthorId);
            return View(article);
        }

        [HttpPost]
        public IActionResult Publish(int id)
        {
            _repo.Publish(id);
            return RedirectToAction("index");
        }

        //// GET: Articles/Delete/5
        //[Authorize]
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    _repo.SetInActive(id);

        //    return View(article);
        //}

        //// POST: Articles/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var article = await _context.Articles.FindAsync(id);
        //    _context.Articles.Remove(article);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}


    }
}
