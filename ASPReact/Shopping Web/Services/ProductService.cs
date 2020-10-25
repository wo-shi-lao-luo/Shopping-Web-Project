//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Shopping_Web.DbContexts;
//using Shopping_Web.Models.ProductModel;

//namespace Shopping_Web.Services
//{
//    public class ProductService
//    {
//        private readonly ShoppingContext _db;
//        public ProductModel Products = new ProductModel();
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
//                .Select(product => new ProductModel())
//                .ToListAsync();
//        }

//        public ProductModel GetProductById(int id)
//        {
//            var product = new ProductModel();
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

//        private bool ProductExists(long id)
//        {
//            return _db.Products.Any(e => e.Id == id);
//        }

//        //private static ProductModel ProductDTO(ProductModel product)
//        //{
//        //    return new ProductModel
//        //    {
//        //        Id = product.Id,
//        //        Name = product.Name,
//        //        Price = product.Price,
//        //        Title = product.Title,
//        //        Image = product.Image,
//        //        Url = product.Url,
//        //        Description = product.Description
//        //    };
//        //}
//    }
//}