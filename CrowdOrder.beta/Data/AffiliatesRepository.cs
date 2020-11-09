using CrowdOrder.beta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Data
{
    public class AffiliatesRepository
    {
        private readonly ILogger<AffiliatesRepository> _logger;
        private readonly ApplicationDbContext _context;

        public AffiliatesRepository(ILogger<AffiliatesRepository> logger, ApplicationDbContext context)
        {
            _logger = logger;
            this._context = context;
        }

        internal List<Affiliate> ListAll()
        {
            var data = _context.Affiliates.Include(x => x.Signups).ToList();
            return data;
        }

        internal Affiliate FindById(int id)
        {
            var data = _context.Affiliates.Include(x => x.Signups).Where(x => x.Id == id).FirstOrDefault();
            return data;
        }

        internal Affiliate FindByCode(string code)
        {
            var data = _context.Affiliates.Include(x => x.Signups).Where(x => x.Link == code).FirstOrDefault();
            return data;
        }

        internal bool Upsert(ref Affiliate model)
        {
            var id = model.Id;
            var affiliate = _context.Affiliates.Where(x => x.Id == id).FirstOrDefault();

            if (affiliate != null)
            {
                _context.Affiliates.Update(affiliate);
                _context.SaveChanges();
                return false;
            }
            else
            {
                _context.Affiliates.Add(model);
                _context.SaveChanges();
                return true;
            }
        }       
    }
}
