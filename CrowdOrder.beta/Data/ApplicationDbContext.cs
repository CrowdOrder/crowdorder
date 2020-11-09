using System;
using System.Collections.Generic;
using System.Text;
using CrowdOrder.beta.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CrowdOrder.beta.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<SubCategory> SubCategorys { get; set; }

        public DbSet<Service> Service { get; set; }
        public DbSet<PartnerConnection> PartnerConnections {get;set;}

        public DbSet<Article> Articles { get; set; }
        public DbSet<Affiliate> Affiliates { get; set; }
        public DbSet<SignUp> Signups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
