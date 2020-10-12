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
        //public DbProductService(IWebHostEnvironment webHostEnvironment)
        //{
        //    WebHostEnvironment = webHostEnvironment;
        //}

        //public IWebHostEnvironment WebHostEnvironment { get; }


        //public IEnumerable<Product> GetProducts()
        //{
        //    using (var db = new ShoppingContext())
        //    {
        //        var values = db.Products
        //            .OrderBy(b => b.Id);
        //        Console.WriteLine(values);
        //        return values;
        //    }
        //}

        List<Product> Products = new List<Product>();
        public List<Product> GetProducts()
        {
            ShoppingContext db = new ShoppingContext();
            var query = from product in db.Products select product;
            Products = query.ToList();

            return Products;
        }


    //    private string JsonFileName
    //    {
    //        get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "data.json"); }
    //    }

    //    public IEnumerable<Product> GetProducts()
    //    {
    //        using (var jsonFileReader = File.OpenText(JsonFileName))
    //        {

    //            return JsonSerializer.Deserialize<Product[]>(jsonFileReader.ReadToEnd(),
    //                new JsonSerializerOptions
    //                {
    //                    PropertyNameCaseInsensitive = true
    //                });
    //        }
    //    }
    }
}
