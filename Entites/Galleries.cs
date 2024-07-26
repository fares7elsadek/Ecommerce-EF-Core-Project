using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Entites
{
    public class Galleries
    {
        public int Id { get; set; }

        public int productId { get; set; }

        public Products product { get; set; } = null!;
        public string ImagePath { get; set; } = null!;

        public bool thumbnail {  get; set; }

        public int displayOrder { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}
    }
}
