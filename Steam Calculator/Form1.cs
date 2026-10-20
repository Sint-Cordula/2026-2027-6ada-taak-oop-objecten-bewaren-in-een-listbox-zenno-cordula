namespace Steam_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            if (txtGameName.Text != "" && txtPrijs.Text != "" && txtUren.Text != "")
            {
                Calculator objGame = new Calculator(Convert.ToDouble(txtUren.Text), Convert.ToDouble(txtPrijs.Text), txtGameName.Text);

                //alle textboxen op het formulier leegmaken
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                lstGames.Items.Add(objGame);
            }
        }

        private void lstGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGames.SelectedItem != null)
            {
                Calculator selectedGame = (Calculator)lstGames.SelectedItem;

                lblSelectedGame.Text = $"{selectedGame.NaamGame}";
                lblSelectedPrijs.Text = $"{selectedGame.Prijs.ToString()}";
                lblSelectedUren.Text = $"{selectedGame.Uren.ToString()}";
            }
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            if (lblSelectedPrijs.Text != "" && lblSelectedUren.Text != "")
            {
                Calculator objGame = (Calculator)lstGames.SelectedItem;
                double resultaat = objGame.VerbruikPerUur();
                lblPrijsPerUur.Text = $"Aantal euro per uur gespendeerd in {lblSelectedGame.Text}: €{resultaat} per uur";
            }
        }

        private void btnTotalCalculator_Click(object sender, EventArgs e)
        {
            if (lstGames.Items != null)
            {
                double resultaat = 0;
                double totaalUren = 0;
                double totaalPrijs = 0;
                foreach (object item in lstGames.Items)
                {
                    Calculator objTotaal = (Calculator)item;
                    totaalPrijs += objTotaal.Prijs;
                    totaalUren += objTotaal.Uren;
                }
                resultaat = totaalPrijs / totaalUren;
                lblTotalCalculated.Text = $"Aantal euro per uur gespendeerd in alle games: €{resultaat} per uur";
            }
        }
    }
}
