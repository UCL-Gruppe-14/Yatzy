using System.Xml.Schema;

namespace Yatzy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int t1, t2, t3, t4, t5;
            int valg;
            int terning;

            t1 = r.Next(1, 6);
            t2 = r.Next(1, 6);
            t3 = r.Next(1, 6);
            t4 = r.Next(1, 6);
            t5 = r.Next(1, 6);
            for (int i = 0; i <= 3; i++)
            {                
                Console.WriteLine("Terningen ruller, og bliver: {0} {1} {2} {3} {4}", t1, t2, t3, t4, t5);
                Console.WriteLine("Hvad vil du foretage dig?");
                valg = int.Parse(Console.ReadLine());
                
            }            
        }
    }
}
