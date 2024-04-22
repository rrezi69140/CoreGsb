using System.Data;
using CoreGsb.Models.MesExceptions;
namespace CoreGsb.Models.Dao


{
    public class ServiceVisiteur
    {

        public static DataTable GetTousLesVisiteur()
        {
            DataTable MesVisiteurs = new DataTable();
            Serreurs er = new Serreurs("Erreur de lecture des visiteurs ","Visiteur.GetVisiteur");
            
            try
            {
                String RequetteSQL = "SELECT * FROM Visiteur";
                MesVisiteurs = DBInterface.Lecture( RequetteSQL );
                return MesVisiteurs;

            }
            catch (Exception ex)
            {


            }
        }
    }
}
