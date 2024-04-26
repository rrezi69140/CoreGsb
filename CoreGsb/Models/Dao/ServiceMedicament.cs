using CoreGsb.Models.MesExceptions;
using CoreGsb.Models.Persistance;
using System.Data;
using System.Security;


namespace CoreGsb.Models.Dao
{
    public class ServiceMedicament
    {
        public static DataTable GetTousLesMedicament()
        {
            DataTable MesMedicaments = new DataTable();
            Serreurs er = new Serreurs("Erreur de lecture des visiteurs ", "Visiteur.GetVisiteur");

            try
            {
                String RequetteSQL = "SELECT nom_commercial,lib_famille,effets,contre_indication,lib_presentation, depot_legal,qte_formuler,prix_echantillon FROM v_listermedicament";
                MesMedicaments = DBInterface.Lecture(RequetteSQL, er);
                return MesMedicaments;
                
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);

            }
        }

    }
}
