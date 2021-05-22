using Microsoft.AspNetCore.Builder;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdOrder.beta.Infrastructure
{
    public static class AffiliateMiddlewareExtensions
    {
        public static IApplicationBuilder UseAffiliateMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AffiliateMiddleware>();
        }
    }
}
