using System.Security.Cryptography.X509Certificates;

namespace Boodschap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            //bij het oproepen van de constructor de data meegeven
            if (txtAantal.Text != "" || txtProductNaam.Text != "")
            {
                Boodschap objBoodschap = new Boodschap(txtProductNaam.Text, Convert.ToInt32(txtAantal.Text));

                //object toevoegen aan de listbox
                //opgelet: heel het object wordt op deze manier bewaard in de listbox!
                lstBoodschappenLijst.Items.Add(objBoodschap);

                //gebruiksvriendelijkheid: textboxen terug leegmaken
                txtAantal.Clear();
                txtProductNaam.Clear();
            }
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            Boodschap boodschap = (Boodschap)(lstBoodschappenLijst.SelectedItem);

            if (boodschap != null)
            {
                lstBoodschappenLijst.Items.Remove(boodschap);
            }
            lblProductenEnPrijs.Text = "";
        }

        private void lstProductenEnPrijs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //je haalt een object terug uit de listbox
            Boodschap boodschap = (Boodschap)(lstBoodschappenLijst.SelectedItem);

            //controleren of de gebruiker een boodschap geselecteerd heeft
            if (boodschap != null)
            {
                lblProductenEnPrijs.Text = $"Aantal: {boodschap.Aantal} {Environment.NewLine}Product: {boodschap.Productnaam}";
            }
        }

        private void btnNieuweWinkel_Click(object sender, EventArgs e)
        {
            if (txtWinkel.Text != String.Empty)
            {
                //aanmaken nieuw object
                Winkel objWinkel = new Winkel(txtWinkel.Text);

                //toevoegen object aan listbox
                lstWinkel.Items.Add(objWinkel);
                txtWinkel.Clear();
            }
            else
            {
                MessageBox.Show("Gelieve een winkelnaam op te geven.", "Foutmelding");
            }
        }

        private void lstWinkel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Winkel objWinkel = (Winkel)lstWinkel.SelectedItem;

            ToonBoodschappenInListbox(objWinkel);
            
        }

        private void ToonBoodschappenInListbox(Winkel objWinkel)
        {
            lstBoodschappenLijst.Items.Clear();
            foreach (Boodschap item in objWinkel.GetBoodschappenLijst())
            {
                lstBoodschappenLijst.Items.Add(item);
            }
        }
    }
}
