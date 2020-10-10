using CrowdOrder.beta.Data;
using CrowdOrder.beta.Models;
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
        private readonly ILogger<SiteDataService> _logger;
        private readonly CategoryRepository _categoryRepository;
        private readonly ServicesRepository _servicesRepository;
        private readonly ArticlesRepository _articlesRepository;
        private readonly PartnerRepository _partnerRepository;

        public SiteDataService(ILogger<SiteDataService> logger, 
            CategoryRepository categoryRepository, ServicesRepository servicesRepository, ArticlesRepository articlesRepository, PartnerRepository partnerRepository)
        {
            _logger = logger;
            _categoryRepository = categoryRepository;
            _servicesRepository = servicesRepository;
            _articlesRepository = articlesRepository;
            this._partnerRepository = partnerRepository;
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
            var data = _partnerRepository.ListAll();
            return data;
        }
    }
}
