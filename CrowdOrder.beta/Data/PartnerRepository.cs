using CrowdOrder.beta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Data
{
    public class PartnerRepository
    {
        private readonly ILogger<PartnerRepository> _logger;
        private readonly ApplicationDbContext _context;

        public PartnerRepository(ILogger<PartnerRepository> logger, ApplicationDbContext context)
        {
            _logger = logger;
            this._context = context;
        }

        internal List<Partner> ListAll()
        {
            var data = _context.Partners.ToList();
            return data;
        }

        internal Partner FindById(int id)
        {
            var data = _context.Partners.Include(x => x.Services).Where(x => x.Id == id).FirstOrDefault();
            return data;
        }

        internal bool Upsert(ref Partner model)
        {
            //TODO - finish saving partner details
            if (model.Id != null)
            {
                var partner = FindById((int)model.Id);
                partner.MainContact = model.MainContact;
                partner.Name = model.Name;
                partner.Body = model.Body;
                partner.Url = model.Url;
                partner.MainContactEmail = model.MainContactEmail;
                partner.MainContactTel = model.MainContactTel;
                partner.Notes = model.Notes;
                partner.DiscountPricing = model.DiscountPricing;
                partner.About = model.About;
                partner.DefaultPartnerSignupType = model.DefaultPartnerSignupType;
                _context.Partners.Update(partner);
                _context.SaveChanges();
                return true;
            }
            else
            {
                _context.Partners.Add(model);
                _context.SaveChanges();
                return true;
            }
        }

        internal void SetActive(int id)
        {
            var partner = FindById(id);
            partner.InActive = false;
            Upsert(ref partner);
        }
    }
}
