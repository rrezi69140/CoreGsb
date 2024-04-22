using System.Data;
using CoreGsb.Models.MesExceptions;
using CoreGsb.Models.Persistance;
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
                MesVisiteurs = DBInterface.Lecture( RequetteSQL,er );
                return MesVisiteurs;

            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);

            }
        }

        public static DataTable UnVisiteur(string login)
        {
            DataTable MesVisiteurs = new DataTable();
            Serreurs er = new Serreurs("Erreur de lecture des visiteurs ", "Visiteur.GetVisiteur");

            try
            { 
                String RequetteSQL = $"SELECT * FROM Visiteur where login_visiteur  =  {login}   ";
                MesVisiteurs = DBInterface.Lecture(RequetteSQL, er);
                return UnVisiteurs;

            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);

            }
        }
    }
}
