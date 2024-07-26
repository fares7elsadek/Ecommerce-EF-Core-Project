using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Entites
{
    public class ProductTags
    {
        public int TagId { get; set; }

        public int ProductId { get; set; }

        public Products product { get; set; }

        public Tags tag { get; set; }
    }
}
