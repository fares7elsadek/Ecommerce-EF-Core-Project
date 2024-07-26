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
    internal class AttributeValueConfigurations : IEntityTypeConfiguration<AttributeValues>
    {
        public void Configure(EntityTypeBuilder<AttributeValues> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable(nameof(AttributeValues));

            builder.Property(x => x.attributeValue)
                .HasColumnType("varchar")
                .HasMaxLength(255);

            builder.Property(x => x.color)
                .HasColumnType("varchar")
                .HasMaxLength(50);
        }
    }
}
