namespace Wortels_berekenen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWortelsBerekenen_Click(object sender, EventArgs e)
        {
            double discriminant;
            double uitkomstWortel1;
            double uitkomstWortel2;
            double wortel1, wortel2, wortel3;
            wortel1 = Convert.ToDouble(txtWortel1.Text);
            wortel2 = Convert.ToDouble(txtWortel2.Text);
            wortel3 = Convert.ToDouble(txtWortel3.Text);

            discriminant = Math.Pow(wortel2, 2) - 4 * wortel1 * wortel3;

            if (discriminant < 0)
            {
                Console.WriteLine("Er zijn geen reële wortels!");
            }
            else if (discriminant == 0)
            {
                uitkomstWortel1 = -wortel2 / (2 * wortel1);
                lblUitkomstWortels.Text = $"Er is één wortel: {uitkomstWortel1}";
            }
            else
            {
                uitkomstWortel1 = (-wortel2 - Math.Sqrt(discriminant)) / (2 * wortel1);
                uitkomstWortel2 = (-wortel2 + Math.Sqrt(discriminant)) / (2 * wortel1);
                lblUitkomstWortels.Text = $"Er zijn twee wortels: {uitkomstWortel1} en {uitkomstWortel2}";
            }
        }






    }
}
