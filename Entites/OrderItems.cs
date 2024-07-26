using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Entites
{
    public class OrderItems
    {
        public int Id { get; set; } 

        public int productId { get; set; }
        public Products product { get; set; }

        public int orderId { get; set; }

        public Orders order { get; set; }

        public decimal price { get; set; }

        public int quantity { get; set; }

        public int shippingId { get; set; }

        public Shippings shipping { get; set; }

    }
}
