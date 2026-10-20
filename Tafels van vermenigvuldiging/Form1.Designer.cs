namespace Tafels_van_vermenigvuldiging
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
            lblGetallen = new Label();
            SuspendLayout();
            // 
            // lblGetallen
            // 
            lblGetallen.AutoSize = true;
            lblGetallen.Location = new Point(13, 18);
            lblGetallen.Name = "lblGetallen";
            lblGetallen.Size = new Size(0, 20);
            lblGetallen.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 450);
            Controls.Add(lblGetallen);
            Name = "Form1";
            Text = "De tafels van vermenigvuldiging";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGetallen;
    }
}
