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
    internal class AttributeConfigurations : IEntityTypeConfiguration<Attributes>
    {
        public void Configure(EntityTypeBuilder<Attributes> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable(nameof(Attributes));

            builder.Property(x => x.attributeName)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired(true);

            builder.Property(x => x.CreatedAt)
                .HasColumnType("date")
                .HasDefaultValueSql("GETDATE()");


            builder.Property(x => x.UpdatedAt)
                .HasColumnType("date");

            builder.HasMany(x => x.attributeValues)
                .WithOne(x => x.attribute)
                .HasForeignKey(x => x.attributeId);
                

        }
    }
}
