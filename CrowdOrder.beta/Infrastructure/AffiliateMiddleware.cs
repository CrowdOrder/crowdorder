using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Infrastructure
{
    public class AffiliateMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<AffiliateMiddleware> _logger;
        private readonly IConfiguration _configuration;
        private readonly string _affiliateKey;

        public AffiliateMiddleware(RequestDelegate next, ILogger<AffiliateMiddleware> logger, IConfiguration configuration)
        {
            _next = next;
            _logger = logger;
            _configuration = configuration;
            _affiliateKey = configuration["AffiliateKey"];
        }
        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Query.ContainsKey(_affiliateKey))
            {
                context.Session.SetString(_affiliateKey, context.Request.Query[_affiliateKey]);
            }
            
            await _next(context);
        }
    }
}
