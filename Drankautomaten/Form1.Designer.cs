namespace Drankautomaten
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
            lblDrankautomaatToevoegen = new Label();
            txtDrankautomaatToevoegen = new TextBox();
            btnDrankautomaatToevoegen = new Button();
            lstAutomaten = new ListBox();
            lblSelectedAutomaat = new Label();
            lblTotaal = new Label();
            lblUnderline = new Label();
            lblCola = new Label();
            lblWater = new Label();
            lblDrankToevoegen = new Label();
            lblColaToevoegen = new Label();
            lblWaterToevoegen = new Label();
            txtColaToevoegen = new TextBox();
            txtWaterToevoegen = new TextBox();
            btnColaToevoegen = new Button();
            btnWaterToevoegen = new Button();
            lblKopen = new Label();
            lblColaKopen = new Label();
            lblWaterKopen = new Label();
            btnColaKopen = new Button();
            btnWaterKopen = new Button();
            SuspendLayout();
            // 
            // lblDrankautomaatToevoegen
            // 
            lblDrankautomaatToevoegen.AutoSize = true;
            lblDrankautomaatToevoegen.Location = new Point(19, 24);
            lblDrankautomaatToevoegen.Name = "lblDrankautomaatToevoegen";
            lblDrankautomaatToevoegen.Size = new Size(157, 20);
            lblDrankautomaatToevoegen.TabIndex = 0;
            lblDrankautomaatToevoegen.Text = "Naam drankautomaat:";
            // 
            // txtDrankautomaatToevoegen
            // 
            txtDrankautomaatToevoegen.Location = new Point(182, 21);
            txtDrankautomaatToevoegen.Name = "txtDrankautomaatToevoegen";
            txtDrankautomaatToevoegen.Size = new Size(125, 27);
            txtDrankautomaatToevoegen.TabIndex = 1;
            // 
            // btnDrankautomaatToevoegen
            // 
            btnDrankautomaatToevoegen.Location = new Point(313, 20);
            btnDrankautomaatToevoegen.Name = "btnDrankautomaatToevoegen";
            btnDrankautomaatToevoegen.Size = new Size(94, 29);
            btnDrankautomaatToevoegen.TabIndex = 2;
            btnDrankautomaatToevoegen.Text = "Toevoegen";
            btnDrankautomaatToevoegen.UseVisualStyleBackColor = true;
            btnDrankautomaatToevoegen.Click += btnDrankautomaatToevoegen_Click;
            // 
            // lstAutomaten
            // 
            lstAutomaten.FormattingEnabled = true;
            lstAutomaten.Location = new Point(19, 55);
            lstAutomaten.Name = "lstAutomaten";
            lstAutomaten.Size = new Size(388, 384);
            lstAutomaten.TabIndex = 3;
            // 
            // lblSelectedAutomaat
            // 
            lblSelectedAutomaat.AutoSize = true;
            lblSelectedAutomaat.Location = new Point(413, 55);
            lblSelectedAutomaat.Name = "lblSelectedAutomaat";
            lblSelectedAutomaat.Size = new Size(90, 20);
            lblSelectedAutomaat.TabIndex = 4;
            lblSelectedAutomaat.Text = "AUTOMAAT:";
            // 
            // lblTotaal
            // 
            lblTotaal.AutoSize = true;
            lblTotaal.Location = new Point(413, 102);
            lblTotaal.Name = "lblTotaal";
            lblTotaal.Size = new Size(60, 20);
            lblTotaal.TabIndex = 5;
            lblTotaal.Text = "TOTAAL";
            // 
            // lblUnderline
            // 
            lblUnderline.AutoSize = true;
            lblUnderline.Location = new Point(413, 82);
            lblUnderline.Name = "lblUnderline";
            lblUnderline.Size = new Size(237, 20);
            lblUnderline.TabIndex = 6;
            lblUnderline.Text = "______________________________________";
            // 
            // lblCola
            // 
            lblCola.AutoSize = true;
            lblCola.Location = new Point(413, 135);
            lblCola.Name = "lblCola";
            lblCola.Size = new Size(42, 20);
            lblCola.TabIndex = 7;
            lblCola.Text = "Cola:";
            // 
            // lblWater
            // 
            lblWater.AutoSize = true;
            lblWater.Location = new Point(413, 171);
            lblWater.Name = "lblWater";
            lblWater.Size = new Size(51, 20);
            lblWater.TabIndex = 8;
            lblWater.Text = "Water:";
            // 
            // lblDrankToevoegen
            // 
            lblDrankToevoegen.AutoSize = true;
            lblDrankToevoegen.Location = new Point(413, 214);
            lblDrankToevoegen.Name = "lblDrankToevoegen";
            lblDrankToevoegen.Size = new Size(92, 20);
            lblDrankToevoegen.TabIndex = 9;
            lblDrankToevoegen.Text = "TOEVOEGEN";
            // 
            // lblColaToevoegen
            // 
            lblColaToevoegen.AutoSize = true;
            lblColaToevoegen.Location = new Point(413, 259);
            lblColaToevoegen.Name = "lblColaToevoegen";
            lblColaToevoegen.Size = new Size(42, 20);
            lblColaToevoegen.TabIndex = 10;
            lblColaToevoegen.Text = "Cola:";
            // 
            // lblWaterToevoegen
            // 
            lblWaterToevoegen.AutoSize = true;
            lblWaterToevoegen.Location = new Point(413, 297);
            lblWaterToevoegen.Name = "lblWaterToevoegen";
            lblWaterToevoegen.Size = new Size(51, 20);
            lblWaterToevoegen.TabIndex = 11;
            lblWaterToevoegen.Text = "Water:";
            // 
            // txtColaToevoegen
            // 
            txtColaToevoegen.Location = new Point(478, 256);
            txtColaToevoegen.Name = "txtColaToevoegen";
            txtColaToevoegen.Size = new Size(125, 27);
            txtColaToevoegen.TabIndex = 12;
            // 
            // txtWaterToevoegen
            // 
            txtWaterToevoegen.Location = new Point(478, 294);
            txtWaterToevoegen.Name = "txtWaterToevoegen";
            txtWaterToevoegen.Size = new Size(125, 27);
            txtWaterToevoegen.TabIndex = 13;
            // 
            // btnColaToevoegen
            // 
            btnColaToevoegen.Location = new Point(614, 255);
            btnColaToevoegen.Name = "btnColaToevoegen";
            btnColaToevoegen.Size = new Size(94, 29);
            btnColaToevoegen.TabIndex = 14;
            btnColaToevoegen.Text = "Bijvullen";
            btnColaToevoegen.UseVisualStyleBackColor = true;
            // 
            // btnWaterToevoegen
            // 
            btnWaterToevoegen.Location = new Point(614, 293);
            btnWaterToevoegen.Name = "btnWaterToevoegen";
            btnWaterToevoegen.Size = new Size(94, 29);
            btnWaterToevoegen.TabIndex = 15;
            btnWaterToevoegen.Text = "Bijvullen";
            btnWaterToevoegen.UseVisualStyleBackColor = true;
            // 
            // lblKopen
            // 
            lblKopen.AutoSize = true;
            lblKopen.Location = new Point(754, 214);
            lblKopen.Name = "lblKopen";
            lblKopen.Size = new Size(55, 20);
            lblKopen.TabIndex = 16;
            lblKopen.Text = "KOPEN";
            // 
            // lblColaKopen
            // 
            lblColaKopen.AutoSize = true;
            lblColaKopen.Location = new Point(754, 259);
            lblColaKopen.Name = "lblColaKopen";
            lblColaKopen.Size = new Size(42, 20);
            lblColaKopen.TabIndex = 17;
            lblColaKopen.Text = "Cola:";
            // 
            // lblWaterKopen
            // 
            lblWaterKopen.AutoSize = true;
            lblWaterKopen.Location = new Point(754, 297);
            lblWaterKopen.Name = "lblWaterKopen";
            lblWaterKopen.Size = new Size(51, 20);
            lblWaterKopen.TabIndex = 18;
            lblWaterKopen.Text = "Water:";
            // 
            // btnColaKopen
            // 
            btnColaKopen.Location = new Point(815, 255);
            btnColaKopen.Name = "btnColaKopen";
            btnColaKopen.Size = new Size(94, 29);
            btnColaKopen.TabIndex = 19;
            btnColaKopen.Text = "Kopen";
            btnColaKopen.UseVisualStyleBackColor = true;
            // 
            // btnWaterKopen
            // 
            btnWaterKopen.Location = new Point(815, 293);
            btnWaterKopen.Name = "btnWaterKopen";
            btnWaterKopen.Size = new Size(94, 29);
            btnWaterKopen.TabIndex = 20;
            btnWaterKopen.Text = "Kopen";
            btnWaterKopen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 450);
            Controls.Add(btnWaterKopen);
            Controls.Add(btnColaKopen);
            Controls.Add(lblWaterKopen);
            Controls.Add(lblColaKopen);
            Controls.Add(lblKopen);
            Controls.Add(btnWaterToevoegen);
            Controls.Add(btnColaToevoegen);
            Controls.Add(txtWaterToevoegen);
            Controls.Add(txtColaToevoegen);
            Controls.Add(lblWaterToevoegen);
            Controls.Add(lblColaToevoegen);
            Controls.Add(lblDrankToevoegen);
            Controls.Add(lblWater);
            Controls.Add(lblCola);
            Controls.Add(lblUnderline);
            Controls.Add(lblTotaal);
            Controls.Add(lblSelectedAutomaat);
            Controls.Add(lstAutomaten);
            Controls.Add(btnDrankautomaatToevoegen);
            Controls.Add(txtDrankautomaatToevoegen);
            Controls.Add(lblDrankautomaatToevoegen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDrankautomaatToevoegen;
        private TextBox txtDrankautomaatToevoegen;
        private Button btnDrankautomaatToevoegen;
        private ListBox lstAutomaten;
        private Label lblSelectedAutomaat;
        private Label lblTotaal;
        private Label lblUnderline;
        private Label lblCola;
        private Label lblWater;
        private Label lblDrankToevoegen;
        private Label lblColaToevoegen;
        private Label lblWaterToevoegen;
        private TextBox txtColaToevoegen;
        private TextBox txtWaterToevoegen;
        private Button btnColaToevoegen;
        private Button btnWaterToevoegen;
        private Label lblKopen;
        private Label lblColaKopen;
        private Label lblWaterKopen;
        private Button btnColaKopen;
        private Button btnWaterKopen;
    }
}
