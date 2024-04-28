using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreGsb.Models.Dao;
using CoreGsb.Models.MesExceptions;

using Microsoft.AspNetCore.Mvc.ModelBinding;
using CoreGsb.Models.Metiers;
using Mysqlx.Resultset;
using System.Data;


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
                ViewBag.Medicamnt = MesMedicament;
            }
            catch(MonException e) {
                ModelState.AddModelError("Erreur", "Erreur lors  de la récuperation des mangas : " + e.Message);
            }
            return View(MesMedicament);
        }



        public IActionResult SupprimerMedicament(string  id)
        {
            {
                ServiceMedicament ServiceMedicament = new ServiceMedicament();
                Boolean Reponsse ;
                try
                {
                    Reponsse =  ServiceMedicament.DeletUnMedicament(id);
                   


                }
                catch (MonException e)
                {
                    Reponsse = false;
                    ModelState.AddModelError("Erreur", "Erreur lors  de la récuperation des mangas : " + e.Message);
                }
                ViewBag.Reponsse = Reponsse;
                return View();
            }
        }



        public IActionResult ModiffierMédicament(string id)
        {
            {
                ServiceMedicament serviceMedicament = new ServiceMedicament();
                
                



                System.Data.DataTable UnMedicament = null;
                System.Data.DataTable MesFamilles = null;
                try
                {
                    UnMedicament = ServiceMedicament.GetUnsMedicament(id);


                    foreach (DataRow dataRow in UnMedicament.Rows)

                    {

                        Medicament medicamentEntity = new Medicament(dataRow.ItemArray[0].ToString(), dataRow.ItemArray[1].ToString(), dataRow.ItemArray[2].ToString(), dataRow.ItemArray[3].ToString(), dataRow.ItemArray[4].ToString(), dataRow.ItemArray[5].ToString(), dataRow.ItemArray[6].ToString());
                        ViewBag.Medicament = medicamentEntity;
                    }

                    MesFamilles = ServiceFamille.GetTousLesFamilles();
                    ViewBag.FamilleMedicament = MesFamilles;








                }

                catch (MonException e)
                {

                    ModelState.AddModelError("Erreur", "Erreur lors  de la récuperation des mangas : " + e.Message);
                }
               
                return View();
            }
        }

        public IActionResult PostModiffierMédicament()
        {
            {
                ServiceMedicament ServiceMedicament = new ServiceMedicament();
                Boolean Reponsse;

                string idMedicament = Request.Form["IdMedicament"];
                string idFamille = Request.Form["Famille"];
                string depotLegal = Request.Form["DepotLegal"];
                string nomComercial = Request.Form["NomCommercial"];
                string effets = Request.Form["Effets"];
                string contreIndication = Request.Form["ContreIndication"];
                string prixEchantillon = Request.Form["PrixEchantillon"];

                try
                {
                    Reponsse = ServiceMedicament.ModifierMedicament(idMedicament, idFamille, depotLegal, nomComercial, effets, contreIndication, prixEchantillon);

                }
                catch (MonException e)
                {
                    Reponsse = false;
                    ModelState.AddModelError("Erreur", "Erreur lors  de la récuperation des mangas : " + e.Message);
                }
                ViewBag.Reponsse = Reponsse;
                return View();
            }
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
