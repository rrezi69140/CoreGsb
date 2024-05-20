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
                ViewBag.IdMedicament = id;
            }
            catch (MonException e)
            {
                ModelState.AddModelError("Erreur", "Erreur lors  de la récuperation des Prescriptions : " + e.Message);
            }
            return View(MesPrescriptions);
        }


       


        public IActionResult AjouterPrescription(string idMedicament)
        {
            System.Data.DataTable MesDosages = null;
            System.Data.DataTable MesTypesIndividues = null;
              ServiceMedicament serviceMedicament = new ServiceMedicament();
                
               
                System.Data.DataTable UnMedicament = null;
       

            try
            {
                UnMedicament = ServiceMedicament.GetUnsMedicament(idMedicament);

                foreach (DataRow dataRow in UnMedicament.Rows)

                {

                    Medicament medicamentEntity = new Medicament(dataRow.ItemArray[0].ToString(), dataRow.ItemArray[1].ToString(), dataRow.ItemArray[2].ToString(), dataRow.ItemArray[3].ToString(), dataRow.ItemArray[4].ToString(), dataRow.ItemArray[5].ToString(), dataRow.ItemArray[6].ToString());
                    ViewBag.Medicament = medicamentEntity;
                }

                MesDosages = ServiceDosage.GetTousLesDosage();
                MesTypesIndividues = ServiceTypeIndividu.GetTousLesTypeIndividue();
                ViewBag.DosagePrescription = MesDosages;
                ViewBag.DosageTypeIndividue = MesTypesIndividues;
               
                
              

            }
            catch (MonException e)
            {
                ModelState.AddModelError("Erreur", "Erreur lors  de la récuperation des presecriptopn : " + e.Message);
            }
            return View();
        }


        public IActionResult PostAjouterPrescription()
        {
            {
                ServicePrescription ServicePrescription = new ServicePrescription();
                Boolean Reponsse;

                string idDosage = Request.Form["Dosage"];
                string idMedicament = Request.Form["idMedicament"];
                string IDTypeIndividue = Request.Form["TypeIndividue"];
                string Posologie = Request.Form["Posologie"];
              

                try
                {
                  
                    Reponsse = ServicePrescription.AjouterPrescription(idDosage,idMedicament,IDTypeIndividue,Posologie);

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

        public IActionResult SupprimerPrescription(string idMedicament)
        {
            {
                ServiceMedicament ServiceMedicament = new ServiceMedicament();
                ServicePrescription servicePrescription = new ServicePrescription();
                System.Data.DataTable UnMedicament = null;

                Presciption PresciptionEntity = null;
        Boolean Reponsse;
                try
                {
                    UnMedicament = ServiceMedicament.GetUnsMedicament(idMedicament);
                    foreach (DataRow dataRow in UnMedicament.Rows)

                    {

                        PresciptionEntity = new Presciption(dataRow.ItemArray[0].ToString(), dataRow.ItemArray[1].ToString(), dataRow.ItemArray[2].ToString(), dataRow.ItemArray[3].ToString());
                       
                    }

                    Reponsse = servicePrescription.DeletPrescirption(PresciptionEntity.GetIdMedicament(), PresciptionEntity.GetIdDosage(),PresciptionEntity.GetIdTypeIndividue());



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
