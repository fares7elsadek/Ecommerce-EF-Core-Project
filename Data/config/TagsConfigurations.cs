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
    internal class TagsConfigurations : IEntityTypeConfiguration<Tags>
    {
        public void Configure(EntityTypeBuilder<Tags> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable(nameof(Tags));

            builder.Property(x => x.tagName)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired(true);

            builder.Property(x => x.Icon)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired(true);

            builder.Property(x => x.CreatedAt)
            .HasColumnType("date")
            .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.UpdatedAt)
            .HasColumnType("date");
            
        }
    }
}
