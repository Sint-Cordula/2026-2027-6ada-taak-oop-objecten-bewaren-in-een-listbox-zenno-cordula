namespace Maaltafels
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
            lblTafel = new Label();
            lstGetallen = new ListBox();
            lblMaaltafels = new Label();
            SuspendLayout();
            // 
            // lblTafel
            // 
            lblTafel.AutoSize = true;
            lblTafel.Location = new Point(20, 39);
            lblTafel.Name = "lblTafel";
            lblTafel.Size = new Size(92, 20);
            lblTafel.TabIndex = 0;
            lblTafel.Text = "De tafel van:";
            // 
            // lstGetallen
            // 
            lstGetallen.FormattingEnabled = true;
            lstGetallen.Location = new Point(170, 39);
            lstGetallen.Name = "lstGetallen";
            lstGetallen.Size = new Size(64, 204);
            lstGetallen.TabIndex = 1;
            lstGetallen.SelectedIndexChanged += lstGetallen_SelectedIndexChanged;
            // 
            // lblMaaltafels
            // 
            lblMaaltafels.AutoSize = true;
            lblMaaltafels.Location = new Point(374, 39);
            lblMaaltafels.Name = "lblMaaltafels";
            lblMaaltafels.Size = new Size(0, 20);
            lblMaaltafels.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMaaltafels);
            Controls.Add(lstGetallen);
            Controls.Add(lblTafel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTafel;
        private ListBox lstGetallen;
        private Label lblMaaltafels;
    }
}
