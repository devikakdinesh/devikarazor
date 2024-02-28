using Microsoft.AspNetCore.Mvc;

namespace WebApp.Model
{
    public enum ProductStatus
    {
        instock,
        outstock,
        notavailable
    }
    
    public class Product
    {
        [BindProperty]
        public Product products { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int stock { get; set; }
        public string url { get; set; }
        public ProductStatus status { get; set; }
    }
}
