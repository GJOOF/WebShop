using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using System.Diagnostics;
using Webshop.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Webshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;
        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Catalog()
        {
            var products = _productRepository.GetProducts();
            var productsView = new List<ProductViewModel>();
            foreach (var product in products)
            {
                var productView = new ProductViewModel
                {
                    Id = product.Id,
                    Name = product.Name,
                    Cost = product.Cost,
                    Description = product.Description,
                    ImagePath = product.ImagePath
                };
                productsView.Add(productView);
            }
            return View(productsView);
        }
        public IActionResult Product()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}