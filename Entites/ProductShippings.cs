using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Entites
{
    public class ProductShippings
    {
        public int ProductId { get; set; }

        public Products product { get; set; }

        public int ShippingId { get; set; }

        public Shippings shipping { get; set; }

        public decimal shipCharge { get; set; }

        public bool free {  get; set; }

        public int estimatedDays { get; set; }
    }
}
