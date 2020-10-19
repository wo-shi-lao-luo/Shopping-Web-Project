using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using ASP.net_version.Models;

using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shopping_Web.DbContexts;
using Shopping_Web.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

namespace Shopping_Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        public ProductModel Product = new ProductModel();
        public ShoppingContext _context;



        public ProductController(ILogger<ProductController> logger, ShoppingContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("api/products")]
        [EnableCors("MyPolicy")]
        public async Task<ActionResult<IEnumerable<ProductModel>>> GetProducts()
        {
            var Products = from product in _context.Products
                           select product;

            return await Products.ToListAsync();
        }

        [HttpGet("api/products/{id}")]
        [EnableCors("MyPolicy")]
        public async Task<ActionResult<ProductModel>> GetTodoItem(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        //[Authorize]
        [HttpPost("api/products/add")]
        [EnableCors("MyPolicy")]
        public async Task<ActionResult<ProductModel>> CreateTodoItem(ProductModel productToAdd)
        {
            _context.Products.Add(productToAdd);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetTodoItem),
                new { name = productToAdd.Name },
                productToAdd);
        }

        private bool ProductExists(int id) => _context.Products.Any(e => e.Id == id);

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
