namespace CoreGsb.Models.Metiers
{
    public class Famille
    {
        private int _idFamille;
        private string _libFamille;

        public Famille(int idFamille, string libFamille)
        {
            _idFamille = idFamille;
            _libFamille = libFamille;
        }

        public int GetIdFamille()
        {
            return _idFamille;
        }

        public string GetLibFamille()
        {
            return _libFamille;
        }
    }
}
