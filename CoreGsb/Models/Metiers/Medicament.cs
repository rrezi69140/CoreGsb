namespace CoreGsb.Models.Metiers
{
    public class Medicament
    {
        private string _idMedicament;
        private string _idFamille;
        private string _depotLegal;
        private string _nomCommercial;
        private string _effets;
        private string _contreIndication;
        private string _prixEchantillon;

        public Medicament(string idMedicament, string idFamille, string depotLegal, string nomCommercial, string effets, string contreIndication, string prixEchantillon)
        {
            _idMedicament = idMedicament;
            _idFamille = idFamille;
            _depotLegal = depotLegal;
            _nomCommercial = nomCommercial;
            _effets = effets;
            _contreIndication = contreIndication;
            _prixEchantillon = prixEchantillon;
        }

        public string GetIdMedicament()
        {
            return _idMedicament;
        }

        public string GetIdFamille()
        {
            return _idFamille;
        }

        public string GetDepotLegal()
        {
            return _depotLegal;
        }

        public string GetNomCommercial()
        {
            return _nomCommercial;
        }

        public string GetEffets()
        {
            return _effets;
        }

        public string GetContreIndication()
        {
            return _contreIndication;
        }

        public string GetPrixEchantillon()
        {
            return _prixEchantillon;
        }
    }

}
