using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ASP.net_version.Models;
using Microsoft.AspNetCore.Hosting;

namespace ASP.net_version.Services
{
    public class JsonFileProductService
    {
        public JsonFileProductService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "data.json"); }
        }

        public IEnumerable<ProductModel> GetProducts()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {

                return JsonSerializer.Deserialize<ProductModel[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}

