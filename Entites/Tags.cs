using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Entites
{
    public class Tags
    {
        public int Id { get; set; }

        public string tagName { get; set; }

        public string Icon { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public List<Products> Products { get; set; } = new List<Products>();
        public List<ProductTags> ProductTags { get; set; } = new List<ProductTags>();

    }
}
