namespace PictureBox_random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int aantalKeerGespeeld = 0, gewonnen = 0, verloren = 0;

        private void btnStart_Click(object sender, EventArgs e)
        {
            pctAfbeelding.Image = null;
            Random random = new Random();

            aantalKeerGespeeld++;

            lblRandom1.Text = random.Next(1, 11).ToString();
            lblRandom2.Text = random.Next(1, 11).ToString();
            lblRandom3.Text = random.Next(1, 11).ToString();

            if (lblRandom1.Text == "7")
            {
                gewonnen++;
                pctAfbeelding.Image = Properties.Resources.grimm__no;
            }

            if (lblRandom2.Text == "7")
            {
                gewonnen++;
                pctAfbeelding.Image = Properties.Resources.grimm__no;
            }

            if (lblRandom3.Text == "7")
            {
                gewonnen++;
                pctAfbeelding.Image = Properties.Resources.grimm__no;
                DialogResult resultaat = MessageBox.Show("Wilt u verder spelen?", "Nog eens?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultaat == DialogResult.No)
                {
                    this.Close();
                }
            }
        }
    }
}
