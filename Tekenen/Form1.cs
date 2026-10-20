namespace Tekenen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTeken_Click(object sender, EventArgs e)
        {
            txtTeken.Clear();
            int eindwaarde = Convert.ToInt32(txtEindwaarde.Text);
            int startwaarde = Convert.ToInt32(txtStartwaarde.Text);
            for (int i = startwaarde; i <= eindwaarde; i++)
            {
                for (int a = 0; a < i; a++)
                {
                    txtTeken.Text += txtSymbool.Text;
                }
                txtTeken.Text += Environment.NewLine;
            }
        }
    }
}
