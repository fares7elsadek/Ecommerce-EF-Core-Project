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
    internal class CouponConfigurations : IEntityTypeConfiguration<Coupons>
    {
        public void Configure(EntityTypeBuilder<Coupons> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable(nameof(Coupons));

            builder.Property(x => x.code)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.couponDescription)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired(false);

            builder.Property(x => x.discountValue)
                .HasColumnType("decimal")
                .HasPrecision(18, 2)
                .IsRequired(true);

            builder.Property(x => x.discountType)
                .HasColumnType("varchar")
                .HasMaxLength(55)
                .IsRequired(true);

            builder.Property(x => x.timesUsed)
                .HasColumnType("int");


            builder.Property(x => x.maxUsage)
                .HasColumnType("int")
                .IsRequired(true);

            builder.Property(x => x.couponStartDate)
                .HasColumnType("date")
                .IsRequired(true);

            builder.Property(x => x.couponEndDate)
                .HasColumnType("date")
                .IsRequired(true);

            builder.Property(x => x.CreatedAt)
                .HasColumnType("date")
                .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.UpdatedAt)
                .HasColumnType("date");
                
            builder.HasMany(x => x.orders)
                .WithOne(x => x.coupon)
                .HasForeignKey(x => x.couponId)
                .IsRequired(false);
        }
    }
}
