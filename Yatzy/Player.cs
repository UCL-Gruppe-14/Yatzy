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

        int[] Tur = new int[6];

        public String Navn;
        public int Enere = 0;
        public int Toere = 0;
        public int Treere = 0;
        public int Firere = 0;
        public int Femmere = 0;
        public int Seksere = 0;
        public int Sum;
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
            Tur[0] = 0;
            Tur[1] = r.Next(1, 7);
            Tur[2] = r.Next(1, 7);
            Tur[3] = r.Next(1, 7);
            Tur[4] = r.Next(1, 7);
            Tur[5] = r.Next(1, 7);
        }
        public void Slag()
        {
            Console.WriteLine("[{0} , {1} , {2} , {3} , {4}]", Tur[1], Tur[2], Tur[3], Tur[4], Tur[5]);
        }
        public void Omslag()
        {
            int antal;
            Console.Write("Hvor mange terninger vil du rulle om: ");
            antal = int.Parse(Console.ReadLine());
            for (int i = 1; i <= antal; i++)
            {
                Console.WriteLine("Hvilken terning vil du slå om: ");
                int terning = int.Parse(Console.ReadLine());
                Tur[terning] = r.Next(1, 7);
            }
            
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
                if (valg == 1)
                {
                    Enere = sum;
                    PointSum();
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
                    sum = sum + 2;
                else if (Tur[2] == 2)
                    sum = sum + 2;
                else if (Tur[3] == 2)
                    sum = sum + 2;
                else if (Tur[4] == 2)
                    sum = sum + 2;
                else if (Tur[5] == 2)
                    sum = sum + 2; 
                Console.WriteLine("Vil du tildele {0} til Toerne?\n1: ja\n2: nej", sum);
                valg = int.Parse(Console.ReadLine());
                if (valg == 1)
                {
                    Toere = sum;
                    PointSum();
                }
            }
        }
        public void PointTreere()
        {
            int sum = 0;
            int valg;
            if (Treere == 0)
            {
                if (Tur[1] == 3)
                    sum = sum + 3;
                else if (Tur[2] == 3)
                    sum = sum + 3;
                else if (Tur[3] == 3)
                    sum = sum + 3;
                else if (Tur[4] == 3)
                    sum = sum + 3;
                else if (Tur[5] == 3)
                    sum = sum + 3; 
                Console.WriteLine("Vil du tildele {0} til Treere?\n1: ja\n2: nej", sum);
                valg = int.Parse(Console.ReadLine());
                if (valg == 1)
                {
                    Treere = sum;
                    PointSum();
                }
            }
        }
        public void PointFirere()
        {
            int sum = 0;
            int valg;
            if (Firere == 0)
            {
                if (Tur[1] == 4)
                    sum = sum + 4;
                else if (Tur[2] == 4)
                    sum = sum + 4;
                else if (Tur[3] == 4)
                    sum = sum + 4;
                else if (Tur[4] == 4)
                    sum = sum + 4;
                else if (Tur[5] == 4)
                    sum = sum + 4; 
                Console.WriteLine("Vil du tildele {0} til Firere?\n1: ja\n2: nej", sum);
                valg = int.Parse(Console.ReadLine());
                if (valg == 1)
                { 
                    Firere = sum;
                    PointSum();
                }
            }
            
        }
        public void PointFemmere()
        {
            int sum = 0;
            int valg;
            if (Femmere == 0) 
            {
                if (Tur[1] == 5)
                    sum = sum + 5;
                else if (Tur[2] == 5)
                    sum = sum + 5;
                else if (Tur[3] == 5)
                    sum = sum + 5;
                else if (Tur[4] == 5)
                    sum = sum + 5;
                else if (Tur[5] == 5)
                    sum = sum + 5; 
                Console.WriteLine("Vil du tildele {0} til Femmere?\n1: ja\n2: nej", sum);
                valg = int.Parse(Console.ReadLine());
                if (valg == 1)
                {
                    Femmere = sum;
                    PointSum();
                }
            }
        }
        public void PointSeksere()
        {
            int sum = 0;
            int valg;
            if(Seksere == 0) 
            {
                if (Tur[1] == 6)
                    sum = sum + 6;
                else if (Tur[2] == 6)
                    sum = sum + 6;
                else if (Tur[3] == 6)
                    sum = sum + 6;
                else if (Tur[4] == 6)
                    sum = sum + 6;
                else if (Tur[5] == 6)
                    sum = sum + 6; 
                Console.WriteLine("Vil du tildele {0} til Seksere?\n1: ja\n2: nej", sum);
                valg = int.Parse(Console.ReadLine());
                if (valg == 1) 
                {
                    Seksere = sum;
                    PointSum();
                }
            }
        }
        public void PointSum()
        {
            int sum = Enere + Toere + Treere + Firere + Femmere + Seksere;
            //PointTotal();
        }

        public void PointBonus()
        {
            
            if (Sum >= 63)
            {
                Bonus = 50;
                //PointTotal();
            }
        }
        public void PointEtPar() 
        {
            if(etPar == 0)
            {

            }
        }
        
        /*public void PointTotal()
        {

            Total = Sum + Bonus + etPar + toPar + treEns + fireEns + lilleStraight + storStraight + Hus + Chance + Yatzy;
        }*/
        //public int Bonus;
       // public int etPar;
        //public int toPar;
        //public int treEns;
        //public int fireEns;
        //public int lilleStraight;
        //public int storStraight;
        //public int Hus;
        //public int Chance;
        //public int Yatzy;
    }     
}
