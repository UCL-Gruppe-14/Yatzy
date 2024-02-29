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
            int antalSpillere;

            int valg;
            int terning;
            bool rigtigtValg = true;

            //p1.ChangeTur();
            //p1.Slag();

            /*Console.WriteLine("Velkommen til YATZY\nSpillet der samler og knækker familier og venskaber!");
            Console.Write("Vælg antal spillere: ");
            antalSpillere = int.Parse(Console.ReadLine());
            switch (antalSpillere)
            {
                case 1:
                    Console.WriteLine("Spiller 1");
                    p1.setName();
                    Console.WriteLine("Spiller 2");
                    p2.setName();
                    Console.WriteLine("Spiller 3");
                    break;
                case 2:
                    Console.WriteLine("Spiller 1");
                    p1.setName();
                    Console.WriteLine("Spiller 2");
                    p2.setName();
                    Console.WriteLine("Spiller 3");
                    p3.setName();
                    break;
                default:
                    Console.WriteLine("Forkert Input");
                    break;
            }*/


            //p1.setName();
            //if (antalSpillere == 1)
            {
                for (int i = 1; i <= 15; i++)
                {
                    //Console.WriteLine(p1.Navn + "'s tur");
                    p1.ChangeTur();
                    p1.Slag();
                    for (int x = 1; x <= 2; x++)
                    {
                       p1.Omslag();
                       p1.Slag();
                    }
                    p1.PointTavle();
                    do
                    {
                        p1.Point();
                        p1.PointTavle();
                    } while (p1.tildelt == false);
                }
                Console.WriteLine("Spillet er slut, pointsne er talt op, og x vandt med: {0} point", p1.PointTotal());
            }
        }
    }
}
