using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Webshop.Controllers
{
    public class LkController : Controller
    {
        // GET: LkController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LkController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LkController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LkController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LkController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LkController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LkController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LkController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
