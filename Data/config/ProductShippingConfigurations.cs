using EcommerceProject.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Data.config
{
    internal class ProductShippingConfigurations : IEntityTypeConfiguration<ProductShippings>
    {
        public void Configure(EntityTypeBuilder<ProductShippings> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.ShippingId });
            builder.ToTable(nameof(ProductShippings));

            builder.Property(x => x.shipCharge)
                .HasColumnType("decimal")
                .IsRequired();

            builder.ToTable(t => t.HasCheckConstraint("CK_shipCharge_NoNegative", "[shipCharge]>=0"));

            builder.Property(x => x.free)
                .HasColumnType("bit")
                .HasDefaultValue(false);

            builder.Property(x => x.estimatedDays)
                .HasColumnType("int")
                .IsRequired(true);

            builder.ToTable(t => t.HasCheckConstraint("CK_estimatedDays_NoNegative", "[estimatedDays]>=0"));
        }
    }
}
