using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    class Acteur
    {
        private int anneeNaissance;
        private int id;
        private string nom;
        private string prenom;
        private Acteur acteurPrincipale;


        public Acteur()
        {
        }

        public Acteur(int anneeNaissance, int id, string nom, string prenom)
        {
            this.AnneeNaissance = anneeNaissance;
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
        }

        public int AnneeNaissance { get => anneeNaissance; set => anneeNaissance = value; }
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public Acteur getInstance()
        {
            Acteur act = new Acteur();
            return act;
        }

        public override string ToString()
        {
            return $" Nom : {this.Nom} Prenom : {this.Prenom} année :{this.AnneeNaissance} ";
        }
    }
}
