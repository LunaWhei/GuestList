using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GuestList.Controllers
{
    public class ExampleApi : Controller
    {
        // GET: ExampleApi
        public ActionResult Index()
        {
            return View();
        }

        // GET: ExampleApi/Details/5
        public ActionResult Details(int id)
        {
            return Ok(id);
        }

        // GET: ExampleApi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExampleApi/Create
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

        // GET: ExampleApi/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExampleApi/Edit/5
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

        // GET: ExampleApi/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExampleApi/Delete/5
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
