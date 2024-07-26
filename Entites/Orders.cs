using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Entites
{
    public class Orders
    {
        public int Id { get; set; }

        public int couponId { get; set; }

        public Coupons coupon { get; set; }

        public int customerId { get; set; }

        public Customers customer { get; set; }

        public DateTime orderApprovedAt { get; set; }

        public DateTime orderDeliveredCarrierDate { get; set;}

        public DateTime orderDeliveredCustomerDate { get; set; }

        public DateTime CreatedAt { get; set; }

        public int OrderStatusId { get; set; }
        public OrderStatuses OrderStatus { get; set; }

        public List<Products> products { get; set; } = new List<Products>();
        public List<OrderItems> orderItems { get; set; } = new List<OrderItems>();

    }
}
