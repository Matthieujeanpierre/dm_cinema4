using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    class Film
    {
        private int annnee;
        private string genre;
        private int idFilm;
        private string resume;
        private string titre;
        private Acteur A;

        public Film()
        {

        }

        public Film(int annee, string genre, int idFilm, string resume, string titre, Acteur A)
        {
            this.annnee = annee;
            this.genre = genre;
            this.idFilm = idFilm;
            this.resume = resume;
            this.titre = titre;
            this.A = A;
        }

        public int Annnee { get => annnee; set => annnee = value; }
        public string Genre { get => genre; set => genre = value; }
        public int IdFilm { get => idFilm; set => idFilm = value; }
        public string Resume { get => resume; set => resume = value; }
        public string Titre { get => titre; set => titre = value; }
        public Acteur a { get => a; set => a = value; }


        public Film getinstance()
        {
            Film f1 = new Film();
            return f1;
        }

        public  string ToString()
        {
            return $" Titre : {this.titre} Année:  {this.annnee} Genre:  {this.genre} Résumé :  {this.Resume}  Acteur : {this.A}";
        }

        public Acteur getActeurPrincipale()
        {
            Acteur Atc = new Acteur();
            return Atc;
        }


    }

   
}
