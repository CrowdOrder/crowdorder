using CrowdOrder.beta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Data
{
    public class CompanyRepository
    {
        private readonly ILogger<CompanyRepository> _logger;
        private readonly ApplicationDbContext _context;

        public CompanyRepository(ILogger<CompanyRepository> logger, ApplicationDbContext context)
        {
            _logger = logger;
            this._context = context;

        }

        internal bool Upsert(ref Company model)
        {
            if(model.Id != new Guid())
            {
                var company = _context.Companys.Find(model.Id);
                company.ContactFirstName = model.ContactFirstName;
                company.ContactLastName = model.ContactLastName;
                company.Name = model.Name;
                company.Url = model.Url;
                company.Email = model.Email;
                company.Address = model.Address;
                _context.Companys.Update(company);
                _context.SaveChanges();
                return true;
            }
            else
            {
                _context.Companys.Add(model);
                _context.SaveChanges();
                return true;
            }
        }

        internal Company FindByUserId(Guid id)
        {
            var data = _context.Companys.Where(x => x.UserId == id).FirstOrDefault();
            return data;
        }
    }
}
