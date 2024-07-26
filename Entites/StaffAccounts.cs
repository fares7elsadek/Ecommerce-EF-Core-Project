using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Entites
{
    public class StaffAccounts
    {
        public int Id { get; set; }
        public string firstName { get; set; } = null!;

        public string lastName { get; set; } = null!;

        public string phoneNumber { get; set; } = null!;
        public string email { get; set; } = null!;

        public string passwordHashed { get; set; } = null!;

        public bool active { get; set; }

        public string profileImage { get; set; } = null!;

        public DateTime RegisteredAt { get; set; }

        public DateTime CreatedAt { get; set; }

        public List<Roles> Roles { get; set; } = new List<Roles>();
        public List<StaffRoles> StaffRoles { get; set; } = new List<StaffRoles>();

        public List<Notifications> Notifications { get; set; } = new List<Notifications>();

    }
}
