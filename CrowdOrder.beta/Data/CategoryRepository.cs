using CrowdOrder.beta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Data
{
    public class CategoryRepository
    {
        private readonly ILogger<CategoryRepository> _logger;
        private readonly ApplicationDbContext _context;
        private readonly Cache _cache;

        public CategoryRepository(ILogger<CategoryRepository> logger, ApplicationDbContext context, Cache cache)
        {
            _logger = logger;
            this._context = context;
            _cache = cache;
        }
        public List<Category> ListAll(bool includeEmpty = false)
        {
            if (includeEmpty)
            {
                var data = _context.Categorys.Include(x => x.SubCategories).ToList();
                return data;
            }
            else
            {
                var data = _context.Categorys.Include(x => x.SubCategories)
                    .Where(x => x.SubCategories.Any())
                    .ToList();
                return data;
            }
        }

        internal Category FindById(int id, bool includeEmpty = false)
        {
            if (includeEmpty)
            {
                var data = _context.Categorys.Include(x => x.SubCategories).Where(x => x.Id == id).FirstOrDefault();
                return data;
            }
            else
            
            {
                var data = _context.Categorys.Include(x => x.SubCategories)
                   .Where(x => x.SubCategories.Any() && x.Id == id)
                   .FirstOrDefault();
                return data;
            }
        }
        public List<Category> MenuData()
        {
            return _cache.Memoize(
                "CrowdOrder.Menu",
                () =>
                {
                    var sc = _context.SubCategorys.Include(x => x.Services).ThenInclude(p => p.Partner)
                        .Include(c => c.Category)
                        .Where(s => s.Services.Any()).ToList();

                    var data = new List<Category>();
                    foreach (var sub in sc)
                    {
                        if (!data.Contains(sub.Category))
                        {
                            var cat = sub.Category;
                            cat.SubCategories = new List<SubCategory>();
                            cat.SubCategories.Add(sub);
                            data.Add(cat);
                        }
                        else
                        {
                            data.Find(x => x == sub.Category).SubCategories.Add(sub);
                        }
                    }

                    return data;
                },
                DateTime.UtcNow.TimeToMidnight()
                );
        }
    }
}
