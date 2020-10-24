namespace Shopping_Web.Models.ProductModel
{
    public class ProductModel
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
        public string Url { get; set; }

        //[JsonPropertyName("productDescription")]
        public string Description { get; set; }
    }
}