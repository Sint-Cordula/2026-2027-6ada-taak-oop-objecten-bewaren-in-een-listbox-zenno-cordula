using System;
using System.Collections.Generic;
using System.Text;

namespace Steam_Calculator
{
    internal class Calculator
    {
        public double Uren { get; private set; }
        public double Prijs { get; private set; }
        public string NaamGame { get; }

        public Calculator(double uren, double prijs, string naam)
        {
            NaamGame = naam;
            Prijs = prijs;
            Uren = uren;
        }
        public override string ToString()
        {
            return NaamGame;
        }

        public double VerbruikPerUur()
        {
            double resultaat = 0;
            resultaat = Prijs / Uren;
            return resultaat;
        }
    }
}
