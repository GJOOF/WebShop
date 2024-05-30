using Webshop.Models;
using System.Linq;
using System.Collections.Generic;

namespace Webshop
{
    public class ProductsInMemoryRepository : IProductRepository
    {
        private List<Product> products = new List<Product>()
        {
            new Product("Led Zeppelin I",5000,"vinyl disc","/lz1.jpg"),

            new Product("Led Zeppelin II", 5000,"vinyl disc","/lz2.jpg"),

            new Product("Led Zeppelin III", 5000,"vinyl disc","/lz3.jpg"),

            new Product("Led Zeppelin IV", 5000,"vinyl disc","/lz4.jpg"),
            new Product("Led Zeppelin V", 5000,"vinyl disc","/lz2.jpg")
        };
        public void Add(Product product)
        {
            product.ImagePath = "/lz2.jpg";
            products.Add(product);
        }

        public List<Product> GetProducts() { return products; }
        public Product TryGetById(int id)
        {
            return products.FirstOrDefault(product => product.Id == id);
        }

        public void Update(Product product)
        {
            var existingProduct = products.FirstOrDefault(x => x.Id == product.Id);
            if (existingProduct == null) return;

            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Cost = product.Cost;
        }
    }
}