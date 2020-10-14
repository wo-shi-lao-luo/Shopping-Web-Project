using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using ASP.net_version.Models;
using Shopping_Web.DbContexts;

namespace Shopping_Web.Services
{
    public class ProductService
    {
        ShoppingContext db = new ShoppingContext();

        public List<Product> GetProducts()
        {
            List<Product> Products = new List<Product>();
            //var query = from product in db.Products select product;
            Products = db.Products.ToList();

            return Products;
        }

        public Product GetProductById(int id)
        {
            Product product = new Product();
            try
            {
                product = db.Products.Single(p => p.Id == id);
            }
            catch (Exception e)
            {
                product = null;
            }
            return product;
        }
    }
}
