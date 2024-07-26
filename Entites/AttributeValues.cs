using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Entites
{
    public class AttributeValues
    {
        public int Id { get; set; }

        public int attributeId { get; set; }

        public Attributes attribute { get; set; }

        public string attributeValue { get; set; }

        public string color { get; set; }
    }
}
