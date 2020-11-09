using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using CrowdOrder.beta.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Caching.Memory;
using CrowdOrder.beta.Infrastructure;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.FileProviders;
using System.IO;
using System.Globalization;
using Microsoft.AspNetCore.Http;

namespace CrowdOrder.beta
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddScoped<CompanyRepository>();
            services.AddScoped<PartnerRepository>();
            services.AddScoped<CategoryRepository>();
            services.AddScoped<ServicesRepository>();
            services.AddScoped<SubCategoryRepository>();
            services.AddScoped<PartnerConnectionRepository>();
            services.AddScoped<ArticlesRepository>();
            services.AddScoped<AffiliatesRepository>();
            services.AddScoped<SignUpRepository>();
            services.AddScoped<SiteDataService>();
            services.AddScoped<PartnerConnectionsService>();
            services.AddScoped<AffiliateService>();
            services.AddSingleton<Cache>();
            services.AddTransient<IEmailSender, EmailSender>();
            services.Configure<AuthMessageSenderOptions>(Configuration);
            // To list physical files from a path provided by configuration:
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\blogs");
            var physicalProvider = new PhysicalFileProvider(filePath);

            services.AddSingleton<IFileProvider>(physicalProvider);

            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                options.Cookie.Name = ".crowdorder.session";
                options.IdleTimeout = TimeSpan.FromHours(1);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IMemoryCache cache, IWebHostEnvironment env, ApplicationDbContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseStatusCodePages();
                //The default HSTS value is 30 days.You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles(new StaticFileOptions
            {
                HttpsCompression = Microsoft.AspNetCore.Http.Features.HttpsCompressionMode.Compress,
                OnPrepareResponse = (context) =>
                {
                    var headers = context.Context.Response.GetTypedHeaders();
                    headers.CacheControl = new Microsoft.Net.Http.Headers.CacheControlHeaderValue
                    {
                        Public = true,
                        MaxAge = TimeSpan.FromDays(30)
                    };

                }
            });

            app.UseRewriter(UrlRewriteService.GetOptions(context));

            app.UseRouting();

            app.UseSession();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseAffiliateMiddleware();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(name: "blog",
                    pattern: "blog/{*article}");
                endpoints.MapRazorPages();
            });

            
        }
    }
}
