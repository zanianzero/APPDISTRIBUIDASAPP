using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Facturacion.WebMVC.Controllers
{
    public class FactFacturaCabeceraController : Controller
    {
        // GET: FactFacturaCabeceraController
        public ActionResult Index()
        {
            return View();
        }

        // GET: FactFacturaCabeceraController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FactFacturaCabeceraController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FactFacturaCabeceraController/Create
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

        // GET: FactFacturaCabeceraController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FactFacturaCabeceraController/Edit/5
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

        // GET: FactFacturaCabeceraController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FactFacturaCabeceraController/Delete/5
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
