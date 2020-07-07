using System;
public class Tama {
    private int nbPointsDeVie;
    private int nbPointsDeRessources;
    private ILifeStrategy lifeStrategy;

    // INTERFACE
    
    public void SetLifeStrategy(int randNumber)
    {
        if((randNumber % 2) == 0)
        {
             Console.WriteLine("Votre tama est heureux !");
             lifeStrategy = new HappyLifeStrategy();
        } else {
            Console.WriteLine("Oh non... Votre tama est triste...");
             lifeStrategy = new SadLifeStrategy();
        }
    }

    public void play() {
        Console.WriteLine("Vous jouez avec votre tama !");
        nbPointsDeVie += lifeStrategy.pointsWonWhenPlaying();
    }

    public void eat() {
        Console.WriteLine("Vous donnez à manger à votre tama !");
        nbPointsDeRessources += lifeStrategy.pointsLostWhenEating();
    }

    public Tama(int nbPointsDeVie, int nbPointsDeRessources, ILifeStrategy lifeStrategy)
     {
         nbPointsDeRessources = this.nbPointsDeRessources;
         nbPointsDeVie = this.nbPointsDeVie;
         lifeStrategy = this.lifeStrategy;
     }
    public override string ToString()
    {
       return "Points de vie " + nbPointsDeVie + ", Points de ressources: " + nbPointsDeRessources;
    }


}