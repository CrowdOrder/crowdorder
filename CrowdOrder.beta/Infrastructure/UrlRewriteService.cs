using CrowdOrder.beta.Data;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CrowdOrder.beta.Infrastructure
{
    public static class UrlRewriteService
    {
        public static RewriteOptions GetOptions(ApplicationDbContext context)
        {
            var data = new RewriteOptions();
            foreach (var rule in GetAll(context))
            {
                data.AddRewrite(rule.Requested, rule.Target, true);
            }
            return data;
        }
        private static List<UrlRewrite> GetAll(ApplicationDbContext context)
        {
            var result = new List<UrlRewrite>();

            var partners = context.Partners.ToList();
            foreach(var p in partners)
            {
                var url = $"^(?i){@p.Url}";
                result.Add(new UrlRewrite() 
                { 
                    Requested = @url,
                    Target = $"/Partners/Details/{p.Id}"
                });
            }

            var subs = context.SubCategorys.ToList();
            foreach(var s in subs)
            {
                result.Add(new UrlRewrite()
                {
                    Requested = s.Url,
                    Target = $"/Subcategorys/Details/{s.Id}"
                });
            }

            var categorys = context.Categorys.ToList();
            foreach (var c in categorys)
            {
                result.Add(new UrlRewrite()
                {
                    Requested = c.Url,
                    Target = $"/Categorys/Details/{c.Id}"
                });
            }

            //services page
            result.Add(new UrlRewrite()
            {
                Requested = @"^(?i)small-business-start-up-services",
                Target = "services"
            });
            
            //about us page
            result.Add(new UrlRewrite()
            {
                Requested = @"^(?i)about-us",
                Target = "home/about"
            });

            //blogs page
            //result.Add(new UrlRewrite()
            //{
            //    Requested = @"^(?i)small-business-start-up-blogs-guides",
            //    Target = "home/blogs"
            //});
            result.Add(new UrlRewrite()
            {
                Requested = @"^(?i)small-business-start-up-blogs-guides/(.*)",
                Target = "blog/Details/$1"
            });
            result.Add(new UrlRewrite()
            {
                Requested = @"^(?i)small-business-start-up-blogs-guides",
                Target = "blog/"
            });

            return result;
        }

        public static string FixUrl(string root, string input)
        {
            return $"https://{root}/{input}";
        }
        public static string AffiliatesUrl(string root, string input)
        {
            return $"https://{root}?w={input}";
        }
    }
}
