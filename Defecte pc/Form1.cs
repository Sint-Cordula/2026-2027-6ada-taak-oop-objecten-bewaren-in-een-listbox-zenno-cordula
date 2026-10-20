namespace Defecte_pc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 1; i <= 16; i++)
            {
                lstWerkendePC.Items.Add(i.ToString("PC00"));
            }
        }

        private void btnWerkendNaarDefect_Click(object sender, EventArgs e)
        {
            if (lstWerkendePC.SelectedItem != null)
            {
                lstDefectePC.Items.Add(lstWerkendePC.SelectedItem);
                lstWerkendePC.Items.Remove(lstWerkendePC.SelectedItem);
            }
        }

        private void btnDefectNaarWerkend_Click(object sender, EventArgs e)
        {
            if (lstDefectePC.SelectedItem != null)
            {
                lstWerkendePC.Items.Add(lstDefectePC.SelectedItem);
                lstDefectePC.Items.Remove(lstDefectePC.SelectedItem);
            }
        }
    }
}
