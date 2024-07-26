using EcommerceProject.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Data.config
{
    internal class StaffRolesConfigurations : IEntityTypeConfiguration<StaffRoles>
    {
        public void Configure(EntityTypeBuilder<StaffRoles> builder)
        {
            builder.HasKey(x => new { x.RoleId, x.StaffId });
            builder.ToTable(nameof(StaffRoles));
        }
    }
}
