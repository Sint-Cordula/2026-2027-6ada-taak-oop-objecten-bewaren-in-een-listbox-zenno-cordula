namespace Bankrekening
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRekening_Click(object sender, EventArgs e)
        {
            Bankrekening objRekening = new Bankrekening(txtVoornaam.Text, txtFamilienaam.Text);

            //alle textboxen op het formulier leegmaken
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

            lstVolledigeNaam.Items.Add(objRekening);


        }

        private void lstVolledigeNaam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVolledigeNaam.SelectedItem != null)
            {
                //om met het object aan de slag te kunnen gaan moeten we het uit de listbox halen
                //het geselecteerde object komt als 'object' uit de listbox, we moeten dit dus gaan
                //casten --> (Bankrekening)
                Bankrekening geselecteerdeRekening = (Bankrekening)lstVolledigeNaam.SelectedItem;

                lblNaam.Text = geselecteerdeRekening.VolledigeNaam;
                lblSaldo.Text = geselecteerdeRekening.Saldo.ToString();
            }
        }

        private void btnStorting_Click(object sender, EventArgs e)
        {
            if (txtBedrag.Text != "")
            {
                Bankrekening objRekening = (Bankrekening)lstVolledigeNaam.SelectedItem;
                objRekening.VerhoogSaldo(Convert.ToDouble(txtBedrag.Text));
                lblSaldo.Text = objRekening.Saldo.ToString();

                txtBedrag.Clear();
            }
        }

        private void btnOpname_Click(object sender, EventArgs e)
        {
            if (txtBedrag.Text != "")
            {
                Bankrekening objRekening = (Bankrekening)lstVolledigeNaam.SelectedItem;
                objRekening.VerlaagSaldo(Convert.ToDouble(txtBedrag.Text));
                lblSaldo.Text = objRekening.Saldo.ToString();

                txtBedrag.Clear();
            }
        }
    }
}
