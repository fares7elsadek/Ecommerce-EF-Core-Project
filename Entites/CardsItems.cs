using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Entites
{
    public class CardsItems
    {
        public int Id { get; set; }

        public int CardId { get; set; }
        public Cards card { get; set; }

        public int productId { get; set; }
        public Products product { get; set; }

        public int quantity { get; set; }

    }
}
