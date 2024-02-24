using System.Xml.Schema;

namespace Yatzy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random q = new Random();
            Player p1 = new Player();
            Player p2 = new Player();
            Player p3 = new Player();
            int antalSpillere;
            int t1, t2, t3, t4, t5;
            int valg;
            int terning;
            bool rigtigtValg = true;

            t1 = q.Next(1, 6);

            p1.ChangeTur();
            p1.Slag();


            
            
            do
            {
                Console.WriteLine("Velkommen til YATZY\nSpillet der samler og knækker familier og venskaber!");
                Console.Write("Vælg antal spillere: ");
                antalSpillere = int.Parse(Console.ReadLine());
                int antalSpiller= Convert.ToInt32(Console.ReadLine());     
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
                }

                Console.WriteLine("{0}'s tur");
                for (int i = 0; i <= 3; i++)
                {
                    Console.WriteLine("Terningen ruller, og bliver: {0}, {1}, {2}, {3}, {4}", t1);
                    Console.WriteLine("Hvad vil du foretage dig?");
                    valg = int.Parse(Console.ReadLine());

                }
            } while (rigtigtValg);
            
        }
    }
}
