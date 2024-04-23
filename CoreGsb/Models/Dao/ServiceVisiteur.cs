using System.Data;
using System.Security;
using CoreGsb.Models.MesExceptions;
using CoreGsb.Models.Metiers;
using CoreGsb.Models.Persistance;
namespace CoreGsb.Models.Dao;



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

         public Visiteur GetUnVisiteur(string login)
        {
            DataTable dt;
            Visiteur INvISIT = null;
            String RequetteSQL = $"SELECT * FROM Visiteur where login_visiteur  =  '{login}'   ";
            Serreurs er = new Serreurs("Erreur de lecture des visiteurs ", "Visiteur.GetUnVisiteur");

            try
            {       
                dt = DBInterface.Lecture(RequetteSQL, er);
                if (dt.IsInitialized && dt.Rows.Count > 0)
                {
                    INvISIT = new Visiteur();
                    DataRow dataRow = dt.Rows[0];
                    
                    INvISIT.IdVisiteur = Int16.Parse(dataRow[0].ToString());
                    INvISIT.IdLaboratoire = Int16.Parse(dataRow[1].ToString());
                    INvISIT.IdSecteur = Int16.Parse(dataRow[2].ToString());
                    INvISIT.Nom = (dataRow[3].ToString());
                    INvISIT.Prenom = (dataRow[4].ToString());
                    INvISIT.AdresseVisiteur = (dataRow[5].ToString());
                    INvISIT.CodePostaleVsiteur = (dataRow[6].ToString());
                    INvISIT.VilleVisteur = (dataRow[7].ToString());
                    //  visiteur.DateEmbauche = (Int16.Parse.dataRow[8].ToString();
                    INvISIT.Login = (dataRow[9].ToString());
                    INvISIT.Password = (dataRow[10].ToString());
                    INvISIT.TypeVisiteur = (dataRow[11].ToString());

                }
                return INvISIT;

            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);

            }
        }


       
    }

