using Webshop.Db.Models;
using Webshop.Db;

namespace OnlineShop.Db
{
    public class ProductsDbRepository : IProductRepository
    {
        private readonly DatabaseContext _databaseContext;
        public ProductsDbRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public Product GetProduct(Guid id)
        {
            foreach (Product p in _databaseContext.Products.ToList())
            {
                if (p.Id == id) return p;
            }
            return null;
        }
        public List<Product> GetProducts()
        {
            return _databaseContext.Products.ToList();
        }

        public void ChangeProduct(Guid id, string newName, decimal newCost, string newDescription)
        {
            foreach (Product p in _databaseContext.Products.ToList())
            {
                if (p.Id == id)
                {
                    p.Name = newName;
                    p.Cost = newCost;
                    p.Description = newDescription;
                }
            }
            _databaseContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            Product product = GetProduct(id);
            _databaseContext.Products.Remove(product);
            _databaseContext.SaveChanges();
        }

        public void Add(Product newProduct)
        {
            _databaseContext.Products.Add(newProduct);
            _databaseContext.SaveChanges();
        }

        public List<Product> SearchProduct(string searchInfo)
        {
            return _databaseContext.Products.ToList().Where(pr => pr.Name.ToLower().Contains(searchInfo.ToLower())).ToList();
        }
    }

    public interface IProductRepository
    {
        public Product GetProduct(Guid id);
        public List<Product> GetProducts();
        public void ChangeProduct(Guid id, string newName, decimal newCost, string newDescription);
        public void Delete(Guid id);
        public void Add(Product newProduct);
        public List<Product> SearchProduct(string searchInfo);

    }
}