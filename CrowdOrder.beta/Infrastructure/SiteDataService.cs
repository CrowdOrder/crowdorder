using CrowdOrder.beta.Data;
using CrowdOrder.beta.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Infrastructure
{
    public class SiteDataService
    {
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _context;
        private readonly ILogger<SiteDataService> _logger;
        private readonly CategoryRepository _categoryRepository;
        private readonly ServicesRepository _servicesRepository;
        private readonly ArticlesRepository _articlesRepository;
        private readonly PartnerRepository _partnerRepository;
        private readonly SubCategoryRepository _subCategoryRepository;
        private readonly IgnoresRepository _ignoresRepository;

        public SiteDataService(ILogger<SiteDataService> logger, IConfiguration configuration,
            ApplicationDbContext context, CategoryRepository categoryRepository, ServicesRepository servicesRepository, ArticlesRepository articlesRepository, PartnerRepository partnerRepository, 
            SubCategoryRepository subCategoryRepository,
            IgnoresRepository ignoresRepository)
        {
            _logger = logger;
            _configuration = configuration;
            _context = context;
            _categoryRepository = categoryRepository;
            _servicesRepository = servicesRepository;
            _articlesRepository = articlesRepository;
            _partnerRepository = partnerRepository;
            _subCategoryRepository = subCategoryRepository;
            _ignoresRepository = ignoresRepository;
        }
        public List<Service> GetSuggestedService(int howMany, int subcategoryId, int? omit)
        {
            //TODO - sort this out properley with randoms etc
            var result = new List<Service>();
            if (subcategoryId == 0 && omit != null)
            {
                var data =  _servicesRepository.GetAll().Where(x => x.Id != omit).ToList();
                var random = new Random();
                while(howMany  > 0)
                {
                    int index = random.Next(data.Count);
                    var service = data[index];
                    if (!result.Contains(service))
                    {
                        result.Add(service);
                        howMany--;
                    }
                }                
            }
            return result;
        }

        public bool UserIsCrowdOrder(ClaimsPrincipal user)
        {   
            return user.Identity.Name.Contains("crowdorder.co.uk");
        }
        public List<Article> GetLatestBlogs(int count)
        {
            var data = _articlesRepository.GetLatestBlogs(count);
            return data;
        }
        public List<Partner> GetPartnerLogos(HttpContext context)
        {
            var affiliate = context.Session.GetString(_configuration["AffiliateKey"]);
            if (affiliate != null)
            {
                var data = _partnerRepository.GetAllNotIgnored(affiliate).OrderBy(x => Guid.NewGuid()).Take(6).ToList();
                return data;
            }
            return _partnerRepository.ListAll().OrderBy(x => Guid.NewGuid()).Take(6).ToList();
        }
        public bool IsDev
        {
            get
            {
                return _configuration["Environment"].ToLower() == "dev";
            }
            
        }

        public List<SelectListItem> GetSubCategoriesSelectList()
        {

            return _subCategoryRepository.ListAll().Select(a => new SelectListItem
            {
                Value = ((int)a.Id).ToString(),
                Text = $"{a.Category.Name}-{a.Name}"
            }).OrderBy(o => o.Text).ToList();
        }

        public List<Category> AffiliatesMenuData(HttpContext context)
        {
            var affiliate = context.Session.GetString(_configuration["AffiliateKey"]);
            if (affiliate != null)
            {
                var ignorepartners = _ignoresRepository.Partners().Where(x => x.Affiliate.Link == affiliate).Select(p => p.Partner.Id).ToArray();
                var ignorecategories = _ignoresRepository.Categories().Where(x => x.Affiliate.Link == affiliate).Select(p => p.Category.Id).ToArray();
                var ignoresubCategories = _ignoresRepository.SubCategories().Where(x => x.Affiliate.Link == affiliate).Select(p => p.SubCategory.Id).ToArray();



                var services = _context.Service.Where(x => !ignorepartners.Contains(x.PartnerId));

                var scA = from sce in _context.SubCategorys.Include(x => x.Services).ThenInclude(p => p.Partner)
                 .Include(c => c.Category)
                          where services.Any(m => m.SubCategoryId == sce.Id)
                          select sce;

                var dataA = new List<Category>();
                foreach (var sub in scA)
                {
                    if (!ignorecategories.Contains(sub.Category.Id))
                    {
                        if (!ignoresubCategories.Contains(sub.Id))
                        {
                            if (!dataA.Contains(sub.Category))
                            {                           
                                var cat = sub.Category;
                                cat.SubCategories = new List<SubCategory>();
                                cat.SubCategories.Add(sub);
                                dataA.Add(cat);
                            }
                            else
                            {
                                //fix for weird bug where it adds twice
                                if(!dataA.Find(x => x == sub.Category).SubCategories.Contains(sub))
                                {
                                    dataA.Find(y => y == sub.Category).SubCategories.Add(sub);
                                }
                            }
                        }
                    }                        
                }

                return dataA;
            }

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
        }
    }
}
