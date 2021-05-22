using CrowdOrder.beta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Data
{
    public class SignUpRepository
    {
        private readonly ILogger<SignUpRepository> _logger;
        private readonly ApplicationDbContext _context;

        public SignUpRepository(ILogger<SignUpRepository> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        internal List<SignUp> ListAll()
        {
            var data = _context.Signups.Include(x => x.Affiliate).Include(x => x.User).ToList();
            return data;
        }
        internal bool Upsert(ref SignUp model)
        {
            var id = model.Id;
            var signup = _context.Signups.Where(x => x.Id == id).FirstOrDefault();

            if (signup != null)
            {
                _context.Signups.Update(signup);
                _context.SaveChanges();
                return false;
            }
            else
            {
                _context.Signups.Add(model);
                _context.SaveChanges();
                return true;
            }
        }
    }
}
