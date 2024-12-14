using Microsoft.AspNetCore.Mvc;

namespace Webshop.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
