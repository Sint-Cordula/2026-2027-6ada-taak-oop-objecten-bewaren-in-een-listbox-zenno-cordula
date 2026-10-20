namespace Oefening_1_grootste_getal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEersteGetal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTweedeGetal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDerdeGetal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBepaal_Click(object sender, EventArgs e)
        {
            int getal1, getal2, getal3;
            getal1 = Convert.ToInt32(txtEersteGetal.Text);
            getal2 = Convert.ToInt32(txtTweedeGetal.Text);
            getal3 = Convert.ToInt32(txtDerdeGetal.Text);

            List<int> getallen = new List<int>() { getal1, getal2, getal3 };

            lblGrootsteGetal.Text = getallen.Max().ToString();
        }
    }
}
