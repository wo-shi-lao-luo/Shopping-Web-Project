using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.net_version.Models;
using ASP.net_version.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shopping_Web.Services;

namespace Shopping_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //public JsonFileProductService ProductService;
        public DbProductService ProductService;
        //public IEnumerable<Product> Products { get; private set; }
        public List<Product> Products { get; set; }


        public HomeController(ILogger<HomeController> logger, DbProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }
        [HttpGet("api/products")]
        //public IEnumerable<Product> GetProducts()
        //{
        //    Products = ProductService.GetProducts();
        //    return Products;
        //}
        public List<Product> GetProducts()
        {
            Products = ProductService.GetProducts();
            return Products;
        }
    }
}
