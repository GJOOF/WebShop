using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Webshop.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Webshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly ICartsRepository cartsRepository;

        public HomeController(IProductRepository productRepository, ICartsRepository cartsRepository)
        {
            this.productRepository = productRepository;
            this.cartsRepository = cartsRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Catalog()
        {
            var products = productRepository.GetProducts();
            return View(products);
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
