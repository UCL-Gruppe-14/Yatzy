using System.Xml.Schema;

namespace Yatzy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Player p1 = new Player();
            Player p2 = new Player();
            Player p3 = new Player();
            int antalSpillere;
            int t1, t2, t3, t4, t5;
            int valg;
            int terning;
            bool rigtigtValg = true;

            t1 = r.Next(1, 6);
            t2 = r.Next(1, 6);
            t3 = r.Next(1, 6);
            t4 = r.Next(1, 6);
            t5 = r.Next(1, 6);
            do
            {
                Console.WriteLine("Velkommen til YATZY\nSpillet der samler og knækker familier og venskaber!");
                Console.Write("Vælg antal spillere: ");
                antalSpillere = int.Parse(Console.ReadLine());
                switch (antalSpillere)
                {
                    case 1:
                        Console.Write("Spiller 1 - Navn: ");
                        p1.Navn = Console.ReadLine();
                        Console.Write("Spiller 2 - Navn: ");
                        p2.Navn = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Spiller 1 - Navn: ");
                        p1.Navn = Console.ReadLine();
                        Console.Write("Spiller 2 - Navn: ");
                        p2.Navn = Console.ReadLine();
                        Console.Write("Spiller 3 - Navn: ");
                        p3.Navn = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Forkert Input");
                        break;
                }

                Console.WriteLine("{0}'s tur")
                for (int i = 0; i <= 3; i++)
                {
                    Console.WriteLine("Terningen ruller, og bliver: {0}, {1}, {2}, {3}, {4}", t1, t2, t3, t4, t5);
                    Console.WriteLine("Hvad vil du foretage dig?");
                    valg = int.Parse(Console.ReadLine());

                }
            } while (rigtigtValg);
            
        }
    }
}
