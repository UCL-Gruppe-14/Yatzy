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
    internal class Player
    {
        String Navn;
        int Enere;
        int Toere;
        int Treere;
        int Firere;
        int Femmere;
        int Seksere;
        int Sum = Enere + Toere + Treere + Firere + Femmere + Seksere;
        int Bonus;
        int etPar;
        int toPar;
        int treEns;
        int fireEns;
        int lilleStraight;
        int storStraight;
        int Hus;
        int Chance;
        int Yatzy;
        int Total = Sum + Bonus + etPar + toPar + treEns + fireEns + lilleStraight + storStraight + Hus + Chance + Yatzy;
    }
}
