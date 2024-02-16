namespace Yatzy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int t1, t2, t3, t4, t5;
            
            for (int i = 0; i <= 10; i++)
            {
                t1 = r.Next(1, 6);
                t2 = r.Next(1, 6);
                t3 = r.Next(1, 6);
                t4 = r.Next(1, 6);
                t5 = r.Next(1, 6);
                Console.WriteLine("Terningen ruller, og bliver: {0} {1} {2} {3} {4}", t1, t2, t3, t4, t5);
            }
            
        }
    }
}
