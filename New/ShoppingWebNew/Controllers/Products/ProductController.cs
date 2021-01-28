using Microsoft.AspNetCore.Mvc;
using ShoppingWebNew.Controllers.Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingWebNew.Controllers.Products
{
    [Route ("product")]
    public class ProductController
    {
        [HttpGet]
        [Route ("all")]
        public List<ProductModel> GetAllProduct ()
        {
            var query;

            var response;

            return response;
        }
    }
}
