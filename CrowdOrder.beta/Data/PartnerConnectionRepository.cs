using CrowdOrder.beta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Data
{
    public class PartnerConnectionRepository
    {
        private readonly ILogger<PartnerConnectionRepository> _logger;
        private readonly ApplicationDbContext _context;

        public PartnerConnectionRepository(ILogger<PartnerConnectionRepository> logger, ApplicationDbContext context)
        {
            _logger = logger;
            this._context = context;
        }

        internal List<PartnerConnection> ListAll()
        {
            var data = _context.PartnerConnections.ToList();
            return data;
        }

        internal PartnerConnection FindById(int id)
        {
            var data = _context.PartnerConnections.Include(x => x.Service).Where(x => x.Id == id).FirstOrDefault();
            return data;
        }

        internal bool Upsert(ref PartnerConnection model)
        {
            //TODO - finish saving partner details
            var serviceId = model.Service.Id;
            var userId = model.UserId;

            var partnerConnection = _context.PartnerConnections.Where(x => x.Service.Id == serviceId && x.UserId == userId).FirstOrDefault();

            if (partnerConnection != null)
            {       
                //TODO - at the moment we dont need to edit so return false
                //partnerConnection.Service = model.Service;
                //partnerConnection.UserId = model.UserId;
                //_context.PartnerConnections.Update(partnerConnection);
                //_context.SaveChanges();
                return false;
            }
            else
            {
                _context.PartnerConnections.Add(model);
                _context.SaveChanges();
                return true;
            }
        }

        internal List<PartnerConnection> GetByUserId(Guid userId)
        {
            var data = _context.PartnerConnections.Include(s => s.Service).Where(x => x.UserId == userId).ToList();
            return data;
        }
    }
}
