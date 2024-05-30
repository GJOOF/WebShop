using Webshop.Models;

namespace Webshop
{
    public interface IProductRepository
    {
        void Add(Product product);
        List<Product> GetProducts();
        Product TryGetById(int id);
        void Update(Product product);
    }
}
