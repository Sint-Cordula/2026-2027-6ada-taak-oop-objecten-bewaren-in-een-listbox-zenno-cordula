using System;
using System.Collections.Generic;
using System.Text;

namespace Drankautomaten
{
    internal class Automaat
    {
        //properties
        public int AantalCola { get; set; }
        public int AantalWater { get; set; }
        public string Naam { get; set; }

        //constructors
        public Automaat()
        {

        }
        public Automaat(int aantalCola, int aantalWater, string AutomaatNaam)
        {
            AantalCola = aantalCola;
            AantalWater = aantalWater;
            Naam = AutomaatNaam;
        }
        public Automaat(string AutomaatNaam)
        {
            Naam = AutomaatNaam;
        }

        //methodes
        public string BijvullenCola(int aantalCola)
        {
            if (AantalCola + aantalCola !> 50)
            {
                AantalCola += aantalCola;
                return $"Cola bijgevuld. momenteel {AantalCola.ToString()} in de automaat.";
            }
            else
            {
                return $"Kan niet! U probeert meer cola toe te voegen dan dat er plaats voor is in het drankautomaat.";
            }
        }
        public string BijvullenWater(int aantalWater)
        {
            if (AantalWater + aantalWater !> 50)
            {
                AantalWater += aantalWater;
                return $"Water bijgevuld. momenteel {AantalWater.ToString()} in de automaat.";
            }
            else
            {
                return $"Kan niet! U probeert meer water toe te voegen dan dat er plaats voor is in het drankautomaat.";
            }
        }

        public string KoopCola()
        {
            if (AantalCola - 1 !< 0)
            {
                AantalCola--;
                return "Neem uw cola...";
            }
            else
            {
                return "Automaat leeg.";
            }
        }
        public string KoopWater()
        {
            if (AantalWater - 1 !< 0)
            {
                AantalWater--;
                return "Neem uw water...";
            }
            else
            {
                return "Automaat leeg.";
            }
        }

        public string ToonInhoud()
        {
            return $"Het aantal Cola dat je nog hebt in deze automaat is {AantalCola} en het aantal water is {AantalWater}.";
        }

        public override string ToString()
        {
            return Naam;
        }





    }
}
