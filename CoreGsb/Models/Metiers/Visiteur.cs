using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using System.Runtime.CompilerServices;

namespace CoreGsb.Models.Metiers
{
    public class Visiteur

    {
        private int idVisiteur;
        private int idLaboratoire;
        private int idSecteur;
        private string nom;
        private string prenom;
        private string adresseVisiteur;
        private string codePostaleVisiteur;
        private string villeVisteur;
        private DateTime dateEmbauche;
        private string login ;
        private string password ;
        private string typeVisiteur;


        public int IdVisiteur { get => idVisiteur; set => idVisiteur = value; }
        public int IdLaboratoire { get => idLaboratoire; set => idLaboratoire = value;}
        public int IdSecteur { get => idSecteur; set => idSecteur = value;}
        public string Nom { get => nom; set => nom = value; }

        public string Prenom { get => prenom; set => prenom = value; }
        public string AdresseVisiteur { get => adresseVisiteur; set => adresseVisiteur = value; }
        public string CodePostaleVsiteur { get => codePostaleVisiteur; set { codePostaleVisiteur = value;} }
        public string VilleVisteur { get => villeVisteur; set { villeVisteur = value; } }
        public DateTime DateEmbauche { get => dateEmbauche; set { dateEmbauche = value; } }
        public string Login { get => login; set { login = value; } }
        public string Password { get => password; set { password = value; } }
        public string TypeVisiteur { get => typeVisiteur; set { typeVisiteur = value; } }






    }
}
