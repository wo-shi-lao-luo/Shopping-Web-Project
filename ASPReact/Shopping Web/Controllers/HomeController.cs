using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.net_version.Models;
using ASP.net_version.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Shopping_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; private set; }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //[HttpGet("api/getProducts")]
        //public IActionResult GetProducts()
        //{
        //    ViewData["products"] = Products;
        //    return View();
        //}

        public HomeController(ILogger<HomeController> logger, JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }
        [HttpGet("api/products")]
        public IEnumerable<Product> GetProducts()
        {
            Products = ProductService.GetProducts();
            return Products;
        }
        //[HttpGet("api/getProducts")]
        //public List<Product> Get()
        //{
        //    Products = ProductService.GetProducts();
        //    return Products.ToList();
        //}
    }
}
