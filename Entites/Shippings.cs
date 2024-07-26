using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Entites
{
    public class Shippings
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public bool active { get; set; }

        public string iconPath { get; set; } = null!;

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}

        public List<ProductShippings> ProductShippings { get; set; } = new List<ProductShippings>();

        public List<OrderItems> orderItems { get; set; } = new List<OrderItems>();

    }
}
