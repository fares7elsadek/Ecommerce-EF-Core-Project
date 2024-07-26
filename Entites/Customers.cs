using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Entites
{
    public class Customers
    {
        public int Id { get; set; }
        public string firstName { get; set; } = null!;

        public string lastName { get; set; } = null!;

        public string phoneNumber { get; set; } = null!;
        public string email { get; set; } = null!;

        public string passwordHashed { get; set; } = null!;

        public bool active { get; set; }

        public DateTime RegisteredAt { get; set; }

        public DateTime CreatedAt { get; set; }

        public List<Cards> Cards { get; set; } = new List<Cards>();
    }
}
