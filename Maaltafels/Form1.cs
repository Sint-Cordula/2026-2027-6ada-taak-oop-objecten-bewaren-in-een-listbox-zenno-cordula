namespace Maaltafels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                lstGetallen.Items.Add(i + 1);
            }
        }

        private void lstGetallen_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                lblMaaltafels.Text += $"{i + 1}x{lstGetallen.SelectedIndex + 1} = {(lstGetallen.SelectedIndex + 1) * (i + 1)}{Environment.NewLine}";
                //De '{Enviroment.NewLine}' is een enter
            }
        }
    }
}
