using Microsoft.AspNetCore.Mvc;

namespace Webshop.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
