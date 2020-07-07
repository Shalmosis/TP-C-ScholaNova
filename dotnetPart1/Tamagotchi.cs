using System;
class Tamagotchi {

    static void Main(string[] args)
    {
        Console.WriteLine(" _                                    _       _     _");
        Console.WriteLine("| |                                  | |     | |   (_)");
        Console.WriteLine("| |_ __ _ _ __ ___   __ _  __ _  ___ | |_ ___| |__  _ ");
        Console.WriteLine("| __/ _` | '_ ` _'\\/ _` |/ _` |/ _ \\| __/ __| '_ \\| |");
        Console.WriteLine("| || (_| | | | | | | (_| | (_| | (_) | || (__| | | | |");
       Console.WriteLine(" \\__\\__,_|_| |_| |_|\\__,_\\__, |\\___/ \\__\\___|_| |_|_|");
        Console.WriteLine("                           __/ |  "); 
        Console.WriteLine("                          |___/");

        Tama tama = new Tama(10, 10, new SadLifeStrategy());
        int choixMenu = 1;
        var rand = new Random();
        int randNumber;

       do{
        randNumber = rand.Next(101);
        tama.SetLifeStrategy(randNumber);
        Console.WriteLine(tama.ToString());
        Console.WriteLine("===== MENU =====");
        Console.WriteLine("1 - Jouer");
        Console.WriteLine("2 - Lui donner à manger");
        Console.WriteLine("3 - Revenir plus tard");
        choixMenu = Convert.ToInt16(Console.ReadLine());

        switch(choixMenu)
        {
            case 1:
                tama.play();
            break;
            case 2:
                tama.eat();
            break;
        }
       } while(choixMenu != 3);

 





                    
                       
    }

}