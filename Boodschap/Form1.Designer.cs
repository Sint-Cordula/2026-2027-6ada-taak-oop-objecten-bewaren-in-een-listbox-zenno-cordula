namespace Boodschap
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnToevoegen = new Button();
            lblAantal = new Label();
            lblProductNaam = new Label();
            txtAantal = new TextBox();
            txtProductNaam = new TextBox();
            lstProductenEnPrijs = new ListBox();
            btnVerwijder = new Button();
            lblProductenEnPrijs = new Label();
            SuspendLayout();
            // 
            // btnToevoegen
            // 
            btnToevoegen.Location = new Point(27, 292);
            btnToevoegen.Name = "btnToevoegen";
            btnToevoegen.Size = new Size(94, 29);
            btnToevoegen.TabIndex = 0;
            btnToevoegen.Text = "Voeg toe";
            btnToevoegen.UseVisualStyleBackColor = true;
            btnToevoegen.Click += btnToevoegen_Click;
            // 
            // lblAantal
            // 
            lblAantal.AutoSize = true;
            lblAantal.Location = new Point(27, 19);
            lblAantal.Name = "lblAantal";
            lblAantal.Size = new Size(52, 20);
            lblAantal.TabIndex = 1;
            lblAantal.Text = "Aantal";
            // 
            // lblProductNaam
            // 
            lblProductNaam.AutoSize = true;
            lblProductNaam.Location = new Point(262, 19);
            lblProductNaam.Name = "lblProductNaam";
            lblProductNaam.Size = new Size(97, 20);
            lblProductNaam.TabIndex = 2;
            lblProductNaam.Text = "Productnaam";
            // 
            // txtAantal
            // 
            txtAantal.Location = new Point(27, 60);
            txtAantal.Name = "txtAantal";
            txtAantal.Size = new Size(125, 27);
            txtAantal.TabIndex = 3;
            // 
            // txtProductNaam
            // 
            txtProductNaam.Location = new Point(234, 60);
            txtProductNaam.Name = "txtProductNaam";
            txtProductNaam.Size = new Size(125, 27);
            txtProductNaam.TabIndex = 4;
            // 
            // lstProductenEnPrijs
            // 
            lstProductenEnPrijs.FormattingEnabled = true;
            lstProductenEnPrijs.Location = new Point(27, 103);
            lstProductenEnPrijs.Name = "lstProductenEnPrijs";
            lstProductenEnPrijs.Size = new Size(332, 184);
            lstProductenEnPrijs.TabIndex = 5;
            lstProductenEnPrijs.SelectedIndexChanged += lstProductenEnPrijs_SelectedIndexChanged;
            // 
            // btnVerwijder
            // 
            btnVerwijder.Location = new Point(265, 292);
            btnVerwijder.Name = "btnVerwijder";
            btnVerwijder.Size = new Size(94, 29);
            btnVerwijder.TabIndex = 6;
            btnVerwijder.Text = "Verwijder";
            btnVerwijder.UseVisualStyleBackColor = true;
            btnVerwijder.Click += btnVerwijder_Click;
            // 
            // lblProductenEnPrijs
            // 
            lblProductenEnPrijs.AutoSize = true;
            lblProductenEnPrijs.Location = new Point(370, 103);
            lblProductenEnPrijs.Name = "lblProductenEnPrijs";
            lblProductenEnPrijs.Size = new Size(0, 20);
            lblProductenEnPrijs.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblProductenEnPrijs);
            Controls.Add(btnVerwijder);
            Controls.Add(lstProductenEnPrijs);
            Controls.Add(txtProductNaam);
            Controls.Add(txtAantal);
            Controls.Add(lblProductNaam);
            Controls.Add(lblAantal);
            Controls.Add(btnToevoegen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnToevoegen;
        private Label lblAantal;
        private Label lblProductNaam;
        private TextBox txtAantal;
        private TextBox txtProductNaam;
        private ListBox lstProductenEnPrijs;
        private Button btnVerwijder;
        private Label lblProductenEnPrijs;
    }
}
