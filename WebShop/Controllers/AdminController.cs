using Microsoft.AspNetCore.Mvc;

namespace Webshop.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
