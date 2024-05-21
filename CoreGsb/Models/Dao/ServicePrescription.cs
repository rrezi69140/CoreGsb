using CoreGsb.Models.MesExceptions;
using CoreGsb.Models.Metiers;
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


        public Boolean AjouterPrescription(string idDosage, string IdMedicament, string IdTypeIndividue, string posologie)
        {
            DataTable Reponsse = new DataTable();
            Serreurs er = new Serreurs("Erreur de l'ajout  d'une prescription  ", "precription.Ajouter");


            try
            {
                String RequetteSQL = $"INSERT INTO   prescrire (id_dosage ,id_medicament ,id_type_individu ,posologie)  VALUE('{idDosage.Replace("'", "''")}'  ,'{IdMedicament.Replace("'", "''")}','{IdTypeIndividue.Replace("'", "''")}' ,'{posologie.Replace("'", "''")}' ) ";
                Reponsse = DBInterface.Lecture(RequetteSQL, er);

                return true;

            }
            catch (Exception e)
            {
                return false;
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);

            }
        }


        public static DataTable GetUnePrescription(string idDosage,string idMedicament,string IdTYpeIndividue)
        {
            DataTable UnePrescription = new DataTable();
            Serreurs er = new Serreurs("Erreur de lecture d'un Medicament ", "Medicament.GetUnMedicament");

            try
            {
                String RequetteSQL = $"SELECT *  FROM prescrire where id_dosage  = {idDosage} and   id_medicament  = {idMedicament} and  id_type_individu = {IdTYpeIndividue} ";
                UnePrescription = DBInterface.Lecture(RequetteSQL, er);
                return UnePrescription;

            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
        public Boolean ModifierPrescription(string idDosage, string IdMedicament, string IdTypeIndividue, string posologie, string AvidDosage, string AvIdTypeIndividue)
        {
            DataTable Reponsse = new DataTable();
            Serreurs er = new Serreurs("Erreur de l'ajout  d'une prescription  ", "precription.Ajouter");


            try
            {
                String RequetteSQL = $"UPDATE   prescrire set  id_dosage = '{idDosage.Replace("'", "''")}' ,id_type_individu = '{IdTypeIndividue.Replace("'", "''")}' ,posologie = '{posologie.Replace("'", "''")}' Where  id_medicament = '{IdMedicament.Replace("'", "''")}' and id_dosage  = '{AvidDosage.Replace("'", "''")}' and id_type_individu  = '{AvIdTypeIndividue.Replace("'", "''")}' ";
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
