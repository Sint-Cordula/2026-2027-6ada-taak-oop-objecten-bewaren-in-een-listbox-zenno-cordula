namespace Jeugdbeweging
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
            rdbRakker = new RadioButton();
            rdbKapoen = new RadioButton();
            rdbTopper = new RadioButton();
            grpKleuters = new GroupBox();
            cboBestemming = new ComboBox();
            lblUitstap = new Label();
            lblBestemming = new Label();
            lblAantalDagen = new Label();
            lblTeBetalen = new Label();
            txtAantalDagen = new TextBox();
            lblTeBetalenEindbedrag = new Label();
            btnBerekenen = new Button();
            grpKleuters.SuspendLayout();
            SuspendLayout();
            // 
            // rdbRakker
            // 
            rdbRakker.AutoSize = true;
            rdbRakker.Location = new Point(13, 19);
            rdbRakker.Name = "rdbRakker";
            rdbRakker.Size = new Size(74, 24);
            rdbRakker.TabIndex = 0;
            rdbRakker.TabStop = true;
            rdbRakker.Text = "Rakker";
            rdbRakker.UseVisualStyleBackColor = true;
            rdbRakker.CheckedChanged += rdbRakker_CheckedChanged;
            // 
            // rdbKapoen
            // 
            rdbKapoen.AutoSize = true;
            rdbKapoen.Location = new Point(13, 76);
            rdbKapoen.Name = "rdbKapoen";
            rdbKapoen.Size = new Size(81, 24);
            rdbKapoen.TabIndex = 1;
            rdbKapoen.TabStop = true;
            rdbKapoen.Text = "Kapoen";
            rdbKapoen.UseVisualStyleBackColor = true;
            // 
            // rdbTopper
            // 
            rdbTopper.AutoSize = true;
            rdbTopper.Location = new Point(13, 133);
            rdbTopper.Name = "rdbTopper";
            rdbTopper.Size = new Size(77, 24);
            rdbTopper.TabIndex = 2;
            rdbTopper.TabStop = true;
            rdbTopper.Text = "Topper";
            rdbTopper.UseVisualStyleBackColor = true;
            // 
            // grpKleuters
            // 
            grpKleuters.Controls.Add(rdbTopper);
            grpKleuters.Controls.Add(rdbKapoen);
            grpKleuters.Controls.Add(rdbRakker);
            grpKleuters.Location = new Point(63, 118);
            grpKleuters.Name = "grpKleuters";
            grpKleuters.Size = new Size(177, 196);
            grpKleuters.TabIndex = 3;
            grpKleuters.TabStop = false;
            grpKleuters.Text = "Leeftijdscategorie";
            // 
            // cboBestemming
            // 
            cboBestemming.FormattingEnabled = true;
            cboBestemming.Location = new Point(380, 148);
            cboBestemming.Name = "cboBestemming";
            cboBestemming.Size = new Size(151, 28);
            cboBestemming.TabIndex = 4;
            // 
            // lblUitstap
            // 
            lblUitstap.AutoSize = true;
            lblUitstap.BackColor = Color.Coral;
            lblUitstap.Font = new Font("Segoe UI", 20F);
            lblUitstap.Location = new Point(321, 48);
            lblUitstap.Name = "lblUitstap";
            lblUitstap.Size = new Size(177, 46);
            lblUitstap.TabIndex = 5;
            lblUitstap.Text = "Op uitstap";
            // 
            // lblBestemming
            // 
            lblBestemming.AutoSize = true;
            lblBestemming.Location = new Point(264, 152);
            lblBestemming.Name = "lblBestemming";
            lblBestemming.Size = new Size(92, 20);
            lblBestemming.TabIndex = 6;
            lblBestemming.Text = "Bestemming";
            // 
            // lblAantalDagen
            // 
            lblAantalDagen.AutoSize = true;
            lblAantalDagen.Location = new Point(264, 204);
            lblAantalDagen.Name = "lblAantalDagen";
            lblAantalDagen.Size = new Size(98, 20);
            lblAantalDagen.TabIndex = 7;
            lblAantalDagen.Text = "Aantal dagen";
            // 
            // lblTeBetalen
            // 
            lblTeBetalen.AutoSize = true;
            lblTeBetalen.Location = new Point(264, 261);
            lblTeBetalen.Name = "lblTeBetalen";
            lblTeBetalen.Size = new Size(78, 20);
            lblTeBetalen.TabIndex = 8;
            lblTeBetalen.Text = "Te betalen";
            // 
            // txtAantalDagen
            // 
            txtAantalDagen.Location = new Point(380, 201);
            txtAantalDagen.Name = "txtAantalDagen";
            txtAantalDagen.Size = new Size(125, 27);
            txtAantalDagen.TabIndex = 9;
            // 
            // lblTeBetalenEindbedrag
            // 
            lblTeBetalenEindbedrag.AutoSize = true;
            lblTeBetalenEindbedrag.Location = new Point(380, 261);
            lblTeBetalenEindbedrag.Name = "lblTeBetalenEindbedrag";
            lblTeBetalenEindbedrag.Size = new Size(0, 20);
            lblTeBetalenEindbedrag.TabIndex = 10;
            // 
            // btnBerekenen
            // 
            btnBerekenen.Location = new Point(338, 312);
            btnBerekenen.Name = "btnBerekenen";
            btnBerekenen.Size = new Size(94, 29);
            btnBerekenen.TabIndex = 11;
            btnBerekenen.Text = "Bereken!";
            btnBerekenen.UseVisualStyleBackColor = true;
            btnBerekenen.Click += btnBerekenen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBerekenen);
            Controls.Add(lblTeBetalenEindbedrag);
            Controls.Add(txtAantalDagen);
            Controls.Add(lblTeBetalen);
            Controls.Add(lblAantalDagen);
            Controls.Add(lblBestemming);
            Controls.Add(lblUitstap);
            Controls.Add(cboBestemming);
            Controls.Add(grpKleuters);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpKleuters.ResumeLayout(false);
            grpKleuters.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdbRakker;
        private RadioButton rdbKapoen;
        private RadioButton rdbTopper;
        private GroupBox grpKleuters;
        private ComboBox cboBestemming;
        private Label lblUitstap;
        private Label lblBestemming;
        private Label lblAantalDagen;
        private Label lblTeBetalen;
        private TextBox txtAantalDagen;
        private Label lblTeBetalenEindbedrag;
        private Button btnBerekenen;
    }
}
