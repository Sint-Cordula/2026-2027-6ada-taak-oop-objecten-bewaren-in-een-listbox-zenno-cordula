using System;
using System.Collections.Generic;
using System.Text;

namespace Bankrekening
{
    internal class Bankrekening
    {
        private double saldo;
        private string volledigeNaam;

        public double Saldo
        {
            get { return saldo; }
        }
        public string VolledigeNaam
        {
            get { return volledigeNaam; }
        }

        public Bankrekening()
        {

        }
        public Bankrekening(string VN, string FN)
        {
            volledigeNaam = $"{VN} {FN}";
            saldo = 0;
        }

        public override string ToString()
        {
            return VolledigeNaam;
        }

        public double VerhoogSaldo(double bedrag)
        {
            if (bedrag > 0)
            {
                saldo += bedrag;
            }
            return saldo;

        }

        public double VerlaagSaldo(double bedrag)
        {
            if (bedrag > 0 && bedrag <= Saldo)
            {
                saldo -= bedrag;
            }
            return saldo;
        }
    }
}
