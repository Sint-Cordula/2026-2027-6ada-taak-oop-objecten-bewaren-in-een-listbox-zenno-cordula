using System;
using System.Collections.Generic;
using System.Text;

namespace Drankautomaten
{
    internal class Klant
    {
        //field
        private List<Automaat> Automaten = new List<Automaat>();

        //property
        public string NaamKlant { get; set; }

        //constructor
        public Klant(string naam)
        {
            NaamKlant = naam;
        }

        //methodes
        public override string ToString()
        {
            return NaamKlant;
        }

        public List<Automaat> GetAutomaten()
        {
            return Automaten;
        }

        public void VoegAutomaatToe(string naamAutomaat)
        {
            Automaat objAutomaat = new Automaat(naamAutomaat);
            Automaten.Add(objAutomaat);
        }
    }
}
