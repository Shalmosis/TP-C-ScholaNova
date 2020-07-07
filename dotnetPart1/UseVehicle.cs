using System;
class UseVehicle {
     /* static void Main(string[] args)
        {
             Console.WriteLine("Bonjour, entrez votre pseudonyme");
             string pseudo = Console.ReadLine();
        
            Voiture voiture = new Voiture("Citroën", 1, 80, 0, 80);
            Console.WriteLine("Achetez cette voiture?\n" + voiture + " \n Appuyez sur 1 pour valider. ");
            int choixMenu =  Convert.ToInt16(Console.ReadLine());
            Conducteur conducteur = new Conducteur(pseudo);
            conducteur.acheteVoiture(voiture);

            // ETAPE 1: LE CONDUCTEUR ACHETE UNE VOITURE

           do
           {
             Console.WriteLine("===== MENU =====");
            Console.WriteLine("1 - Rouler sur plusieurs kilomètres");
            Console.WriteLine("2 - Faire un plein d'essence");
            Console.WriteLine("3 - Remettre du carburant");
            Console.WriteLine("4 - Quitter le programme");
            choixMenu = Convert.ToInt16(Console.ReadLine());

            switch(choixMenu)
            {
                case 1: //Rouler
                    int nombreKm = Convert.ToInt16(Console.ReadLine());
                    conducteur.conduit(nombreKm);

                    break;
                case 2: // Plein
                    conducteur.faireLePlein();
                    break;
                case 3:
                    int nombreL = Convert.ToInt16(Console.ReadLine());
                    conducteur.remettreCarburant(nombreL);
                    break;
                case 4: break;
            }
           } while(choixMenu != 4);
        } */
}