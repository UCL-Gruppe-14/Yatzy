using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy
{
    internal class Test
    {

        static int SumOfNumberOfEyes(int eyes, int t1, int t2, int t3, int t4, int t5)
        {
            int r = 0;
            if (eyes == t1) r++;
            if (eyes == t2) r++;
            if (eyes == t3) r++;
            if (eyes == t4) r++;
            if (eyes == t5) r++;
            return r;
        }


        static void rull()
        {
            Random r = new Random();

            for (int i = 0; i < 100000; i++)
            {

                int sum1 = 0;
                int sum2 = 0;
                int sum3 = 0;
                int sum4 = 0;
                int sum5 = 0;
                int sum6 = 0;
                int terning1 = r.Next(1, 7);
                int terning2 = r.Next(1, 7);
                int terning3 = r.Next(1, 7);
                int terning4 = r.Next(1, 7);
                int terning5 = r.Next(1, 7);

                // Beregner antallet af 1'ere

                //if (terning1 == 1)
                //{
                //    sum1++;
                //}
                //if (terning2 == 1)
                //{
                //    sum1++;
                //}
                //if (terning3 == 1)
                //{
                //    sum1++;
                //}
                //if (terning4 == 1)
                //{
                //    sum1++;
                //}

                //if (terning5 == 1)
                //{
                //    sum1++;
                //}

                //// Beregner antallet af 2'ere

                //if (terning1 == 2)
                //{
                //    sum2++;
                //}
                //if (terning2 == 2)
                //{
                //    sum2++;
                //}
                //if (terning3 == 2)
                //{
                //    sum2++;
                //}
                //if (terning4 == 2)
                //{
                //    sum2++;
                //}

                //if (terning5 == 2)
                //{
                //    sum2++;
                //}


                sum1 = SumOfNumberOfEyes(1, terning1, terning2, terning3, terning4, terning5);
                sum2 = SumOfNumberOfEyes(2, terning1, terning2, terning3, terning4, terning5);
                sum3 = SumOfNumberOfEyes(3, terning1, terning2, terning3, terning4, terning5);
                sum4 = SumOfNumberOfEyes(4, terning1, terning2, terning3, terning4, terning5);
                sum5 = SumOfNumberOfEyes(5, terning1, terning2, terning3, terning4, terning5);
                sum6 = SumOfNumberOfEyes(6, terning1, terning2, terning3, terning4, terning5);

                // Kombinationer (Regler)

                // Lillehus :-)

                if ((sum1 == 1) && (sum2 == 1) && (sum3 == 1) && (sum4 == 1) && (sum5 == 1))
                {
                    Console.WriteLine("Lille Stright");
                }

                if ((sum2 == 1) && (sum3 == 1) && (sum4 == 1) && (sum5 == 1) && (sum6 == 1))
                {
                    Console.WriteLine("Store Stright");
                }

                if ((sum1 == 5) || (sum2 == 5) || (sum3 == 5) || (sum4 == 5) || (sum5 == 5) || (sum6 == 5))
                {
                    Console.WriteLine("Yatzy");
                    Console.ReadLine();
                }

                Console.WriteLine("[" + terning1 + "," + terning2 + "," + terning3 + "," + terning4 + "," + terning5 + "]");







                // Console.ReadLine();
            }
        }
    }
}
