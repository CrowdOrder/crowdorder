using CrowdOrder.beta.Data;
using CrowdOrder.beta.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        private readonly ILogger<SiteDataService> _logger;
        private readonly CategoryRepository _categoryRepository;
        private readonly ServicesRepository _servicesRepository;
        private readonly ArticlesRepository _articlesRepository;
        private readonly PartnerRepository _partnerRepository;
        private readonly SubCategoryRepository _subCategoryRepository;

        public SiteDataService(ILogger<SiteDataService> logger, IConfiguration configuration,
            CategoryRepository categoryRepository, ServicesRepository servicesRepository, ArticlesRepository articlesRepository, PartnerRepository partnerRepository, SubCategoryRepository subCategoryRepository)
        {
            _logger = logger;
            _configuration = configuration;
            _categoryRepository = categoryRepository;
            _servicesRepository = servicesRepository;
            _articlesRepository = articlesRepository;
            _partnerRepository = partnerRepository;
            _subCategoryRepository = subCategoryRepository;
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
        public List<Partner> GetPartnerLogos()
        {
            var data = _partnerRepository.ListAll().OrderBy(x => Guid.NewGuid()).ToList();
            return data;
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
    }
}
