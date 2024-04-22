using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreGsb.Models.Dao;
using CoreGsb.Models.MesExceptions;
using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace CoreGsb.Controllers
{
    public class GestionMedicament : Controller
    {
        // GET: GestionMedicament
        public ActionResult Index()
        {
            System.Data.DataTable MesMedicament = null;
            try
            {
                MesMedicament = ServiceMedicament.GetTousLesMedicament();
            }
            catch(MonException e) {
                ModelState.AddModelError("Erreur", "Erreur lors  de la récuperation des mangas : " + e.Message);
            }
            return View(MesMedicament);
        }

        // GET: GestionMedicament/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GestionMedicament/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GestionMedicament/Create
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

        // GET: GestionMedicament/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GestionMedicament/Edit/5
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

        // GET: GestionMedicament/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GestionMedicament/Delete/5
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
