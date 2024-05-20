using CoreGsb.Models.MesExceptions;
using CoreGsb.Models.Persistance;
using System.Data;

namespace CoreGsb.Models.Dao
{
    public class ServiceDosage
    {
        public static DataTable GetTousLesDosage()
        {
            DataTable MesDosages = new DataTable();
            Serreurs er = new Serreurs("Erreur de lecture des dosage ", "dosage.Getdosage");

            try
            {
                String RequetteSQL = "SELECT * FROM dosage";
                MesDosages = DBInterface.Lecture(RequetteSQL, er);
                return MesDosages;

            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
    }
}
