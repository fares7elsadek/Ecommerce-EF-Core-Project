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
    internal class CustomerConfiguraions : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable(nameof(Customers));

            builder.Property(x => x.firstName).
                HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.lastName).
                HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.phoneNumber).
                HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.email).
                HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            builder.HasIndex(x => x.email)
                .IsUnique();

            builder.Property(x => x.passwordHashed).
                HasColumnType("varchar")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(x => x.active).
               HasColumnType("bit")
               .HasDefaultValue(false);

            builder.Property(x => x.RegisteredAt).
               HasColumnType("date")
               .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.CreatedAt).
               HasColumnType("date")
               .HasDefaultValueSql("GETDATE()");

            builder.HasMany(x =>x.Cards)
                .WithOne(x => x.customer)
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
