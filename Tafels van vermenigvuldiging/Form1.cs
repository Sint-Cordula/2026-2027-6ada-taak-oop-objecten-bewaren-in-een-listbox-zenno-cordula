namespace Tafels_van_vermenigvuldiging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int maaltafel = 0;
            for (int i = 1; i <= 11; i++)
            {
                for (int a = 1; a <= 10; a++)
                {
                    maaltafel = i * a;
                    lblGetallen.Text += maaltafel.ToString("000 ");
                }
                lblGetallen.Text += Environment.NewLine;
            }
        }
    }
}
