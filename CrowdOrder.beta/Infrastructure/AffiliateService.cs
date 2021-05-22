using CrowdOrder.beta.Data;
using CrowdOrder.beta.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Infrastructure
{
    public class AffiliateService
    {
        private readonly ILogger<AffiliateService> _logger;
        private readonly SignUpRepository _signupRepository;
        private readonly AffiliatesRepository _affiliatesRepository;

        public AffiliateService(ILogger<AffiliateService> logger, SignUpRepository signupRepository, AffiliatesRepository affiliatesRepository)
        {
            _logger = logger;
            _signupRepository = signupRepository;
            _affiliatesRepository = affiliatesRepository;
        }
        public bool SignupWithAffiliateLink(string affiliate, IdentityUser user)
        {
            var originator = _affiliatesRepository.FindByCode(affiliate);
            if (originator != null)
            {
                var model = new SignUp() { Affiliate = originator, User = user, TimeStamp = DateTime.UtcNow };
                return _signupRepository.Upsert(ref model);
            }
            return false;
        }

    }
}
