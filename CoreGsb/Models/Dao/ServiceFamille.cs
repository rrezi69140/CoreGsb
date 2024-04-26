using CoreGsb.Models.MesExceptions;
using CoreGsb.Models.Persistance;
using System.Data;

namespace CoreGsb.Models.Dao
{
    public class ServiceFamille
    {
        public static DataTable GetTousLesFamilles()
        {
            DataTable MesFamilles = new DataTable();
            Serreurs er = new Serreurs("Erreur de lecture des Medicament ", "Medicament.GetMedicament");

            try
            {
                String RequetteSQL = "SELECT * FROM famille";
                MesFamilles = DBInterface.Lecture(RequetteSQL, er);
                return MesFamilles;

            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
    }
}
