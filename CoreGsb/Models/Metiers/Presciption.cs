namespace CoreGsb.Models.Metiers
{
    public class Presciption
    {
        private string _idDosage;
        private string _idMedicament;
        private string _idTYpeIndividu;
        private string _posologie;

        public Presciption(string IdDosage, string IdMedicament, string IdTYpeIndividu, string Posologie)
        {
            this._idDosage = IdDosage;
            this._idMedicament = IdMedicament;
            this._idTYpeIndividu = IdTYpeIndividu;
            this._posologie = Posologie;
        }

        public string GetIdDosage()
        {
            return _idDosage;
        }
        public string GetIdMedicament()
        {
            return _idMedicament;
        }
        public string GetIdTypeIndividue()
        {
            return _idTYpeIndividu;
        }
        public string GetPosologie()
        {
            return _posologie;
        }
    }
}
