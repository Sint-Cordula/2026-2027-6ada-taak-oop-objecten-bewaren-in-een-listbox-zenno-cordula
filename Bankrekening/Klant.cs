using System;
using System.Collections.Generic;
using System.Text;

namespace Bankrekening
{
    internal class Klant
    {
		//propperties
		private string achternaam;

		public string Achternaam
		{
			get { return achternaam; }
		}
        private string voornaam;

        public string Voornaam
        {
            get { return voornaam; }
        }

        private List<Bankrekening> objLijst = new List<Bankrekening>();

        public List<Bankrekening> Rekeningen
		{
			get { return objLijst; }
		}

		public Klant(string VN, string AN)
		{
			voornaam = VN;
			achternaam = AN;
		}

		public void RekeningToevoegen(string VN, string FN)
		{
			Bankrekening objRekening = new Bankrekening(VN, FN);
			objLijst.Add(objRekening);
		}

        public override string ToString()
        {
			return $"{voornaam} {achternaam}";
        }



	}
}
