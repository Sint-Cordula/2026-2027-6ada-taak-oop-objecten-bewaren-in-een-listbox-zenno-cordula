namespace Oefening_1_grootste_getal
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
            txtEersteGetal = new TextBox();
            lblGetal1 = new Label();
            lblGetal2 = new Label();
            lblGetal3 = new Label();
            lblGrootste = new Label();
            txtTweedeGetal = new TextBox();
            txtDerdeGetal = new TextBox();
            btnBepaal = new Button();
            lblGrootsteGetal = new Label();
            SuspendLayout();
            // 
            // txtEersteGetal
            // 
            txtEersteGetal.Location = new Point(100, 21);
            txtEersteGetal.Name = "txtEersteGetal";
            txtEersteGetal.Size = new Size(125, 27);
            txtEersteGetal.TabIndex = 0;
            txtEersteGetal.TextChanged += txtEersteGetal_TextChanged;
            // 
            // lblGetal1
            // 
            lblGetal1.AutoSize = true;
            lblGetal1.Location = new Point(23, 21);
            lblGetal1.Name = "lblGetal1";
            lblGetal1.Size = new Size(56, 20);
            lblGetal1.TabIndex = 1;
            lblGetal1.Text = "Getal 1";
            // 
            // lblGetal2
            // 
            lblGetal2.AutoSize = true;
            lblGetal2.Location = new Point(23, 64);
            lblGetal2.Name = "lblGetal2";
            lblGetal2.Size = new Size(56, 20);
            lblGetal2.TabIndex = 2;
            lblGetal2.Text = "Getal 2";
            // 
            // lblGetal3
            // 
            lblGetal3.AutoSize = true;
            lblGetal3.Location = new Point(23, 107);
            lblGetal3.Name = "lblGetal3";
            lblGetal3.Size = new Size(56, 20);
            lblGetal3.TabIndex = 3;
            lblGetal3.Text = "Getal 3";
            // 
            // lblGrootste
            // 
            lblGrootste.AutoSize = true;
            lblGrootste.Location = new Point(23, 148);
            lblGrootste.Name = "lblGrootste";
            lblGrootste.Size = new Size(69, 20);
            lblGrootste.TabIndex = 4;
            lblGrootste.Text = "Grootste:";
            // 
            // txtTweedeGetal
            // 
            txtTweedeGetal.Location = new Point(100, 60);
            txtTweedeGetal.Name = "txtTweedeGetal";
            txtTweedeGetal.Size = new Size(125, 27);
            txtTweedeGetal.TabIndex = 5;
            txtTweedeGetal.TextChanged += txtTweedeGetal_TextChanged;
            // 
            // txtDerdeGetal
            // 
            txtDerdeGetal.Location = new Point(100, 99);
            txtDerdeGetal.Name = "txtDerdeGetal";
            txtDerdeGetal.Size = new Size(125, 27);
            txtDerdeGetal.TabIndex = 6;
            txtDerdeGetal.TextChanged += txtDerdeGetal_TextChanged;
            // 
            // btnBepaal
            // 
            btnBepaal.Location = new Point(66, 207);
            btnBepaal.Name = "btnBepaal";
            btnBepaal.Size = new Size(94, 29);
            btnBepaal.TabIndex = 8;
            btnBepaal.Text = "Bepaal";
            btnBepaal.UseVisualStyleBackColor = true;
            btnBepaal.Click += btnBepaal_Click;
            // 
            // lblGrootsteGetal
            // 
            lblGrootsteGetal.AutoSize = true;
            lblGrootsteGetal.Location = new Point(100, 148);
            lblGrootsteGetal.Name = "lblGrootsteGetal";
            lblGrootsteGetal.Size = new Size(0, 20);
            lblGrootsteGetal.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGrootsteGetal);
            Controls.Add(btnBepaal);
            Controls.Add(txtDerdeGetal);
            Controls.Add(txtTweedeGetal);
            Controls.Add(lblGrootste);
            Controls.Add(lblGetal3);
            Controls.Add(lblGetal2);
            Controls.Add(lblGetal1);
            Controls.Add(txtEersteGetal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEersteGetal;
        private Label lblGetal1;
        private Label lblGetal2;
        private Label lblGetal3;
        private Label lblGrootste;
        private TextBox txtTweedeGetal;
        private TextBox txtDerdeGetal;
        private Button btnBepaal;
        private Label lblGrootsteGetal;
    }
}
