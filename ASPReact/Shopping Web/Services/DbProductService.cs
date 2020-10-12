using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using ASP.net_version.Models;
using Shopping_Web.DbContexts;

namespace Shopping_Web.Services
{
    public class DbProductService
    {
        List<Product> Products = new List<Product>();
        public List<Product> GetProducts()
        {
            ShoppingContext db = new ShoppingContext();
            var query = from product in db.Products select product;
            Products = query.ToList();

            return Products;
        }
    }
}
