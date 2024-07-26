using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Entites
{
    public class Coupons
    {
        public int Id { get; set; }

        public string code { get; set; }

        public string couponDescription { get; set; }

        public decimal discountValue { get; set; }

        public string discountType { get; set; }

        public int timesUsed { get; set; }

        public int maxUsage { get; set; }

        public DateTime couponStartDate { get; set; }

        public DateTime couponEndDate { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set;}

        public List<Products> Products { get; set; } = new List<Products>();
        public List<ProductCoupons> ProductCoupons { get; set; } = new List<ProductCoupons>();

        public List<Orders> orders { get; set; } = new List<Orders>();

    }
}
