using System;
using System.Collections.Generic;
using System.Text;

namespace Bankrekening
{
    internal class Bankrekening
    {
        public double Saldo { get; private set; }
        public string VolledigeNaam { get; }

        public Bankrekening(string VN, string FN)
        {
            VolledigeNaam = $"{VN} {FN}";
            Saldo = 0;
        }

        public override string ToString()
        {
            return VolledigeNaam;
        }

        public double VerhoogSaldo(double bedrag)
        {
            if (bedrag > 0)
            {
                Saldo += bedrag;
            }
            return Saldo;

        }

        public double VerlaagSaldo(double bedrag)
        {
            if (bedrag > 0 && bedrag <= Saldo)
            {
                Saldo -= bedrag;
            }
            return Saldo;
        }
    }
}
