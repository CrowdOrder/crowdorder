using CrowdOrder.beta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Data
{
    public class ArticlesRepository
    {
        private readonly ILogger<ArticlesRepository> _logger;
        private readonly ApplicationDbContext _context;
        private readonly Cache _cache;

        public ArticlesRepository(ILogger<ArticlesRepository> logger, ApplicationDbContext context, Cache cache)
        {
            _logger = logger;
            this._context = context;
            _cache = cache;
        }

        public List<Article> GetLatestBlogs(int count)
        {
            var data = _context.Articles.Where(a => a.InActive != true).Include(a => a.Author).OrderByDescending(x => x.CreatedDate).Take(count).ToList();
            return data;
        }
        public List<Article> GetAllActive()
        {
            var data = _context.Articles.Where(a => a.InActive != true).Include(a => a.Author).OrderByDescending(x => x.CreatedDate).ToList();
            return data;
        }
        public List<Article> GetAll()
        {
            var data = _context.Articles.Include(a => a.Author).OrderByDescending(x => x.CreatedDate).ToList();
            return data;
        }

        internal Article FindByUrl(string id)
        {
            var data =  _context.Articles
                        .Include(a => a.Author)
                        .FirstOrDefault(m => m.Url == id);
            return data;
        }

        internal Article FindById(int? id)
        {
            var data = _context.Articles.Where(x => x.ArticleId == id).FirstOrDefault();
            return data;
        }

        internal void Update(Article article)
        {
            _context.Update(article);
            _context.SaveChanges();
        }

        internal void SetInActive(int? id)
        {
            var article = _context.Articles.Where(x => x.ArticleId == id).FirstOrDefault();
            article.InActive = true;
            _context.Update(article);
            _context.SaveChanges();
        }
        internal void Publish(int? id)
        {
            var article = _context.Articles.Where(x => x.ArticleId == id).FirstOrDefault();
            article.InActive = false;
            _context.Update(article);
            _context.SaveChanges();
        }

        internal bool ArticleExists(int articleId)
        {
            return _context.Articles.Any(e => e.ArticleId == articleId);            
        }

        internal void Add(Article article)
        {
            _context.Add(article);
            _context.SaveChanges();
        }
    }
}
