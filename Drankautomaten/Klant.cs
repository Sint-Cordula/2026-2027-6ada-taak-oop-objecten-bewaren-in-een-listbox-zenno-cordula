using System;
using System.Collections.Generic;
using System.Text;

namespace Drankautomaten
{
    internal class Klant
    {
        //property
        public string NaamKlant { get; set; }

        //field
        private List<Automaat> Automaten;

        //constructor
        public Klant(string naam)
        {
            NaamKlant = naam;
        }

        //methodes
        public List<Automaat> GetAutomaten

    }
}
