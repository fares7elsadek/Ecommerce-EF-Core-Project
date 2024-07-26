using EcommerceProject.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Data.config
{
    internal class NotificationConfigurations : IEntityTypeConfiguration<Notifications>
    {
        public void Configure(EntityTypeBuilder<Notifications> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable(nameof(Notifications));

            builder.Property(x => x.title)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder.Property(x => x.content)
                .HasColumnType("varchar(max)");

            builder.Property(x => x.seen)
                .HasColumnType("bit")
                .HasDefaultValue(false);

            builder.Property(x => x.CreatedAt)
                .HasColumnType("date")
                .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.RecieveTime)
                .HasColumnType("date");
                


            builder.Property(x => x.notificationExpireDate)
                .HasColumnType("date")
                .IsRequired(true);
                

        }
    }
}
