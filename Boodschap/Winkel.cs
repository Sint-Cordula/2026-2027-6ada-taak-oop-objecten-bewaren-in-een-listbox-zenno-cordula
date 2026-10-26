using System;
using System.Collections.Generic;
using System.Text;

namespace Boodschap
{
    internal class Winkel
    {
        public string WinkelNaam { get; set; }

        //In de klasse winkel maken we een list (array) aan die boodschappen (objecten) kan bevatten.
        //Deze List zorgt ervoor dat er een relatie bestaat tussen de klassen winkel en boodschap.
        private List<Boodschap> boodschappenLijst = new List<Boodschap>();

        //Deze methode geeft heel de List met boodschappen terug
        public List<Boodschap> GetBoodschappenLijst()
        {
            return boodschappenLijst;
        }

        //De methode GetBoodschap geeft op basis van een index één Boodschap terug
        public Boodschap GetBoodschap(int intIndex)
        {
            if (intIndex >= 0 && intIndex < boodschappenLijst.Count)
            {
                return boodschappenLijst[intIndex];
            }
            else
            {
                return null;
            }
        }

        public void VoegBoodschapToe(string naamProduct, int aantal)
        {
            Boodschap objBoodschap = new Boodschap(naamProduct, aantal);
            boodschappenLijst.Add(objBoodschap);
        }

        public void VerwijderBoodschap(int intIndex)
        {
            if (intIndex >= 0 && intIndex < boodschappenLijst.Count)
            {
                boodschappenLijst.RemoveAt(intIndex);
            }
        }





    }
}
