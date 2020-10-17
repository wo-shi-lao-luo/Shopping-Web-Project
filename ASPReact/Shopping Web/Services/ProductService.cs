//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Metadata.Ecma335;
//using System.Threading.Tasks;
//using ASP.net_version.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Shopping_Web.DbContexts;

//namespace Shopping_Web.Services
//{
//    public class ProductService
//    {
//        ShoppingContext _db;

//        public ProductService(ShoppingContext db)
//        {
//            _db = db;
//        }

//        public async Task<ActionResult<IEnumerable<ProductModel>>> GetProducts()
//        {
//            //List<ProductModel> Products = new List<ProductModel>();
//            //Products = _db.Products.ToList();

//            //return Products;
//            return await _db.Products
//                .Select(x => ProductDTO(x))
//                .ToListAsync();
//        }

//        public ProductModel GetProductById(int id)
//        {
//            ProductModel product = new ProductModel();
//            try
//            {
//                product = _db.Products.Single(p => p.Id == id);
//            }
//            catch (Exception e)
//            {
//                product = null;
//            }
//            return product;
//        }

//        private bool ProductExists(long id) =>_db.Products.Any(e => e.Id == id);

//        private static ProductModel ProductDTO (ProductModel product) =>
//            new ProductModel
//            {
//                Id = product.Id,
//                Name = product.Name,
//                Price = product.Price,
//                Title = product.Title,
//                Image = product.Image,
//                URL = product.URL,
//                Description = product.Description
//            };
//    }
//}
