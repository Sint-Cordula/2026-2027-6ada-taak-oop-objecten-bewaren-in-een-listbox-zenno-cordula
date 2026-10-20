namespace Jeugdbeweging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //De methode Form1 is de constructor van de klasse Form1 en
            //zal uitgevoerd worden wanneer je je formulier laadt (startscherm specificaties)

            //kapoenen aanduiden bij het laden van het formulier
            //optie Ardennen aanduiden bij laden formulier

            rdbKapoen.Checked = true;
            cboBestemming.Items.Add("Zee");
            cboBestemming.Items.Add("Ardennen");
            cboBestemming.SelectedIndex = 1;
        }

        private void btnBerekenen_Click(object sender, EventArgs e)
        {
            double resultaat = 0;
            if (Convert.ToDouble(txtAantalDagen.Text) > 7 || Convert.ToDouble(txtAantalDagen.Text) < 1)
            {
                MessageBox.Show("Aantal dagen moet tussen 1 en 7 liggen (grenzen inbegrepen)", "Opgelet!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double aantalDagen = Convert.ToDouble(txtAantalDagen.Text);

                if (rdbRakker.Checked)
                {
                    resultaat = (17.50 * aantalDagen) * 0.8;
                }
                else if (rdbKapoen.Checked)
                {
                    if (cboBestemming.Text == "Zee")
                    {
                        resultaat = (17.50 * aantalDagen) * 0.9;
                    }
                    else if (cboBestemming.Text == "Ardennen")
                    {
                        resultaat = (22.50 * aantalDagen) * 0.9;
                    }
                }
                else if (rdbTopper.Checked)
                {
                    if (cboBestemming.Text == "Zee")
                    {
                        resultaat = 17.50 * aantalDagen;
                    }
                    else if (cboBestemming.Text == "Ardennen")
                    {
                        resultaat = 22.50 * aantalDagen;
                    }
                }

                lblTeBetalenEindbedrag.Text = $"{resultaat} EUR";


            }





        }

        private void rdbRakker_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRakker.Checked)
            {
                cboBestemming.Items.Remove("Zee");
                cboBestemming.Text = "Zee";
                cboBestemming.Items.Remove("Ardennen");
            }
            else
            {
                cboBestemming.Items.Add("Zee");
                cboBestemming.Items.Add("Ardennen");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //in deze methode vangt het 'load' event op van mijn formulier
            //Ook hier kan ik code plaatsen die uitgevoerd moet worden bij het laden van mijn formulier.
        }
    }
}
