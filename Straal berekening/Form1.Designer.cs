namespace Straal_berekening
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
            txtStraal = new TextBox();
            lblStraal = new Label();
            btnStart = new Button();
            SuspendLayout();
            // 
            // txtStraal
            // 
            txtStraal.Location = new Point(106, 78);
            txtStraal.Name = "txtStraal";
            txtStraal.Size = new Size(125, 27);
            txtStraal.TabIndex = 0;
            // 
            // lblStraal
            // 
            lblStraal.AutoSize = true;
            lblStraal.Location = new Point(46, 81);
            lblStraal.Name = "lblStraal";
            lblStraal.Size = new Size(50, 20);
            lblStraal.TabIndex = 1;
            lblStraal.Text = "Straal:";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(88, 147);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStart);
            Controls.Add(lblStraal);
            Controls.Add(txtStraal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStraal;
        private Label lblStraal;
        private Button btnStart;
    }
}
