using System.Collections.Generic;

namespace dm_cinema
{
    class cinema
    {
        private cinema cine;
        private List<Acteur> lstActeur;
        private List<Film> lstFilm;

        public cinema()
        {
            this.LstActeur = new List<Acteur>();
            this.LstFilm = new List<Film>();
        }
        public cinema(cinema cine)
        {
            this.cine = cine;
           
        }

        public cinema getCine { get => getCine; set => getCine = value; }
        public List<Acteur> LstActeur { get => lstActeur; set => lstActeur = value; }
         public List<Film> LstFilm { get => lstFilm; set => lstFilm = value; }

        public cinema getInstance()
        {
            cinema cinoch = new cinema();
            return cinoch;
        }

        public Acteur getActeur(int id)
        {
            Acteur Act1 = new Acteur();
            foreach (Acteur ACT in this.LstActeur)
            {
                if (ACT.Id == id)
                {
                    Act1 = ACT;
                }
                return Act1;
            }
            return null;
        }

        public Film getFilm(int id)
        {
            Film Act1 = new Film();
            foreach (Film ACT in this.LstFilm)
            {
                if (ACT.IdFilm == id)
                {
                    Act1 = ACT;
                }
                return Act1;
            }
            return null;
        }
            

        public int nbActeur()
        {
            return LstActeur.Count;
        }

        public void setFilm(int annee, string genre, int idFilm, string resume, string titre, Acteur A)
        {
            Film FL = new Film( annee,  genre,  idFilm,  resume,  titre,  A);

            this.LstFilm.Add(FL);
        }

        public void setActeur(Acteur A)
        {
            lstActeur.Add(A);
        }


    }
}
