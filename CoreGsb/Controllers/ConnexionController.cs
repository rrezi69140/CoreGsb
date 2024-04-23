using CoreGsb.Models.Dao;
using CoreGsb.Models.MesExceptions;
using CoreGsb.Models.Metiers;
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

        public IActionResult Deconnexion()
        {
            
            
                HttpContext.Session.SetInt32("IsConneted", 0);
            return RedirectToAction("Index", "Home");



        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Controle()
        {
            try
            {
                // on récupère les données du formulaire
                string login = Request.Form["login"];
                string mdp = Request.Form["pwd"];
                try
                {
                    ServiceVisiteur unServiceVIsiteur = new ServiceVisiteur();
                    Visiteur unVIsiteur = unServiceVIsiteur.GetUnVisiteur(login);
                    if (unVIsiteur != null)
                    {
                        try
                        {



                            if (unVIsiteur.Password != mdp)
                            {
                              

                                ModelState.AddModelError("Erreur", "Erreur lors du contrôle du  mot de passe pour: " + login);
                            return RedirectToAction("Index", "Connexion");
                            }
                            else
                            {
                                HttpContext.Session.SetInt32("IsConneted", 1);
                            }
                        }
                        catch (Exception e)
                        {
                            ModelState.AddModelError("Erreur", "Erreur lors du contrôle : " +
                           e.Message);
                            return RedirectToAction("Index", "Connexion");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("Erreur", "Erreur login erroné : " + login);
                        return RedirectToAction("Index", "Connexion");
                    }
                }
                catch (MonException e)
                {
                    ModelState.AddModelError("Erreur", "Erreur lors de l'authentification : " +
                   e.Message);
                    return RedirectToAction("Index", "Connexion");
                }
                return RedirectToAction("Index", "Home");
            }
            catch (MonException e)
            {
                ModelState.AddModelError("Erreur", "Erreur lors de l'authentification : " +
               e.Message);
                return RedirectToAction("Index", "Connexion");
            }
        }

    }   
}
