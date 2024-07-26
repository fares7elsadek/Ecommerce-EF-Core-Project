using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Entites
{
    public  class productAttributes
    {
        public int ProductId { get; set; }
        public int AttributeId { get; set; }

        public Products Product { get; set; }

        public Attributes attribute { get; set; }
    }
}
