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
    internal class RoleConfigurations : IEntityTypeConfiguration<Roles>
    {
        public void Configure(EntityTypeBuilder<Roles> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable(nameof(Roles));

            builder.Property(x => x.roleName).
                HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired(true);

            builder.Property(x => x.privileges).
                HasColumnType("varchar(max)")
                .IsRequired(true);

            builder.Property(x => x.CreatedAt)
                .HasColumnType("date")
                .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.UpdatedAt)
                .HasColumnType("date");
               

        }
    }
}
