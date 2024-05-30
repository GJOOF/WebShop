using Webshop.Models;

namespace Webshop
{
    public class ProductsInMemoryRepository : IProductRepository
    {
        private List<Product> products = new List<Product>()
        {
            new Product(),

            new Product(),

            new Product()
        };
        public void Add(Product product)
        {
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