﻿using EcommerceProject.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Data.config
{
    internal class StaffAccountConfigurations : IEntityTypeConfiguration<StaffAccounts>
    {
        public void Configure(EntityTypeBuilder<StaffAccounts> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable(nameof(StaffAccounts));

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

            builder.Property(x => x.profileImage)
                .HasColumnType("varchar(max)");

            builder.HasMany(x => x.Roles)
                .WithMany(x => x.StaffAccounts)
                .UsingEntity<StaffRoles>();

            builder.HasMany(x => x.Notifications)
                .WithOne(x => x.Account);
        }
    }
}
