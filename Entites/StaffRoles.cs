using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Entites
{
    public class StaffRoles
    {
        public int StaffId { get; set; }
        public StaffAccounts Account { get; set; }

        public int RoleId { get; set; }

        public Roles Role { get; set; }
    }
}
