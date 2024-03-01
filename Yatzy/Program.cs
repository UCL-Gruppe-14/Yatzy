using System.Xml.Schema;

namespace Yatzy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Player p1 = new Player();
            Player p2 = new Player();
            Player p3 = new Player();
            int antalSpillere = 0;

            int valg;
            int terning;
            bool AntalSpillere = true;
            int i = 1;

            Console.WriteLine("Velkommen til YATZY\nSpillet der samler og knækker familier og venskaber!");
            do
            {
                Console.Write("Vælg antal spillere: ");
                try
                {
                    antalSpillere = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Forkert input, skriv et tal");
                }
                
                switch (antalSpillere)
                {
                    case 1:
                        Console.WriteLine("Spiller 1");
                        p1.setName();
                        AntalSpillere= false;
                        break;
                    case 2:
                        Console.WriteLine("Spiller 1");
                        p1.setName();
                        Console.WriteLine("Spiller 2");
                        p2.setName();
                        AntalSpillere= false;
                        break;
                    case 3:
                        Console.WriteLine("Spiller 1");
                        p1.setName();
                        Console.WriteLine("Spiller 2");
                        p2.setName();
                        Console.WriteLine("Spiller 3");
                        p3.setName();
                        AntalSpillere= false;
                        break;
                    default:
                        Console.WriteLine("Forkert input:\nVælg mellem 1 - 3 spillere.");
                        break;
                }
            } while (AntalSpillere == true);

            while (i <= 15)
            {
                Console.WriteLine("Runde: {0}   Spiller: {1}", i, p1.Navn);
                p1.ChangeTur();
                p1.Slag();
                for (int x = 1; x <= 2; x++)
                {
                    p1.Omslag();
                    p1.Slag();
                }
                do
                {
                    p1.PointTavle();
                    p1.Point();
                } while (p1.tildelt == false);
                p1.PointTavle();
                Console.WriteLine("\n");
                if (antalSpillere >= 2)
                {
                    Console.WriteLine("Runde: {0}   Spiller: {1}", i, p2.Navn);
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
                    Console.WriteLine("Runde: {0}   Spiller: {1}", i, p3.Navn);
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
            
            Console.WriteLine("Spillet er slut, pointsne er talt op, og x vandt med: {0} point", p1.PointTotal());
        }
    }
}
