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
    internal class ProductCouponConfigurations : IEntityTypeConfiguration<ProductCoupons>
    {
        public void Configure(EntityTypeBuilder<ProductCoupons> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.CuponId });
            builder.ToTable(nameof(ProductCoupons));
        }
    }
}
