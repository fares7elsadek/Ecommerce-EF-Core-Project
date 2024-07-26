using EcommerceProject.Data.config;
using EcommerceProject.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Data
{
    internal class AppDbContext:DbContext
    {
        public DbSet<Products> Products { get; set; }

        public DbSet<Galleries> Galleries { get; set; }

        public DbSet<Cards> Cards { get; set; }

        public DbSet<CardsItems> CardsItems { get; set; }

        public DbSet<Customers> Customers { get; set; }

        public DbSet<Attributes> Attributes { get; set; }

        public DbSet<AttributeValues> AttributeValues { get; set; }

        public DbSet<CustomerAddresses> CustomerAddresses { get; set; }

        public DbSet<Notifications> Notifications { get; set; }

        public DbSet<OrderItems> OrderItems { get; set; }

        public DbSet<productAttributes> ProductAttributes { get; set; }

        public DbSet<ProductCoupons> ProductCoupons { get; set; }

        public DbSet<ProductShippings> ProductShippings { get; set; }

        public DbSet<ProductTags> ProductTags { get; set; }

        public DbSet<StaffRoles> StaffRoles { get; set; }

        public DbSet<StaffAccounts> StaffAccounts { get; set; }

        public DbSet<Orders> Orders { get; set; }

        public DbSet<Shippings> Shippings { get; set; } 

        public DbSet<Tags> Tags { get; set; }

        public DbSet<Roles> Roles { get; set; }

        public DbSet<Coupons> Coupons { get; set; }

        public DbSet<OrderStatuses> OrderStatuses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfigurations).Assembly);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var constr = config.GetSection("constr").Value;
            optionsBuilder.UseSqlServer(constr);
        }
    }
}
