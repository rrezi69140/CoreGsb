using System.Data;
using System.Security;
using CoreGsb.Models.MesExceptions;
using CoreGsb.Models.Metiers;
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

        public static DataTable GetUnVisiteur(string login)
        {
            DataTable UnVisiteurs = new DataTable();
            Serreurs er = new Serreurs("Erreur de lecture des visiteurs ", "Visiteur.GetUnVisiteur");
            Visiteur visiteur = null;
            try
            { 
                String RequetteSQL = $"SELECT * FROM Visiteur where login_visiteur  =  {login}   ";
                UnVisiteurs = DBInterface.Lecture(RequetteSQL, er);
                if (UnVisiteurs.IsInitialized && UnVisiteurs.Rows.Count > 0)
                {
                    visiteur = new Visiteur();
                    DataRow dataRow = UnVisiteurs.Rows[0];
                    
                    visiteur.IdVisiteur = Int16.Parse(dataRow[0].ToString());
                    visiteur.IdLaboratoire = Int16.Parse(dataRow[1].ToString());
                    visiteur.IdSecteur = Int16.Parse(dataRow[2].ToString());
                    visiteur.Nom = (dataRow[3].ToString());
                    visiteur.Prenom = (dataRow[4].ToString());
                    visiteur.AdresseVisiteur = (dataRow[5].ToString());
                    visiteur.CodePostaleVsiteur = (dataRow[6].ToString());
                    visiteur.VilleVisteur = (dataRow[7].ToString());
                    //  visiteur.DateEmbauche = (Int16.Parse.dataRow[8].ToString();
                    visiteur.Login = (dataRow[9].ToString());
                    visiteur.Password = (dataRow[10].ToString());
                    visiteur.TypeVisiteur = (dataRow[11].ToString());

                }
                return visiteur;

            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);

            }
        }


       
    }
}
