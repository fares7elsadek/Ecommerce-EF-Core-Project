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
    internal class ProductConfigurations : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Products");

            builder.Property(x => x.productName).
                HasColumnType("varchar")
                .HasMaxLength(50).IsRequired();

            builder.Property(x => x.regularPrice).
                HasColumnType("decimal")
                .HasPrecision(18, 2).IsRequired();

            builder.ToTable(t => t.HasCheckConstraint("CK_regularPrice_NoNegative", "[regularPrice]>=0"));

            builder.Property(x => x.discountPrice).
                HasColumnType("decimal")
                .HasPrecision(18, 2).IsRequired();

            builder.ToTable(t => t.HasCheckConstraint("CK_discountPrice_NoNegative", "[discountPrice]>=0"));

            builder.Property(x => x.quantity).
                HasColumnType("int")
                .HasDefaultValue(0)
                .IsRequired();
     

            builder.ToTable(t => t.HasCheckConstraint("CK_Quantity2_NoNegative", "[quantity]>=0"));

            builder.Property(x => x.shortDescription).
                HasColumnType("varchar")
                .HasMaxLength(200).IsRequired();

            builder.Property(x => x.productWeight).
                HasColumnType("int")
                .IsRequired();


            builder.Property(x => x.productNote).
                HasColumnType("varchar")
                .HasMaxLength(200).IsRequired();

            builder.Property(x => x.published).
               HasColumnType("bit").
               HasDefaultValue(false)
               .IsRequired();

            builder.Property(x => x.CreatedAt)
                .HasColumnType("date")
                .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.UpdatedAt)
                .HasColumnType("date");

            builder.HasMany(x => x.Galleries)
                .WithOne(x => x.product)
                .HasForeignKey(x => x.productId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.CardsItems)
                .WithOne(x => x.product)
                .HasForeignKey(x => x.productId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.ProductShippings)
                .WithOne(x => x.product)
                .HasForeignKey(x => x.ProductId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);


            builder.HasMany(x => x.Coupons)
                .WithMany(x => x.Products)
                .UsingEntity<ProductCoupons>();

            builder.HasMany(x => x.Orders)
                .WithMany(x => x.products)
                .UsingEntity<OrderItems>();

            builder.HasMany(x => x.attributes)
                .WithMany(x => x.Products)
                .UsingEntity<productAttributes>();

            builder.HasMany(x => x.tags)
                .WithMany(x => x.Products)
                .UsingEntity<ProductTags>();
        }
    }
}
