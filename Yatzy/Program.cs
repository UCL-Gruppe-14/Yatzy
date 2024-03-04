using System.Xml.Schema;

namespace Yatzy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Player p1 = new Player();//instantiering af objekter af player klassen
            Player p2 = new Player();
            Player p3 = new Player();
            int antalSpillere = 0;

            int valg;
            int terning;
            bool AntalSpillere = true;
            int i = 1;

            Console.WriteLine("Velkommen til YATZY\nSpillet der samler og knækker familier og venskaber!");
            do //oprettet en do while loop til valg af spillere, til hvis man taster forkert
            {
                Console.Write("Vælg antal spillere: ");
                try
                {
                    antalSpillere = int.Parse(Console.ReadLine()); //oprettet en try catch til når man vælger antal spillere, til at fange fejlinput.
                }
                catch (Exception e)
                {
                    Console.WriteLine("Forkert input, skriv et tal");
                }
                Console.WriteLine("Spiller 1");
                p1.setName(); //navngivning af første spiller
                AntalSpillere = false;
                if (antalSpillere >= 2)
                {
                    Console.WriteLine("Spiller 2");
                    p2.setName(); //navngivning af anden spiller
                }
                if (antalSpillere == 3)
                {
                    Console.WriteLine("Spiller 4");
                    p3.setName();//navngivning af tredje spiller
                }
            } while (AntalSpillere == true);

            while (i <= 15) //while loop der kører spillets 15 iterationer
            {
                Console.WriteLine("Runde: {0}   Spiller: {1}", i, p1.Navn);
                p1.ChangeTur(); //første spillers tur, metode til at rulle terninger, og metode til at sortere dem og printe dem ud
                p1.Slag();
                for (int x = 1; x <= 2; x++)
                {
                    p1.Omslag(); //metode til at udvælge terninger, og slå dem om, som man kan to gange
                    p1.Slag();
                }
                do
                {
                    p1.PointTavle(); // metode til udskrivning af point tavle, og metode til valg af hvilke point man vil tildele / stryge
                    p1.Point();
                } while (p1.tildelt == false);
                p1.PointTavle(); // udskrift af den opdaterede pointtavle
                Console.WriteLine("\n");
                if (antalSpillere >= 2)
                {
                    Console.WriteLine("Runde: {0}   Spiller: {1}", i, p2.Navn); //nøjagtig kopi af første spiller, blot for spiller 2
                    p2.ChangeTur();
                    p2.Slag();
                    for (int x = 1; x <= 2; x++)
                    {
                        p2.Omslag();
                        p2.Slag();
                    }
                    do
                    {
                        p2.PointTavle();
                        p2.Point();
                    } while (p2.tildelt == false);
                    p2.PointTavle();
                    Console.WriteLine("\n");
                }
                if (antalSpillere == 3)
                {
                    Console.WriteLine("Runde: {0}   Spiller: {1}", i, p3.Navn); //og for spiller 3
                    p3.ChangeTur();
                    p3.Slag();
                    for (int x = 1; x <= 2; x++)
                    {
                        p3.Omslag();
                        p3.Slag();
                    }
                    do
                    {
                        p3.PointTavle();
                        p3.Point();
                    } while (p3.tildelt == false);
                    p3.PointTavle();
                    Console.WriteLine("\n");
                }
                i++;
            }
            if (p1.Total > p2.Total && p1.Total > p3.Total) //Deklæring af vinder ved spillets afslutning
                Console.WriteLine("Spillet er slut, pointsne er talt op, og {0} vandt med: {1} point", p1.Navn, p1.Total);
            if (p1.Total < p2.Total && p2.Total > p3.Total)
                Console.WriteLine("Spillet er slut, pointsne er talt op, og {0} vandt med: {1} point", p2.Navn, p2.Total);
            if (p3.Total > p2.Total && p1.Total < p3.Total)
                Console.WriteLine("Spillet er slut, pointsne er talt op, og {0} vandt med: {1} point", p3.Navn, p3.Total);
        }
    }
}
