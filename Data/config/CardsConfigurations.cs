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
    internal class CardsConfigurations : IEntityTypeConfiguration<Cards>
    {
        public void Configure(EntityTypeBuilder<Cards> builder)
        {
            builder.HasKey(x => x.CardId);
            builder.ToTable(nameof(Cards));


            builder.HasMany(x => x.cardsItems)
                .WithOne(x => x.card)
                .HasForeignKey(x => x.CardId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
