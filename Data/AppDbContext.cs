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
