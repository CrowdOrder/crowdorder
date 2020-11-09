using CrowdOrder.beta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Data
{
    public class SubCategoryRepository
    {
        private readonly ILogger<SubCategoryRepository> _logger;
        private readonly ApplicationDbContext _context;
        private readonly Cache _cache;

        public SubCategoryRepository(ILogger<SubCategoryRepository> logger, ApplicationDbContext context, Cache cache)
        {
            _logger = logger;
            this._context = context;
            _cache = cache;
        }

        internal SubCategory FindById(int id, bool includeEmpty = false)
        {
            if (includeEmpty)
            {
                var data = _context.SubCategorys.Include(x => x.Services).Where(x => x.Id == id).FirstOrDefault();
                return data;
            }
            else

            {
                var data = _context.SubCategorys.Include(x => x.Services).ThenInclude(p => p.Partner).Where(sc => sc.Id == id).FirstOrDefault();
                return data;
            }
        }

        internal List<SubCategory> ListAll()
        {
            var data = _context.SubCategorys.Include(x => x.Category).ToList();
            return data;         
        }
    }
}
