using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy
{
    public class Player
    {
        public String Navn;
        public int Enere;
        public int Toere;
        public int Treere;
        public int Firere;
        public int Femmere;
        public int Seksere;
        public int Sum = Enere + Toere + Treere + Firere + Femmere + Seksere;
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
        public int Total = Sum + Bonus + etPar + toPar + treEns + fireEns + lilleStraight + storStraight + Hus + Chance + Yatzy;

        
    }
}
