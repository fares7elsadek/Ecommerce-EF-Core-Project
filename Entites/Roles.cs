using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Entites
{
    public class Roles
    {
        public int Id { get; set; }

        public string roleName {  get; set; }

        public string privileges { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set;}

        public List<StaffAccounts> StaffAccounts { get; set;} = new List<StaffAccounts>();
        public List<Roles> roles { get; set; } = new List<Roles>();
    }
}
