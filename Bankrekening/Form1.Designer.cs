namespace Bankrekening
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
            lblVoornaamEnFamilienaam = new Label();
            txtVoornaam = new TextBox();
            txtFamilienaam = new TextBox();
            btnRekening = new Button();
            lstVolledigeNaam = new ListBox();
            lblNaam = new Label();
            lblSaldo = new Label();
            lblBedrag = new Label();
            txtBedrag = new TextBox();
            btnStorting = new Button();
            btnOpname = new Button();
            SuspendLayout();
            // 
            // lblVoornaamEnFamilienaam
            // 
            lblVoornaamEnFamilienaam.AutoSize = true;
            lblVoornaamEnFamilienaam.Location = new Point(46, 30);
            lblVoornaamEnFamilienaam.Name = "lblVoornaamEnFamilienaam";
            lblVoornaamEnFamilienaam.Size = new Size(175, 20);
            lblVoornaamEnFamilienaam.TabIndex = 0;
            lblVoornaamEnFamilienaam.Text = "Voornaam - Familienaam";
            // 
            // txtVoornaam
            // 
            txtVoornaam.Location = new Point(261, 27);
            txtVoornaam.Name = "txtVoornaam";
            txtVoornaam.Size = new Size(125, 27);
            txtVoornaam.TabIndex = 1;
            // 
            // txtFamilienaam
            // 
            txtFamilienaam.Location = new Point(443, 27);
            txtFamilienaam.Name = "txtFamilienaam";
            txtFamilienaam.Size = new Size(125, 27);
            txtFamilienaam.TabIndex = 2;
            // 
            // btnRekening
            // 
            btnRekening.Location = new Point(46, 62);
            btnRekening.Name = "btnRekening";
            btnRekening.Size = new Size(177, 29);
            btnRekening.TabIndex = 3;
            btnRekening.Text = "Rekening";
            btnRekening.UseVisualStyleBackColor = true;
            btnRekening.Click += btnRekening_Click;
            // 
            // lstVolledigeNaam
            // 
            lstVolledigeNaam.FormattingEnabled = true;
            lstVolledigeNaam.Location = new Point(46, 103);
            lstVolledigeNaam.Name = "lstVolledigeNaam";
            lstVolledigeNaam.Size = new Size(177, 124);
            lstVolledigeNaam.TabIndex = 4;
            lstVolledigeNaam.SelectedIndexChanged += lstVolledigeNaam_SelectedIndexChanged;
            // 
            // lblNaam
            // 
            lblNaam.AutoSize = true;
            lblNaam.Location = new Point(46, 239);
            lblNaam.Name = "lblNaam";
            lblNaam.Size = new Size(52, 20);
            lblNaam.TabIndex = 5;
            lblNaam.Text = "Naam:";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(46, 271);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(50, 20);
            lblSaldo.TabIndex = 6;
            lblSaldo.Text = "Saldo:";
            // 
            // lblBedrag
            // 
            lblBedrag.AutoSize = true;
            lblBedrag.Location = new Point(46, 304);
            lblBedrag.Name = "lblBedrag";
            lblBedrag.Size = new Size(57, 20);
            lblBedrag.TabIndex = 7;
            lblBedrag.Text = "bedrag";
            // 
            // txtBedrag
            // 
            txtBedrag.Location = new Point(223, 301);
            txtBedrag.Name = "txtBedrag";
            txtBedrag.Size = new Size(125, 27);
            txtBedrag.TabIndex = 8;
            // 
            // btnStorting
            // 
            btnStorting.Location = new Point(46, 363);
            btnStorting.Name = "btnStorting";
            btnStorting.Size = new Size(94, 29);
            btnStorting.TabIndex = 9;
            btnStorting.Text = "Storting";
            btnStorting.UseVisualStyleBackColor = true;
            btnStorting.Click += btnStorting_Click;
            // 
            // btnOpname
            // 
            btnOpname.Location = new Point(223, 363);
            btnOpname.Name = "btnOpname";
            btnOpname.Size = new Size(94, 29);
            btnOpname.TabIndex = 10;
            btnOpname.Text = "Opname";
            btnOpname.UseVisualStyleBackColor = true;
            btnOpname.Click += btnOpname_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpname);
            Controls.Add(btnStorting);
            Controls.Add(txtBedrag);
            Controls.Add(lblBedrag);
            Controls.Add(lblSaldo);
            Controls.Add(lblNaam);
            Controls.Add(lstVolledigeNaam);
            Controls.Add(btnRekening);
            Controls.Add(txtFamilienaam);
            Controls.Add(txtVoornaam);
            Controls.Add(lblVoornaamEnFamilienaam);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVoornaamEnFamilienaam;
        private TextBox txtVoornaam;
        private TextBox txtFamilienaam;
        private Button btnRekening;
        private ListBox lstVolledigeNaam;
        private Label lblNaam;
        private Label lblSaldo;
        private Label lblBedrag;
        private TextBox txtBedrag;
        private Button btnStorting;
        private Button btnOpname;
    }
}
