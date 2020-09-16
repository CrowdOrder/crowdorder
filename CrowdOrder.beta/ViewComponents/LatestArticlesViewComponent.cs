
using CrowdOrder.beta.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.ViewComponents
{
    public class LatestArticlesViewComponent: ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public LatestArticlesViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int howMany = 2)
        {
            var lastArticles = await _context.Articles
                                            .OrderByDescending(a => a.CreatedDate)
                                            .Take(howMany)
                                            .ToListAsync();
            return View(lastArticles);
        }
    }
}
