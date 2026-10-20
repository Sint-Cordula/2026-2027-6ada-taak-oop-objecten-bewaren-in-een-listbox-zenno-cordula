using System;
using System.Collections.Generic;
using System.Text;

namespace Boodschap
{
    internal class Boodschap
    {
        //properties
        public int Aantal { get; set; }
        public string Productnaam { get; set; }

        //methodes
        public Boodschap()
        {

        }

        public Boodschap(string strProdNaam, int intProdAantal)
        {
            Aantal = intProdAantal;
            Productnaam = strProdNaam;
        }

        public override string ToString()
        {
            return $"{Aantal} - {Productnaam}";
        }
    }
}
