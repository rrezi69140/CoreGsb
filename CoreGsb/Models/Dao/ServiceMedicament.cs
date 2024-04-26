using CoreGsb.Models.MesExceptions;
using CoreGsb.Models.Metiers;
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
            Serreurs er = new Serreurs("Erreur de lecture des Medicament ", "Medicament.GetMedicament");

            try
            {
                String RequetteSQL = "SELECT id_medicament,nom_commercial,lib_famille,effets,contre_indication,lib_presentation, depot_legal,qte_formuler,prix_echantillon FROM v_listermedicament";
                MesMedicaments = DBInterface.Lecture(RequetteSQL, er);
                return MesMedicaments;
                
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }

        public Boolean  DeletUnMedicament(string  idMedicament)
        {
            DataTable Reponsse = new DataTable();
            Serreurs er = new Serreurs("Erreur de la suppresion d'un medicament  s ", "Medicament.DelectMedicament");

            try
            {
                String RequetteSQL = $"SELECT F_Supprimer_Medicament({idMedicament}) ";
                Reponsse = DBInterface.Lecture(RequetteSQL, er);

                return true;

            }
            catch (Exception e)
            {
                return false;
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);

            }
        }

        public static DataTable GetUnsMedicament(string idMedicament)
        {
            DataTable UnMedicament = new DataTable();
            Serreurs er = new Serreurs("Erreur de lecture d'un Medicament ", "Medicament.GetUnMedicament");

            try
            {
                String RequetteSQL = $"SELECT *  FROM medicament where id_medicament = {idMedicament}";
                UnMedicament = DBInterface.Lecture(RequetteSQL, er);
                return UnMedicament;

            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }

    }
}
