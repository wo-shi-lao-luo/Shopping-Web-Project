using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Shopping_Web.DbContexts;
using Shopping_Web.Models.ProductModel;

namespace Shopping_Web.Controllers
{
    [Route ("api/products")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        public ShoppingContext _context;
        public ProductModel Product = new ProductModel();


        public ProductController(ILogger<ProductController> logger, ShoppingContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        [EnableCors("MyPolicy")]
        public async Task<ActionResult<IEnumerable<ProductModel>>> GetProducts()
        {
            var products = from product in _context.Products
                select product;
            return await products.ToListAsync();
        }

        [HttpGet("api/products/{id}")]
        [EnableCors("MyPolicy")]
        public async Task<ActionResult<ProductModel>> GetProductById(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null) return NotFound();

            return product;
        }

        //[Authorize]
        [HttpPost("api/products/add")]
        [EnableCors("MyPolicy")]
        public async Task<ActionResult<ProductModel>> CreateTodoItem(ProductModel productToAdd)
        {
            await _context.Products.AddAsync(productToAdd);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetProductById),
                new {Id = productToAdd.Id},
                productToAdd);
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }

        //private static ProductModel ProductDTO(ProductModel product) =>
        //    new ProductModel
        //    {
        //        Id = product.Id,
        //        Name = product.Name,
        //        Price = product.Price,
        //        Title = product.Title,
        //        Image = product.Image,
        //        URL = product.URL,
        //        Description = product.Description
        //    };
    }
}