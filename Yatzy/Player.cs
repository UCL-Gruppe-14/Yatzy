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
        int[] Tur = new int[5];

        private String Navn;
        private int Enere;
        private int Toere;
        private int Treere;
        private int Firere;
        private int Femmere;
        private int Seksere;
        //private int Sum = Enere + Toere + Treere + Firere + Femmere + Seksere;
        private int Bonus;
        private int etPar;
        private int toPar;
        private int treEns;
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
            r1 = r.Next(1, 6);
            r2 = r.Next(1, 6);
            r3 = r.Next(1, 6);
            r4 = r.Next(1, 6);
            r5 = r.Next(1, 6);
            Tur[0] = r1;
            Tur[1] = r2;
            Tur[2] = r3;
            Tur[3] = r4;
            Tur[4] = r5;
        }
        public void Slag()
        {
            for(int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Terningerul: " + Tur[i]);
            }
        }



    }
}
