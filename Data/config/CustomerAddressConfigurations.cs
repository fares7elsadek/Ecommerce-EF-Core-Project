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
    internal class CustomerAddressConfigurations : IEntityTypeConfiguration<CustomerAddresses>
    {
        public void Configure(EntityTypeBuilder<CustomerAddresses> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable(nameof(CustomerAddresses));

            builder.Property(x => x.addressLine1)
                .HasColumnType("varchar(max)");
                

            builder.Property(x => x.addressLine2)
                .HasColumnType("varchar(max)");
                

            builder.Property(x => x.postalCode)
                .HasColumnType("varchar")
                .HasMaxLength(255);


            builder.Property(x => x.country)
                .HasColumnType("varchar")
                .HasMaxLength(255);

            builder.Property(x => x.city)
                .HasColumnType("varchar")
                .HasMaxLength(255);

            builder.Property(x => x.phoneNumber)
                .HasColumnType("varchar")
                .HasMaxLength(255);
        }
    }
}
