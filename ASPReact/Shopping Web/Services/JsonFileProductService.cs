//using System.Collections.Generic;
//using System.IO;
//using System.Text.Json;
//using Microsoft.AspNetCore.Hosting;
//using Shopping_Web.Models.ProductModel;

//namespace ASP.net_version.Services
//{
//    public class JsonFileProductService
//    {
//        public JsonFileProductService(IWebHostEnvironment webHostEnvironment)
//        {
//            WebHostEnvironment = webHostEnvironment;
//        }

//        public IWebHostEnvironment WebHostEnvironment { get; }

//        private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "data.json");

//        public IEnumerable<ProductModel> GetProducts()
//        {
//            using (var jsonFileReader = File.OpenText(JsonFileName))
//            {
//                return JsonSerializer.Deserialize<ProductModel[]>(jsonFileReader.ReadToEnd(),
//                    new JsonSerializerOptions
//                    {
//                        PropertyNameCaseInsensitive = true
//                    });
//            }
//        }
//    }
//}