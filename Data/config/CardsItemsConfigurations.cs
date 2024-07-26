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
    internal class CardsItemsConfigurations : IEntityTypeConfiguration<CardsItems>
    {
        public void Configure(EntityTypeBuilder<CardsItems> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable(nameof(CardsItems));

            builder.Property(x => x.quantity)
                .HasColumnType("smallint")
                .IsRequired();

            builder.ToTable(t => t.HasCheckConstraint("CK_Quantity_NoNegative", "[quantity]>=0"));
        }
    }
}
