using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Entites
{
    public class Notifications
    {
        public int Id { get; set; } 
        public int accountId { get; set; }
        public StaffAccounts Account { get; set; }

        public string title { get; set; }

        public string content { get; set; }

        public bool seen { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime RecieveTime { get; set; }

        public DateTime notificationExpireDate { get; set;}
    }
}
