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
    public class OrderItemsConfigurations : IEntityTypeConfiguration<OrderItems>
    {
        public void Configure(EntityTypeBuilder<OrderItems> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable(nameof(OrderItems));

            builder.Property(x => x.price)
                .HasColumnType("decimal")
                .HasPrecision(18,2)
                .IsRequired(true);

            builder.ToTable(t => t.HasCheckConstraint("CK_price_NoNegative", "[price]>=0"));

            builder.Property(x => x.quantity)
                .HasColumnType("int")
                .IsRequired(true);

            builder.ToTable(t => t.HasCheckConstraint("CK_quantity1_NoNegative", "[quantity]>=0"));
        }
    }
}
