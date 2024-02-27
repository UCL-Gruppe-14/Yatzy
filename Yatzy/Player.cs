using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy
{
    internal class Player
    {

        Random r = new Random();

        int r1, r2, r3, r4, r5;
        int[] Tur = new int[6];
        int sum1, sum2, sum3, sum4, sum5;
        

        public String Navn;
        public int Enere;
        public int Toere;
        public int Treere;
        public int Firere;
        public int Femmere;
        public int Seksere;
        //public int Sum = (1, Enere, Toere, Treere, Firere, Femmere, Seksere);
        public int Bonus;
        public int etPar;
        public int toPar;
        public int treEns;
        public int fireEns;
        public int lilleStraight;
        public int storStraight;
        public int Hus;
        public int Chance;
        public int Yatzy;
        //public int Total = Sum + Bonus + etPar + toPar + treEns + fireEns + lilleStraight + storStraight + Hus + Chance + Yatzy;

        public void setName()
        {
            Console.WriteLine("Hvad er dit navn: ");
            Navn = Console.ReadLine();
        }
        public void ChangeTur()
        {
            r1 = r.Next(1, 7);
            r2 = r.Next(1, 7);
            r3 = r.Next(1, 7);
            r4 = r.Next(1, 7);
            r5 = r.Next(1, 7);
            Tur[0] = 0;
            Tur[1] = r1;
            Tur[2] = r2;
            Tur[3] = r3;
            Tur[4] = r4;
            Tur[5] = r5;
        }
        public void Slag()
        {
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Terningerul: " + Tur[i]);
            }
        }
        public void Omslag()
        {
            Console.WriteLine("Hvilken terning vil du slå om: ");
            int terning = int.Parse(Console.ReadLine());
            Tur[terning] = r.Next(1, 7);
        }
        public void PointEnere()
        {
            int sum = 0;
            int valg;
            if (Enere == 0)
            {
                if (Tur[1] == 1)
                    sum++;
                else if (Tur[2] == 1)
                    sum++;
                else if (Tur[3] == 1)
                    sum++;
                else if (Tur[4] == 1)
                    sum++;
                else if (Tur[5] == 1)
                    sum++;
                Console.WriteLine("Vil du tildele {0} til Enere?\n1: ja\n2: nej", sum);
                valg = int.Parse(Console.ReadLine());
                if(valg == 1)
                {
                    Enere = sum;
                }
            }            
        }
        public void PointToere()
        {
            int sum = 0;
            int valg;
            if (Toere == 0)
            {
                if (Tur[1] == 2)
                    sum++;
                else if (Tur[2] == 2)
                    sum++;
                else if (Tur[3] == 2)
                    sum++;
                else if (Tur[4] == 2)
                    sum++;
                else if (Tur[5] == 2)
                    sum++;
                Console.WriteLine("Vil du tildele {0} til Toerne?\n1: ja\n2: nej", sum);
                valg = int.Parse(Console.ReadLine());
                if (valg == 1)
                {
                    Toere = sum;
                }
            }
            public void PointTreere()
            {
                int sum = 0;
                int valg;
                if (Treere == 0)
                {
                    if (Tur[1] == 3)
                        sum++;
                    else if (Tur[2] == 3)
                        sum++;
                    else if (Tur[3] == 3)
                        sum++;
                    else if (Tur[4] == 3)
                        sum++;
                    else if (Tur[5] == 3)
                        sum++;
                    Console.WriteLine("Vil du tildele {0} til Teere?\n1: ja\n2: nej", sum);
                    valg = int.Parse(Console.ReadLine());
                    if (valg == 1)
                    {
                        Treere = sum;
                    }
                }


            }
}
