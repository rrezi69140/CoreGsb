using CoreGsb.Models.MesExceptions;
using CoreGsb.Models.Persistance;
using System.Data;

namespace CoreGsb.Models.Dao
{
    public class ServiceTypeIndividu
    {
        public static DataTable GetTousLesTypeIndividue()
        {
            DataTable MesTypesIndividues = new DataTable();
            Serreurs er = new Serreurs("Erreur de lecture des type_individu ", "type_individu.Gettype_individu");

            try
            {
                String RequetteSQL = "SELECT * FROM type_individu";
                MesTypesIndividues = DBInterface.Lecture(RequetteSQL, er);
                return MesTypesIndividues;

            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
    }
}
