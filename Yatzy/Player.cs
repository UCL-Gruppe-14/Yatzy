using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

        Random r = new Random(); //instantiating the random method, that allows to roll a random number

        int[] Tur = new int[6];

        public bool tildelt = false;

        public String Navn;
        public int Enere, Toere, Treere, Firere, Femmere, Seksere, Sum, Bonus, etPar, toPar, treEns, fireEns, lilleStraight, storStraight, Hus, Chance, Yatzy, Total;
        public string s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15;       
        int sum;
        
        public void setName() // "Set" Method that sets name
        {
            Console.Write("Hvad er dit navn: ");
            Navn = Console.ReadLine();
        }
        public void ChangeTur() //For loop that runs through Tur, and rolls the dice
        {
            for (int i = 1; i < Tur.Length; i++)
            {
                Tur[i] = r.Next(1, 7);
            }
        }
        public void Slag() //"Sort" method, that sorts the dice, and prints to terminal
        {
            Array.Sort(Tur);
            Console.WriteLine("[{0} , {1} , {2} , {3} , {4}]", Tur[1], Tur[2], Tur[3], Tur[4], Tur[5]);


        }
        public void Omslag() //User input, that defines the length of a for loop to reroll dices
        {
            int antal = 0;
            Console.Write("Hvor mange terninger vil du rulle om: ");
            antal = int.Parse(Console.ReadLine());
            for (int i = 1; i <= antal; i++)
            {
                Console.WriteLine("Hvilken terning vil du slå om: ");
                int terning = int.Parse(Console.ReadLine());
                Tur[terning] = r.Next(1, 7);
            }

        }
        public void PointEnere() //Method to add up dices with value of 1
        {
            int sum = 0;
            int valg;            
            if (Tur[1] == 1)
                sum++;
            if (Tur[2] == 1)
                sum++;
            if (Tur[3] == 1)
                sum++;
            if (Tur[4] == 1)
                sum++;
            if (Tur[5] == 1)
                sum++;
            if (Enere == 0 && sum > 0 && tildelt == false && s1 != "-")
            {
                Console.WriteLine("Vil du tildele {0} til Enere?\n1: ja\n2: nej", sum);
                valg = int.Parse(Console.ReadLine());
                if (valg == 1)
                {
                    Enere = sum;
                    PointSum();
                    tildelt = true;
                }
            }
        }
        public void PointToere()//Method to add up dices with value of 2
        {
            int sum = 0;
            int valg;
            if (Tur[1] == 2)
                sum = sum + 2;
            if (Tur[2] == 2)
                sum = sum + 2;
            if (Tur[3] == 2)
                sum = sum + 2;
            if (Tur[4] == 2)
                sum = sum + 2;
            if (Tur[5] == 2)
                sum = sum + 2;
            if (Toere == 0 && sum > 0 && tildelt == false && s2 != "-")
            {
                Console.WriteLine("Vil du tildele {0} til Toerne?\n1: ja\n2: nej", sum);
                valg = int.Parse(Console.ReadLine());
                if (valg == 1)
                {
                    Toere = sum;
                    PointSum();
                    tildelt = true;
                }
            }
        }
        public void PointTreere() //Method to add up dices with value of 3
        {
            int sum = 0;
            int valg;
            if (Tur[1] == 3)
                sum = sum + 3;
            if (Tur[2] == 3)
                sum = sum + 3;
            if (Tur[3] == 3)
                sum = sum + 3;
            if (Tur[4] == 3)
                sum = sum + 3;
            if (Tur[5] == 3)
                sum = sum + 3;
            if (Treere == 0 && sum > 0 && tildelt == false && s3 != "-")
            {
                Console.WriteLine("Vil du tildele {0} til Treere?\n1: ja\n2: nej", sum);
                valg = int.Parse(Console.ReadLine());
                if (valg == 1)
                {
                    Treere = sum;
                    PointSum();
                    tildelt = true;
                }
            }
        }
        public void PointFirere()
        {
            int sum = 0;
            int valg;
            if (Tur[1] == 4)
                sum = sum + 4;
            if (Tur[2] == 4)
                sum = sum + 4;
            if (Tur[3] == 4)
                sum = sum + 4;
            if (Tur[4] == 4)
                sum = sum + 4;
            if (Tur[5] == 4)
                sum = sum + 4;
            if (Firere == 0 && sum > 0 && tildelt == false && s4 != "-")
            {

                Console.WriteLine("Vil du tildele {0} til Firere?\n1: ja\n2: nej", sum);
                valg = int.Parse(Console.ReadLine());
                if (valg == 1)
                {
                    Firere = sum;
                    PointSum();
                    tildelt = true;
                }
            }

        }
        public void PointFemmere()
        {
            int sum = 0;
            int valg;
            if (Tur[1] == 5)
                sum = sum + 5;
            if (Tur[2] == 5)
                sum = sum + 5;
            if (Tur[3] == 5)
                sum = sum + 5;
            if (Tur[4] == 5)
                sum = sum + 5;
            if (Tur[5] == 5)
                sum = sum + 5;
            if (Femmere == 0 && sum > 0 && tildelt == false && s5 != "-")
            {

                Console.WriteLine("Vil du tildele {0} til Femmere?\n1: ja\n2: nej", sum);
                valg = int.Parse(Console.ReadLine());
                if (valg == 1)
                {
                    Femmere = sum;
                    PointSum();
                    tildelt = true;
                }
            }
        }
        public void PointSeksere()
        {
            int sum = 0;
            int valg;
            if (Tur[1] == 6)
                sum = sum + 6;
            if (Tur[2] == 6)
                sum = sum + 6;
            if (Tur[3] == 6)
                sum = sum + 6;
            if (Tur[4] == 6)
                sum = sum + 6;
            if (Tur[5] == 6)
                sum = sum + 6;
            if (Seksere == 0 && sum > 0 && tildelt == false && s6 != "-")
            {

                Console.WriteLine("Vil du tildele {0} til Seksere?\n1: ja\n2: nej", sum);
                valg = int.Parse(Console.ReadLine());
                if (valg == 1)
                {
                    Seksere = sum;
                    PointSum();
                    tildelt = true;
                }
            }
        }
        public void PointSum()
        {
            int sum = Enere + Toere + Treere + Firere + Femmere + Seksere;
            PointTotal();
        }
        public void PointBonus()
        {

            if (Sum >= 63)
            {
                Bonus = 50;
                PointTotal();
            }
        }
        public void PointEtPar()
        {
            int valg = 0;
            if (etPar == 0 && (Tur[1] == Tur[2] || Tur[2] == Tur[3] || Tur[3] == Tur[4] || Tur[4] == Tur[5]) && tildelt == false && s7 != "-")
            {
                if (Tur[1] == Tur[2])
                {
                    Console.WriteLine("Vil du tildele 2 {0}'ere?\nTryk 1 for ja\nTryk 2 for nej", Tur[1]);
                    valg = int.Parse(Console.ReadLine());
                    if (valg == 1)
                    {
                        etPar = Tur[1] + Tur[2];
                        PointTotal();
                        tildelt = true;
                    }

                }
                else if (Tur[2] == Tur[3])
                {
                    Console.WriteLine("Vil du tildele 2 {0}'ere?\nTryk 1 for ja\nTryk 2 for nej", Tur[2]);
                    valg = int.Parse(Console.ReadLine());
                    if (valg == 1)
                    {
                        etPar = Tur[2] + Tur[3];
                        PointTotal();
                        tildelt = true;
                    }
                }
                else if (Tur[3] == Tur[4])
                {
                    Console.WriteLine("Vil du tildele 2 {0}'ere?\nTryk 1 for ja\nTryk 2 for nej", Tur[3]);
                    valg = int.Parse(Console.ReadLine());
                    if (valg == 1)
                    {
                        etPar = Tur[3] + Tur[4];
                        PointTotal();
                        tildelt = true;
                    }
                }
                else if (Tur[4] == Tur[5])
                {
                    Console.WriteLine("Vil du tildele 2 {0}'ere?\nTryk 1 for ja\nTryk 2 for nej", Tur[3]);
                    valg = int.Parse(Console.ReadLine());
                    if (valg == 1)
                    {
                        etPar = Tur[4] + Tur[5];
                        PointTotal();
                        tildelt = true;
                    }
                }
            }
        }
        public void PointToPar()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;
            int sum = 0;
            for (int i = 1; i < Tur.Length; i++)
            {
                a++;
                b++;
                c++;
                d++;
                e++;
                f++;
            }
            if (a == 2)
                sum = 1 * 2;
            if (b == 2)
                sum = sum + (2 * 2);
            if (c == 2)
                sum = sum + (3 * 2);
            if (d == 2)
                sum = sum + (4 * 2);
            if (e == 2)
                sum = sum + (5 * 2);
            if (f == 2)
                sum = sum + (6 * 2);
            toPar = sum;
            PointTotal();
            tildelt = true;
        }
        public void PointTreEns()
        {
            if (treEns == 0 && ((Tur[1] == Tur[2] && Tur[2] == Tur[3]) || (Tur[3] == Tur[4] && Tur[4] == Tur[5])) && tildelt == false && s9 != "-")
            {
                Console.WriteLine("Vil du tildele tre ens?\nTryk 1 for ja\nTryk 2 for nej");
                int valg = int.Parse(Console.ReadLine());
                if (valg == 1 && (Tur[1] == Tur[2] && Tur[2] == Tur[3]))
                {
                    treEns = Tur[1] + Tur[2] + Tur[3];
                    PointTotal();
                    tildelt = true;
                }
                else if (valg == 1)
                {
                    treEns = Tur[3] + Tur[4] + Tur[5];
                    PointTotal();
                    tildelt = true;
                }
            }
        }
        public void PointFireEns()
        {
            int antal = 0;
            int værdi = 0;
            for (int i = 1; i < Tur.Length; i++)
            {
                if (Tur[i] == 1)
                {
                    antal++;
                    værdi = 1;
                }
                if (Tur[i] == 2 && antal < 4)
                {
                    antal++;
                    værdi = 2;
                }
                if (Tur[i] == 3 && antal < 4)
                {
                    antal++;
                    værdi = 3;
                }
                if (Tur[i] == 4 && antal < 4)
                {
                    antal++;
                    værdi = 4;
                }
                if (Tur[i] == 5 && antal < 4)
                {
                    antal++;
                    værdi = 5;
                }
                if (Tur[i] == 6 && antal < 4)
                {
                    antal++;
                    værdi = 6;
                }
            }
            if (fireEns == 0 && antal == 4 && tildelt == false && s10 != "-")
            {
                fireEns = antal * værdi;
                PointTotal();
                tildelt = true;
            }
        }
        public void PointLilleStraight()
        {
            if (lilleStraight == 0 && (Tur[1] == 1 && Tur[2] == 2 && Tur[3] == 3 && Tur[4] == 4 && Tur[5] == 5) && tildelt == false && s11 != "-")
            {
                Console.WriteLine("Vil du tildele 15 point til Lille Straight?\nTryk 1 for ja\nTryk 2 for nej");
                int valg = int.Parse(Console.ReadLine());
                if (valg == 1)
                {
                    lilleStraight = 15;
                    PointTotal();
                    tildelt = true;
                }
            }
        }
        public void PointStorStraight()
        {
            if (storStraight == 0 && (Tur[1] == 2 && Tur[2] == 3 && Tur[3] == 4 && Tur[4] == 5 && Tur[5] == 6) && tildelt == false && s12 != "-")
            {
                int valg;
                Console.WriteLine("Vil du tildele 20 points til Store Straight?\nTryk 1 for ja\nTryk 2 for nej");
                valg = int.Parse(Console.ReadLine());
                if (valg == 1)
                {
                    storStraight = 20;
                    PointTotal();
                    tildelt = true;
                }
            }
        }
        public void PointHus()
        {
            if (Hus == 0 && (Tur[1] == Tur[2] && Tur[2] == Tur[3] && Tur[4] == Tur[5] && Tur[3] != Tur[4]) && tildelt == false && s13 != "-")
            {
                sum = Tur[1] + Tur[2] + Tur[3] + Tur[4] + Tur[5];
                Console.WriteLine("Vil du tildele {0} til Hus?\nTryk 1 for ja\nTryk 2 for nej", sum);
                int valg = int.Parse(Console.ReadLine());
                if (valg == 1)
                {
                    Hus = Tur[1] + Tur[2] + Tur[3] + Tur[4] + Tur[5];
                    PointTotal();
                    tildelt = true;
                }
            }
            else if (Hus == 0 && (Tur[1] == Tur[2] && Tur[3] == Tur[4] && Tur[4] == Tur[5] && Tur[2] != Tur[3]) && tildelt == false && s13 != "-")
            {
                sum = Tur[1] + Tur[2] + Tur[3] + Tur[4] + Tur[5];
                Console.WriteLine("Vil du tildele {0} til Hus?\nTryk 1 for ja\nTryk 2 for nej", sum);
                int valg = int.Parse(Console.ReadLine());
                if (valg == 1)
                {
                    Hus = Tur[1] + Tur[2] + Tur[3] + Tur[4] + Tur[5];
                    PointTotal();
                    tildelt = true;
                }
            }
        }
        public void PointChance()
        {
            if (Chance == 0 && tildelt == false)
            {
                Console.WriteLine("Vil du bruge chancen?\nTryk 1 for ja\n Tryk 2 for nej");
                int valg = int.Parse(Console.ReadLine());
                if (valg == 1)
                {
                    Chance = Tur[1] + Tur[2] + Tur[3] + Tur[4] + Tur[5];
                    PointTotal();
                    tildelt = true;
                }
            }
        }
        public void PointYatzy()
        {
            if (Yatzy == 0 && Tur[1] == Tur[2] && Tur[2] == Tur[3] && Tur[3] == Tur[4] && Tur[4] == Tur[5] && tildelt == false && s14 != "-")
            {
                Console.WriteLine("Vil du tildele Yatzy?\nTryk 1 for ja\nTryk 2 for nej");
                int valg = int.Parse(Console.ReadLine());
                if (valg == 1)
                {
                    Yatzy = Tur[1] + Tur[2] + Tur[3] + Tur[4] + Tur[5];
                    PointTotal();
                    tildelt = true;
                }
            }
        }
        public int PointTotal() => Total = Sum + Bonus + etPar + toPar + treEns + fireEns + lilleStraight + storStraight + Hus + Chance + Yatzy;
        public void PointTavle()
        {
            Console.WriteLine("Spiller:        " + Navn);
            Console.WriteLine("-------------------");
            Console.Write("Enere:          ");
            if (s1 == "-")
                Console.WriteLine(s1);
            else
                Console.WriteLine(Enere);
            Console.Write("Toere:          ");
            if (s2 == "-")
                Console.WriteLine(s2);
            else
                Console.WriteLine(Toere);
            Console.Write("Treere:         ");
            if (s3 == "-")
                Console.WriteLine(s3);
            else
                Console.WriteLine(Treere);
            Console.Write("Firere:         ");
            if (s4 == "-")
                Console.WriteLine(s4);
            else
                Console.WriteLine(Firere);
            Console.Write("Femmere:        ");
            if (s5 == "-")
                Console.WriteLine(s5);
            else
                Console.WriteLine(Femmere);
            Console.Write("Seksere:        ");
            if (s6 == "-")
                Console.WriteLine(s6);
            else
                Console.WriteLine(Seksere);
            Console.WriteLine("Sum             " + Sum);
            Console.WriteLine("Bonus           " + Bonus);
            Console.Write("Et Par:         ");
            if (s7 == "-")
                Console.WriteLine(s7);
            else
                Console.WriteLine(etPar);
            Console.Write("To Par:         ");
            if (s8 == "-")
                Console.WriteLine(s8);
            else
                Console.WriteLine(toPar);
            Console.Write("Tre Ens:        ");
            if (s9 == "-")
                Console.WriteLine();
            else
                Console.WriteLine(treEns);
            Console.Write("Fire Ens:       ");
            if (s10 == "-")
                Console.WriteLine(s10);
            else
                Console.WriteLine(fireEns);
            Console.Write("LilleStraight:  " + s11);
            if (s11 == "-")
                Console.WriteLine(s11);
            else
                Console.WriteLine(lilleStraight);
            Console.Write("StorStraight:   ");
            if (s12 == "-")
                Console.WriteLine(s12);
            else
                Console.WriteLine(storStraight);
            Console.Write("Hus:            ");
            if (s13 == "-")
                Console.WriteLine(s13);
            else
                Console.WriteLine(Hus);
            Console.Write("Chance:         ");
            if (s14 == "-")
                Console.WriteLine(s14);
            else
                Console.WriteLine(Chance);
            Console.Write("Yatzy:          ");
            if (s15 == "-")
                Console.WriteLine(s15);
            else
                Console.WriteLine(Yatzy);
            Console.WriteLine("Total:          " + Total);
        }
        public void Point()
        {
            int valg;
            Console.WriteLine("Hvad vil du tildele point til?");
            Console.Write("1. Enere \n2. Toere \n3. Treere \n4. Firere \n5. Femmere \n6. Seksere \n7. Et Par \n8. To Par \n9. Tre Ens \n10. Fire Ens \n11. Lille Straight" +
                "\n12. Stor Straight \n13. Hus \n14. Chance \n15. Yatzy \n16. Stryg en\nVælg 1-16: ");
            valg = int.Parse(Console.ReadLine());
            tildelt = false;
            switch (valg)
            {
                case 1: //Enere
                    PointEnere();
                    break;
                case 2: //Toere
                    PointToere();
                    break;
                case 3: //Treere
                    PointTreere();
                    break;
                case 4: //Firere
                    PointFirere();
                    break;
                case 5: //Femmere
                    PointFemmere();
                    break;
                case 6: //Seksere
                    PointSeksere();
                    break;
                case 7: //Et par
                    PointEtPar();
                    break;
                case 8: //
                    PointToPar();
                    break;
                case 9:
                    PointTreEns();
                    break;
                case 10:
                    PointFireEns();
                    break;
                case 11:
                    PointLilleStraight();
                    break;
                case 12:
                    PointStorStraight();
                    break;
                case 13:
                    PointHus();
                    break;
                case 14:
                    PointChance();
                    break;
                case 15:
                    PointYatzy();
                    break;
                case 16:
                    Stryge();
                    break;
            }
        }
        public void Stryge() //Method to allow player to cross-out a point
        {
            Console.WriteLine("Hvad vil du stryge?");
            Console.WriteLine("1: Enere");
            Console.WriteLine("2: Toere");
            Console.WriteLine("3: Treere");
            Console.WriteLine("4: Firere");
            Console.WriteLine("5: Femmere");
            Console.WriteLine("6: Seksere");
            Console.WriteLine("7: Et par");
            Console.WriteLine("8: To par");
            Console.WriteLine("9: Tre ens");
            Console.WriteLine("10: Fire ens");
            Console.WriteLine("11: Lille straight");
            Console.WriteLine("12: Stor straight");
            Console.WriteLine("13: Hus");
            Console.WriteLine("14: Chancen");
            Console.WriteLine("15: Yatzy");
            Console.Write("Valg: ");
            int valg = int.Parse(Console.ReadLine());
            if (valg == 1 && (Enere == 0 || s1 == "-") && tildelt == false) //Enere
            {
                s1 = "-";
                tildelt = true;
            }
            if (valg == 2 && (Toere == 0 || s2 == "-") && tildelt == false) //Toere
            {
                s2 = "-";
                tildelt = true;
            }
            if (valg == 3 && (Treere == 0 || s3 == "-") && tildelt == false) //Treere
            {
                s3 = "-";
                tildelt = true;
            }
            if (valg == 4 && (Firere == 0 || s4 == "-") && tildelt == false) //Firere
            {
                s4 = "-";
                tildelt = true;
            }
            if (valg == 5 && (Femmere == 0 || s5 == "-") && tildelt == false) //Femmere
            {
                s5 = "-";
                tildelt = true;
            }
            if (valg == 6 && (Seksere == 0 || s6 == "-") && tildelt == false) //Seksere
            {
                s6 = "-";
                tildelt = true;
            }
            if (valg == 7 && (etPar == 0 || s7 == "-") && tildelt == false) //Et par
            {
                s7 = "-";
                tildelt = true;
            }
            if (valg == 8 && (toPar == 0 || s8 == "-") && tildelt == false) //To par
            {
                s8 = "-";
                tildelt = true;
            }
            if (valg == 9 && (treEns == 0 || s9 == "-") && tildelt == false) //Tre ens
            {
                s9 = "-";
                tildelt = true;
            }
            if (valg == 10 && (fireEns == 0 || s10 == "-") && tildelt == false) //Fire ens
            {
                s10 = "-";
                tildelt = true;
            }
            if (valg == 11 && (lilleStraight == 0 || s11 == "-") && tildelt == false) //Lille Straight
            {
                s11 = "-";
                tildelt = true;
            }
            if (valg == 12 && (storStraight == 0 || s12 == "-") && tildelt == false) //Stor Straight
            {
                s12 = "-";
                tildelt = true;
            }
            if (valg == 13 && (Hus == 0 || s13 == "-") && tildelt == false) //Hus
            {
                s13 = "-";
                tildelt = true;
            }
            if (valg == 14 && (Chance == 0 || s14 == "-") && tildelt == false) //Chance
            {
                s14 = "-";
                tildelt = true;
            }
            if (valg == 15 && (Yatzy == 0 || s15 == "-") && tildelt == false) //Yatzy
            {
                s15 = "-";
                tildelt = true;
            }
        }
    }
}
