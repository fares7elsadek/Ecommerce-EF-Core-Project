using EcommerceProject.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Data.config
{
    internal class OrderConfigurations : IEntityTypeConfiguration<Orders>
    {
        public void Configure(EntityTypeBuilder<Orders> builder)
        {
            builder.HasKey(x  => x.Id);
            builder.ToTable(nameof(Orders));

            builder.Property(x => x.orderApprovedAt)
                 .HasColumnType("date");

            builder.Property(x => x.orderDeliveredCarrierDate)
                 .HasColumnType("date");

            builder.Property(x => x.orderDeliveredCustomerDate)
                 .HasColumnType("date");

            builder.Property(x => x.CreatedAt)
                 .HasColumnType("date")
                 .HasDefaultValueSql("GETDATE()");

            builder.HasOne(x => x.OrderStatus)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.OrderStatusId);
                
        }
    }
}
