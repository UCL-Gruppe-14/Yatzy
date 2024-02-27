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
            int antalSpiller= Convert.ToInt32(Console.ReadLine());
            /*switch (antalSpillere)
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

            p1.setName();
            do
            {
                Console.WriteLine("{0}'s tur", p1.Navn);
                //Pointtavle();
                p1.ChangeTur();
                p1.Slag(); ;
                for (int i = 0; i <= 2; i++)
                {
                    p1.Omslag();
                    p1.Slag();

                }
            } while (rigtigtValg);

        }    
    }
}
