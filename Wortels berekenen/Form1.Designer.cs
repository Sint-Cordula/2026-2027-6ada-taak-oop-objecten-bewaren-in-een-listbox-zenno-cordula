namespace Wortels_berekenen
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
            lblWortel1 = new Label();
            lblWortel2 = new Label();
            lblWortel3 = new Label();
            txtWortel1 = new TextBox();
            txtWortel2 = new TextBox();
            txtWortel3 = new TextBox();
            btnWortelsBerekenen = new Button();
            lblUitkomstWortels = new Label();
            SuspendLayout();
            // 
            // lblWortel1
            // 
            lblWortel1.AutoSize = true;
            lblWortel1.Location = new Point(17, 27);
            lblWortel1.Name = "lblWortel1";
            lblWortel1.Size = new Size(17, 20);
            lblWortel1.TabIndex = 0;
            lblWortel1.Text = "a";
            // 
            // lblWortel2
            // 
            lblWortel2.AutoSize = true;
            lblWortel2.Location = new Point(17, 62);
            lblWortel2.Name = "lblWortel2";
            lblWortel2.Size = new Size(18, 20);
            lblWortel2.TabIndex = 1;
            lblWortel2.Text = "b";
            // 
            // lblWortel3
            // 
            lblWortel3.AutoSize = true;
            lblWortel3.Location = new Point(17, 97);
            lblWortel3.Name = "lblWortel3";
            lblWortel3.Size = new Size(16, 20);
            lblWortel3.TabIndex = 2;
            lblWortel3.Text = "c";
            // 
            // txtWortel1
            // 
            txtWortel1.Location = new Point(52, 20);
            txtWortel1.Name = "txtWortel1";
            txtWortel1.Size = new Size(125, 27);
            txtWortel1.TabIndex = 3;
            // 
            // txtWortel2
            // 
            txtWortel2.Location = new Point(52, 58);
            txtWortel2.Name = "txtWortel2";
            txtWortel2.Size = new Size(125, 27);
            txtWortel2.TabIndex = 4;
            // 
            // txtWortel3
            // 
            txtWortel3.Location = new Point(52, 96);
            txtWortel3.Name = "txtWortel3";
            txtWortel3.Size = new Size(125, 27);
            txtWortel3.TabIndex = 5;
            // 
            // btnWortelsBerekenen
            // 
            btnWortelsBerekenen.Location = new Point(195, 58);
            btnWortelsBerekenen.Name = "btnWortelsBerekenen";
            btnWortelsBerekenen.Size = new Size(124, 29);
            btnWortelsBerekenen.TabIndex = 6;
            btnWortelsBerekenen.Text = "Bereken wortels";
            btnWortelsBerekenen.UseVisualStyleBackColor = true;
            btnWortelsBerekenen.Click += btnWortelsBerekenen_Click;
            // 
            // lblUitkomstWortels
            // 
            lblUitkomstWortels.AutoSize = true;
            lblUitkomstWortels.Location = new Point(58, 152);
            lblUitkomstWortels.Name = "lblUitkomstWortels";
            lblUitkomstWortels.Size = new Size(0, 20);
            lblUitkomstWortels.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblUitkomstWortels);
            Controls.Add(btnWortelsBerekenen);
            Controls.Add(txtWortel3);
            Controls.Add(txtWortel2);
            Controls.Add(txtWortel1);
            Controls.Add(lblWortel3);
            Controls.Add(lblWortel2);
            Controls.Add(lblWortel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWortel1;
        private Label lblWortel2;
        private Label lblWortel3;
        private TextBox txtWortel1;
        private TextBox txtWortel2;
        private TextBox txtWortel3;
        private Button btnWortelsBerekenen;
        private Label lblUitkomstWortels;
    }
}
