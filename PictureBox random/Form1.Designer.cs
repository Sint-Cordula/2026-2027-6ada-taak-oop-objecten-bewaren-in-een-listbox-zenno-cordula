namespace PictureBox_random
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
            btnStart = new Button();
            lblRandom1 = new Label();
            lblRandom2 = new Label();
            lblRandom3 = new Label();
            lblUitleg = new Label();
            pctAfbeelding = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctAfbeelding).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 58);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblRandom1
            // 
            lblRandom1.AutoSize = true;
            lblRandom1.Location = new Point(138, 62);
            lblRandom1.Name = "lblRandom1";
            lblRandom1.Size = new Size(0, 20);
            lblRandom1.TabIndex = 1;
            // 
            // lblRandom2
            // 
            lblRandom2.AutoSize = true;
            lblRandom2.Location = new Point(224, 62);
            lblRandom2.Name = "lblRandom2";
            lblRandom2.Size = new Size(0, 20);
            lblRandom2.TabIndex = 2;
            // 
            // lblRandom3
            // 
            lblRandom3.AutoSize = true;
            lblRandom3.Location = new Point(310, 62);
            lblRandom3.Name = "lblRandom3";
            lblRandom3.Size = new Size(0, 20);
            lblRandom3.TabIndex = 3;
            // 
            // lblUitleg
            // 
            lblUitleg.AutoSize = true;
            lblUitleg.Location = new Point(64, 21);
            lblUitleg.Name = "lblUitleg";
            lblUitleg.Size = new Size(233, 20);
            lblUitleg.TabIndex = 4;
            lblUitleg.Text = "Waag je kans: 7 is het gelukscijfer!";
            // 
            // pctAfbeelding
            // 
            pctAfbeelding.Location = new Point(73, 93);
            pctAfbeelding.Name = "pctAfbeelding";
            pctAfbeelding.Size = new Size(224, 250);
            pctAfbeelding.SizeMode = PictureBoxSizeMode.Zoom;
            pctAfbeelding.TabIndex = 5;
            pctAfbeelding.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pctAfbeelding);
            Controls.Add(lblUitleg);
            Controls.Add(lblRandom3);
            Controls.Add(lblRandom2);
            Controls.Add(lblRandom1);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pctAfbeelding).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Label lblRandom1;
        private Label lblRandom2;
        private Label lblRandom3;
        private Label lblUitleg;
        private PictureBox pctAfbeelding;
    }
}
