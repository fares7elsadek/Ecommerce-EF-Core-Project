using EcommerceProject.Entites;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Data.config
{
    internal class ShippingConfigurations : IEntityTypeConfiguration<Shippings>
    {
        public void Configure(EntityTypeBuilder<Shippings> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Shippings");

            builder.Property(x =>x.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.active)
                .HasColumnType("bit")
                .HasDefaultValue(false);

            builder.Property(x => x.iconPath)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired(false);

            builder.Property(x => x.CreatedAt)
                .HasColumnType("date")
                .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.UpdatedAt)
                .HasColumnType("date");


            builder.HasMany(x=>x.ProductShippings)
                .WithOne(x=>x.shipping)
                .HasForeignKey(x=>x.ShippingId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.orderItems)
                .WithOne(x => x.shipping)
                .HasForeignKey(x => x.shippingId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
