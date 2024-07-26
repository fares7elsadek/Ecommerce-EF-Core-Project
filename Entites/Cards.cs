using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Entites
{
    public class Cards
    {
        public int CardId { get; set; }
        public int CustomerId { get; set; }
        public Customers customer { get; set; } = null!;

        public List<CardsItems> cardsItems { get; set; } = new List<CardsItems>();
    }
}
