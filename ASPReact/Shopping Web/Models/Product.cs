using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ASP.net_version.Models
{
    public class Product
    {
        //[JsonPropertyName("productId")]
        public int Id { get; set; }

        //[JsonPropertyName("productName")]
        public string Name { get; set; }

        //[JsonPropertyName("productPrice")]
        public float Price { get; set; }

        //[JsonPropertyName("productTitle")]
        public string Title { get; set; }

        //[JsonPropertyName("productImage")]
        public string Image { get; set; }

        //[JsonPropertyName("productUrl")]
        public string URL { get; set; }

        //[JsonPropertyName("productDescription")]
        public string Description { get; set; }

    }
}
