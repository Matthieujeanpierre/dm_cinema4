using System;
using System.Collections.Generic;

namespace dm_cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //creaction objet cinéma
            cinema monCinema = new cinema();

            Acteur A1 = new Acteur(1942, 1, "FORD", "HARRISON");
            Acteur A2 = new Acteur(1956, 2, "HANKS", "TOM");

            monCinema.setActeur(A1);
            monCinema.setActeur(A2);

            monCinema.setFilm(1982, "Science-Fiction", 1, " L'action du film se situe à Los Angeles en 2019 et met en scène Rick Deckard (interprété par Harrison Ford), un ancien policier qui reprend du service pour traquer un groupe de réplicants, des androïdes créés à l'image de l'Homme, menés par l'énigmatique Roy Batty (interprété par Rutger Hauer)", "Blade Runner", A2);
            monCinema.setFilm(1992, "Animation", 2, "Le film met en scène un groupe de jouets. Woody, une poupée représentant un cow-boy, et Buzz l'Éclair, une figurine d'astronaute, en sont les personnages principaux", "Toy Story", A1);

            //Affichage 
         
            foreach(Acteur ACTEUR in monCinema.LstActeur)
            {

                Console.WriteLine("****************************************************************");
                Console.WriteLine(ACTEUR.ToString());
            }
    
            foreach (Film F in monCinema.LstFilm)
            {
                Console.WriteLine("****************************************************************");
                Console.WriteLine(F.ToString());
            }
        }

    }
}
