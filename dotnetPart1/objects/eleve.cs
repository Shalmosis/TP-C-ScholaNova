using System.Collections.Generic;

public class Eleve : Personne {    
    private string niveau;
    private int moyenne;

    private List<int> notes;

    private Classe classe;

    public string Niveau { get => niveau; }
    public int Moyenne { get => moyenne; }
    public List<int> Notes {get => notes; set => notes = value; } 
    public Classe Classe { get => classe ; }


    public void calculerMoyenne()
    {
        int somme = 0;

       foreach (int note in notes)
       {
        somme += note;
       } 
       moyenne = somme / notes.Count;
    }  
    
    public void ajouterNoter(int note)
    {
        notes.Add(note);
    }
}