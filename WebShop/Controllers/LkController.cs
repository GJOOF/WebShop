using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Webshop.Controllers
{
    public class LkController : Controller
    {
        public IActionResult Favorites()
        {
            return View();
        }
        public IActionResult Deliveries()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
    }
}
