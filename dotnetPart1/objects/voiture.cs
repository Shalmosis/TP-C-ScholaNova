using System;

public class Voiture
{
    private string marque;
    private int consommationCarburant; // L / 100 km.
    private int niveauPlein;
    private int compteurKilometre;
    private int capaciteResevoir;

    /*
    Roule sur une distance en kilomètre
    */
    public void roule(int nombreKilometre) // Le conducteur va rouler pour X km, par exemple 300 kilomètres.
    {
        // SI ASSEZ D'ESSENCE : ROULE JUSQU'AU BOUT
        // On sait que 1 L = 100 km. 
        int nombreDeLitreDepense = nombreKilometre / 100;
        int kilometreParcourus;

        if(niveauPlein >= nombreDeLitreDepense)
        {
            // L'utilisateur roule
            Console.WriteLine("Vous parcourez " + nombreKilometre + " kilomètres.");
            kilometreParcourus = nombreDeLitreDepense * 100;
            niveauPlein -= nombreDeLitreDepense;

        } else { // SINON CONDUITE PARTIELLE
            
           kilometreParcourus = niveauPlein * 100;
            niveauPlein -= niveauPlein;
            Console.WriteLine("Aïe, c'est la panne d'essence! Vous n'avez pu que parcourir " + kilometreParcourus + " kilomètres...");

        }

        // GAGNE DES KM
        compteurKilometre += kilometreParcourus; 

    }

    public void faireLePlein()
    {
        // ON VA REMPLIR COMPLETEMENT LE NIVEAU DE PLEIN
        niveauPlein = capaciteResevoir;
        Console.WriteLine("Vous avez fait le plein !");
    }
    public void mettreCarburant(int volumeCarburant)
    {
        // ON VA REMPLIR PARTIELLEMENT LE NIVEAU DE PLEIN
        if((niveauPlein += volumeCarburant) > capaciteResevoir)
        {
            Console.WriteLine("Ca déborde !");

        } else {
            niveauPlein += volumeCarburant;
            Console.WriteLine("Le niveau de plein est remonté à " + niveauPlein + " Litres.");
        }
    }

    public override string ToString()
    {
       return "Modèle de voiture : " + marque + ", consommation carburant: " + consommationCarburant + "/ 100 km , capacité du Réservoir:" + capaciteResevoir + " L. \n Etat de la voiture: " + niveauPlein + " L de carburant restants, " + compteurKilometre + " km parcourus.";
    }

    public Voiture(string marque, int consommationCarburant, int niveauPlein, int compteurKilometre, int capaciteResevoir)
    {
        marque = this.marque;
        consommationCarburant = this.consommationCarburant;
        niveauPlein = this.niveauPlein;
        compteurKilometre = this.compteurKilometre;
        capaciteResevoir = this.capaciteResevoir;
    }
}