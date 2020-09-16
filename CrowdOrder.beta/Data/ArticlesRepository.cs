using CrowdOrder.beta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var data = _context.Articles.Include(a => a.Author).OrderByDescending(x => x.CreatedDate).Take(count).ToList();
            return data;
        }
    }
}
