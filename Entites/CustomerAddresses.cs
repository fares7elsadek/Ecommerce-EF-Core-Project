using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Entites
{
    public class CustomerAddresses
    {
        public int Id { get; set; }

        public int customerId { get; set; }
        public Customers customer { get; set; }

        public string addressLine1 { get; set; }

        public string addressLine2 { get; set;}

        public string postalCode { get; set; }

        public string country { get; set; }

        public string city { get; set; }

        public string phoneNumber { get; set; }
    }
}
