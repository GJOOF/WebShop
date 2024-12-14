using Microsoft.AspNetCore.Mvc;

namespace Webshop.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IProductRepository productRepository;
        public CatalogController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Index(int id)
        {
            var product = productRepository.TryGetById(id);
            return View(product);
        }
    }
}
