namespace Menu_keuzes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKeuzeTonen_Click(object sender, EventArgs e)
        {
            lblUwKeuzes.ResetText();
            lblUwKeuzes.Text += $"U heeft gekozen:{Environment.NewLine}{Environment.NewLine}";
            foreach (CheckBox item in grpKeuzelijst.Controls)
            {
                if (item.Checked)
                {
                    lblUwKeuzes.Text += $"{item.Text}{Environment.NewLine}";
                }
            }
        }
    }
}
