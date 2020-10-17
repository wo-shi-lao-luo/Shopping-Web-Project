using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ASP.net_version.Models;
using ASP.net_version.Services;
<<<<<<< HEAD
<<<<<<< HEAD
using Microsoft.AspNetCore.Cors;
=======
>>>>>>> parent of da49594b... Merge pull request #13 from wo-shi-lao-luo/kyle-branch
=======
>>>>>>> parent of da49594b... Merge pull request #13 from wo-shi-lao-luo/kyle-branch
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shopping_Web.Services;

namespace Shopping_Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        public ProductService ProductService;
        public List<Product> Products { get; set; }



        public ProductController(ILogger<ProductController> logger, ProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        [HttpGet("api/products")]
<<<<<<< HEAD
<<<<<<< HEAD
        [EnableCors("MyPolicy")]
=======
>>>>>>> parent of da49594b... Merge pull request #13 from wo-shi-lao-luo/kyle-branch
=======
>>>>>>> parent of da49594b... Merge pull request #13 from wo-shi-lao-luo/kyle-branch
        public List<Product> GetProducts()
        {
            Products = ProductService.GetProducts();
            return Products;
        }


        [HttpGet("api/products/{id}")]
<<<<<<< HEAD
<<<<<<< HEAD
        [EnableCors("MyPolicy")]
=======
>>>>>>> parent of da49594b... Merge pull request #13 from wo-shi-lao-luo/kyle-branch
=======
>>>>>>> parent of da49594b... Merge pull request #13 from wo-shi-lao-luo/kyle-branch
        public Product GetProductById(int id)
        {
            var product = ProductService.GetProductById(id);
            return product;
        }
    }
}
