using System.Collections.Generic;

public class Conducteur
{
    private string Pseudo { get ; set ; }
    private Voiture Voiture { get ; set ; }

    public void acheteVoiture(Voiture voiture)
    {
        voiture = this.Voiture;
    }

    public void conduit(int nombreKm) => Voiture.roule(nombreKm);
     public void faireLePlein() => Voiture.faireLePlein();
     public void remettreCarburant(int volumeCarburant) => Voiture.mettreCarburant(volumeCarburant);

    public Conducteur(string pseudo)
    {
        Pseudo = pseudo;
    }

}
