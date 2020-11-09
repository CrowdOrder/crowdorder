using CrowdOrder.beta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Data
{
    public class ServicesRepository
    {
        private readonly ILogger<ServicesRepository> _logger;
        private readonly ApplicationDbContext _context;
        private readonly Cache _cache;
        public ServicesRepository(ILogger<ServicesRepository> logger, ApplicationDbContext context, Cache cache)
        {
            _logger = logger;
            this._context = context;
            _cache = cache;
        }

        internal List<Service> GetAll()
        {
            var data = _context.Service.Include(x => x.Partner).ToList();
            return data;
        }

        internal Service FindById(int id)
        {
            var data = _context.Service.Include(x => x.Partner).Where(s => s.Id == id).FirstOrDefault();
            return data;
        }

        internal SubCategory FindBySubCategoryId(int id)
        {
            var data = _context.SubCategorys.Include(x => x.Services).ThenInclude(p => p.Partner).Where(sc => sc.Id == id).FirstOrDefault();
            return data;
        }

        internal List<Service> FindByPartnerId(int id)
        {
            var data = _context.Service.Include(x => x.Partner).Where(s => s.Partner.Id == id).ToList();
            return data;
        }

        internal List<Category> MenuBuilder()
        {
            return _cache.Memoize(
                "CrowdOrder.Menu",
                () =>
                {
                    var data = _context.Categorys.ToList();
                    return data;
                },
                DateTime.UtcNow.TimeToMidnight()
                );
        }

        internal Service CreateNew(int id)
        {
            var partner = _context.Partners.Find(id);
            var service = new Service() { PartnerId = id, Partner = partner, PartnerSignupType = partner.DefaultPartnerSignupType };
            return service;
        }

        internal bool Upsert(ref Service model)
        {
            var id = model.Id;
            var service = _context.Service.Where(x => x.Id == id).FirstOrDefault();

            if (service != null)
            {
                service.Title = model.Title;
                service.PartnerSignupType = model.PartnerSignupType;
                service.DiscountOffer = model.DiscountOffer;
                service.QualifyingCriteria = model.QualifyingCriteria;
                service.ConnectUrl = model.ConnectUrl;
                service.ConnectContact = model.ConnectContact;
                service.ConnectEmail = model.ConnectEmail;
                service.SubCategoryId = model.SubCategoryId;
                _context.Service.Update(service);
                _context.SaveChanges();
                return false;
            }
            else
            {
                _context.Service.Add(model);
                _context.SaveChanges();
                return true;
            };
        }
    }
}
