using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Entites
{
    public class Products
    {
        public int Id { get; set; }
        public string productName { get; set; } = null!;

        public decimal regularPrice { get; set; }

        public decimal discountPrice { get; set; }

        public int quantity { get; set; }

        public string shortDescription { get; set; } = null!;

        public int productWeight { get; set; }

        public int productNote { get; set; }

        public bool published { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}

        public List<Galleries> Galleries { get; set; } = new List<Galleries>();
        public List<CardsItems> CardsItems { get; set; } = new List<CardsItems>();
    }
}
