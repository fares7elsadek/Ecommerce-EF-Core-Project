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
    internal class ProductAttributeConfigurations : IEntityTypeConfiguration<productAttributes>
    {
        public void Configure(EntityTypeBuilder<productAttributes> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.AttributeId });
            builder.ToTable(nameof(productAttributes));
        }
    }
}
