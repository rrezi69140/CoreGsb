using CoreGsb.Models.Dao;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreGsb.Controllers
{
    public class ConnexionController : Controller
    {
        // GET: ConnexionController1
        
        public ActionResult Index()
        {
            return View();
        }

        // GET: ConnexionController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConnexionController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConnexionController1/Create
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

        // GET: ConnexionController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ConnexionController1/Edit/5
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

        // GET: ConnexionController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ConnexionController1/Delete/5
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


        public ActionResult Connexion()
        {

            
            return View();
        }


    }   
}
