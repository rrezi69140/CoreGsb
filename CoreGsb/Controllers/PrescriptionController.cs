using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CoreGsb.Models.Dao;
using CoreGsb.Models.MesExceptions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using CoreGsb.Models.Metiers;
using Mysqlx.Resultset;
using System.Data;

namespace CoreGsb.Controllers
{
    public class PrescriptionController : Controller
    {
        // GET: PrescriptionController
        public ActionResult Index(string id)
        {
            System.Data.DataTable MesPrescriptions = null;
            try
            {
                MesPrescriptions = ServicePrescription.GetPrescriptionByMedicament(id);
                ViewBag.Prescriptions = MesPrescriptions;
            }
            catch (MonException e)
            {
                ModelState.AddModelError("Erreur", "Erreur lors  de la récuperation des Prescriptions : " + e.Message);
            }
            return View(MesPrescriptions);
        }

        // GET: PrescriptionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PrescriptionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PrescriptionController/Create
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

        // GET: PrescriptionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PrescriptionController/Edit/5
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

        // GET: PrescriptionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PrescriptionController/Delete/5
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
