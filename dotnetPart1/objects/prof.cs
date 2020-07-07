using System.Collections.Generic;

public class Prof : Personne {

    private List<Classe> classes;

    // NOTER UN ELEVE  

    public Prof(string nom)
    {
        this.nom = nom;
        List<Classe> classes = new List<Classe>();

    }
}
