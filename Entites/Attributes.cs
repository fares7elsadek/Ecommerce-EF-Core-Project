using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Entites
{
    public class Attributes
    {
        public int Id { get; set; }

        public string attributeName { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set;}

        public List<Products > Products { get; set; } = new List<Products>();
        public List<productAttributes> productAttributes { get; set; } = new List<productAttributes>();

        public List<AttributeValues> attributeValues { get; set; } = new List<AttributeValues>();
    }
}
