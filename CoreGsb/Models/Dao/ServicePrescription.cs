using CoreGsb.Models.MesExceptions;
using CoreGsb.Models.Persistance;
using System.Data;

namespace CoreGsb.Models.Dao
{
    public class ServicePrescription
    {
        public static DataTable GetPrescriptionByMedicament(string idMedicament)
        {
            DataTable MesPresciption = new DataTable();
            Serreurs er = new Serreurs("Erreur de lecture des Prescription ", "Prescription.Prescription");

            try
            {
                String RequetteSQL =$"SELECT * FROM V_ListerPrescription  where id_medicament = {idMedicament}";
                MesPresciption = DBInterface.Lecture(RequetteSQL, er);
                return MesPresciption;

            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }



        public Boolean DeletPrescirption(string idMedicament, string idDosage,string idTypeIndividue)
        {
            DataTable Reponsse = new DataTable();
            Serreurs er = new Serreurs("Erreur de la suppresion d'une prescriptions ", "Prescription.DelectPrescription");

            try
            {
                String RequetteSQL = $"SELECT F_Supprimer_Precription({idMedicament},{idDosage},{idTypeIndividue}) ";
                Reponsse = DBInterface.Lecture(RequetteSQL, er);

                return true;

            }
            catch (Exception e)
            {
                return false;
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);

            }
        }


    }
}
