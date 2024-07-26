using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Entites
{
    public class OrderStatuses
    {
        public int Id { get; set; }

        public string statusName { get; set; }

        public string color { get; set; }

        public string privacy { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set;}

        public List<Orders> Orders { get; set; } = new List<Orders>();
    }
}
