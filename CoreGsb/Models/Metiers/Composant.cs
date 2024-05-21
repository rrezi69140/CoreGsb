namespace CoreGsb.Models.Metiers
{
    public class Composant
    {
        private string _idComposant;
        private string _idMedicament;
        private string _qteFormuler;
        public Composant(string IdComposant , string IdMedicamnet, string QteFormuler)

        {
            _idComposant = IdComposant;
            _idMedicament = IdMedicamnet;
            _qteFormuler = QteFormuler;
        }


        public string GetIdComposant()
        {
            return _idComposant;
        }
        public string GetIdMedicamnet()
        {
            return _idMedicament;
        }
        public string GetQteFormuler()
        {
            return _qteFormuler;
        }
    }

}
