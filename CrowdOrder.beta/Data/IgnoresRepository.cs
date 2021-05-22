using CrowdOrder.beta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Data
{
    public class IgnoresRepository
    {
        private readonly ILogger<IgnoresRepository> _logger;
        private readonly ApplicationDbContext _context;

        public IgnoresRepository(ILogger<IgnoresRepository> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        internal List<AffiliateIgnorePartner> Partners()
        {
            var data = _context.AffiliateIgnorePartners.Include(x => x.Partner).Include(x => x.Affiliate).ToList();
            return data;
        }
        internal List<AffiliateIgnoreCategory> Categories()
        {
            var data = _context.AffiliateIgnoreCategorys.Include(x => x.Category).Include(x => x.Affiliate).ToList();
            return data;
        }
        internal List<AffiliateIgnoreSubCategory> SubCategories()
        {
            var data = _context.AffiliateIgnoreSubCategorys.Include(x => x.SubCategory).Include(x => x.Affiliate).ToList();
            return data;
        }
    }
}
