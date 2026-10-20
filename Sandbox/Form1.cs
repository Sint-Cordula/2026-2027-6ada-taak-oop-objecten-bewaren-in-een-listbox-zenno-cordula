namespace Sandbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMelding_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = txtInput.Text;
            if (radioButton6.Checked)
            {
                pictureBox1.Image = Properties.Resources.gpz_falls;
            }

            if (comboBox1.Items.Contains("maandag"))
            {

            }
            else
            {
                comboBox1.Items.Add("maandag");
                comboBox1.Items.Add("dinsdag");
                comboBox1.Items.Add("woensdag");
                comboBox1.Items.Add("donderdag");
                comboBox1.Items.Add("vrijdag");
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lblHelloWorld.Text = txtInput.Text;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                MessageBox.Show("Goed gekozen, dan verwacht ik jou daar! (je hebt het dan ni, loser!)");
            }
        }
    }
}
