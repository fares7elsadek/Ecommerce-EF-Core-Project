using EcommerceProject.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Data.config
{
    internal class OrderStatusConfigurations : IEntityTypeConfiguration<OrderStatuses>
    {
        public void Configure(EntityTypeBuilder<OrderStatuses> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("OrderStatuses");

            builder.Property(x => x.statusName)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired(true);

            builder.Property(x => x.color)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired(true);

            builder.Property(x => x.privacy)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired(true);

            builder.Property(x => x.CreatedAt)
                .HasColumnType("date")
                .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.UpdatedAt)
                .HasColumnType("date");
                

        }
    }
}
