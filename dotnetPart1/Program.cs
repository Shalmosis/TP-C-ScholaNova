using System;

namespace dotnetPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Le but est simple: devinez le nombre généré \n");
           
            int nombreCoupsP1 = 0;
            int nombreCoupsP2 = 0;


            for(int i = 1; i <= 6; i++)
            {
              int isOdd = i % 2;
              int nombreAleatoire;
              var rand = new Random();
              int userNombre;
              bool hasGagne = false;
              nombreAleatoire = rand.Next(101);

              switch(isOdd)
              {
                  case 1:
                  // Joueur 1
                   
                    Console.WriteLine(nombreAleatoire);
                    Console.WriteLine(" ====== Joueur 1: Partie n°" + i + " ======");
                    Console.WriteLine("Veuillez entrer un nombre :");


                    // On demande à l'utilsateur d'entrer un nombre

                    do
                    {
                        userNombre = Convert.ToInt16(Console.ReadLine());

                        hasGagne = hasFound(nombreAleatoire, userNombre);

                        nombreCoupsP1 += 1;

                    } while (!hasGagne);
                  break;
                  case 0 :
                  // Joueur 2
                    Console.WriteLine(nombreAleatoire);
                    Console.WriteLine(" ======Joueur 2: Partie n°" + i + " ======");
                    Console.WriteLine("Veuillez entrer un nombre :");

                    // On demande à l'utilsateur d'entrer un nombre

                    do
                    {
                        userNombre = Convert.ToInt16(Console.ReadLine());

                        hasGagne = hasFound(nombreAleatoire, userNombre);

                        nombreCoupsP2 += 1;

                    } while (!hasGagne);
                  break;
              }  
            }
            Console.WriteLine("Joueur 1: " + nombreCoupsP1 + " coups. \n");
            Console.WriteLine("Joueur 2: " + nombreCoupsP2 + " coups. \n");

            if(nombreCoupsP1 > nombreCoupsP2)
            {
                Console.WriteLine("Joueur 2 a été plus rapide!");

            } else if (nombreCoupsP2 > nombreCoupsP1)
            {
                Console.Write("Joueur 1 a été le plus rapide !");

            } else {

                Console.Write("Vous êtes aussi rapides!");

            }

        }
        public static bool hasFound(int nombreAleatoire, int nombreUser)
        {
            bool hasGagne = false;
            if(nombreUser < nombreAleatoire)
            {
                Console.WriteLine("Raté! Le chiffre entré est trop petit.");
                hasGagne = false;

            } else if (nombreUser > nombreAleatoire) {

                Console.WriteLine("Raté! Le chiffre entré est trop grand");
                hasGagne = false;

            } else {

                    Console.WriteLine("Gagné !");
                hasGagne = true;
            }

            return hasGagne;
        }
    }
}
