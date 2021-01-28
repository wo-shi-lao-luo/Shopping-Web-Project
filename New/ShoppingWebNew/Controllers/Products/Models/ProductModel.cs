using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingWebNew.Controllers.Products.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

        public string Title { get; set; }

        public string Image { get; set; }

        public string URL { get; set; }

        public string Description { get; set; }

    }
}
