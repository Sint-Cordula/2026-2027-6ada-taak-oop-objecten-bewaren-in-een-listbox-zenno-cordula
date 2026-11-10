namespace Drankautomaten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDrankautomaatToevoegen_Click(object sender, EventArgs e)
        {
            if (txtDrankautomaatToevoegen.Text != "")
            {
                Automaat objNieuweAutomaat = new Automaat(txtDrankautomaatToevoegen.Text);
                txtDrankautomaatToevoegen.Text = "";
                lstAutomaten.Items.Add(objNieuweAutomaat);
            }
        }

        private void btnColaToevoegen_Click(object sender, EventArgs e)
        {
            if (txtColaToevoegen.Text != "")
            {
                Automaat objAutomaat = (Automaat)lstAutomaten.SelectedItem;
                MessageBox.Show(objAutomaat.BijvullenCola(Convert.ToInt32(txtColaToevoegen.Text)));
                txtColaToevoegen.Text = "";
                lblCola.Text = $"Cola: {objAutomaat.AantalCola.ToString()}";
            }
        }

        private void lstAutomaten_SelectedIndexChanged(object sender, EventArgs e)
        {
            Automaat objAutomaat = (Automaat)lstAutomaten.SelectedItem;
            lblSelectedAutomaat.Text = $"AUTOMAAT: {objAutomaat.Naam}";
            lblCola.Text = $"Cola: {Convert.ToString(objAutomaat.AantalCola)}";
            lblWater.Text = $"Water: {Convert.ToString(objAutomaat.AantalWater)}";
        }

        private void btnWaterToevoegen_Click(object sender, EventArgs e)
        {
            if (txtWaterToevoegen.Text != "")
            {
                Automaat objAutomaat = (Automaat)lstAutomaten.SelectedItem;
                MessageBox.Show(objAutomaat.BijvullenWater(Convert.ToInt32(txtWaterToevoegen.Text)));
                txtWaterToevoegen.Text = "";
                lblWater.Text = $"Water: {objAutomaat.AantalWater.ToString()}";
            }
        }

        private void btnColaKopen_Click(object sender, EventArgs e)
        {
            Automaat objAutomaat = (Automaat)lstAutomaten.SelectedItem;
            MessageBox.Show(objAutomaat.KoopCola());
            lblCola.Text = $"Cola: {objAutomaat.AantalCola.ToString()}";
        }

        private void btnWaterKopen_Click(object sender, EventArgs e)
        {
            Automaat objAutomaat = (Automaat)lstAutomaten.SelectedItem;
            MessageBox.Show(objAutomaat.KoopWater());
            lblWater.Text = $"Water: {objAutomaat.AantalWater.ToString()}";
        }
    }
}
