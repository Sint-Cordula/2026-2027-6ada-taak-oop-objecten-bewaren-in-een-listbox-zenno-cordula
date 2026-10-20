namespace Tekenen
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
            lblSymbool = new Label();
            lblStartwaarde = new Label();
            lblEindwaarde = new Label();
            txtSymbool = new TextBox();
            txtStartwaarde = new TextBox();
            txtEindwaarde = new TextBox();
            btnTeken = new Button();
            txtTeken = new TextBox();
            SuspendLayout();
            // 
            // lblSymbool
            // 
            lblSymbool.AutoSize = true;
            lblSymbool.Location = new Point(32, 30);
            lblSymbool.Name = "lblSymbool";
            lblSymbool.Size = new Size(68, 20);
            lblSymbool.TabIndex = 0;
            lblSymbool.Text = "Symbool";
            // 
            // lblStartwaarde
            // 
            lblStartwaarde.AutoSize = true;
            lblStartwaarde.Location = new Point(32, 77);
            lblStartwaarde.Name = "lblStartwaarde";
            lblStartwaarde.Size = new Size(89, 20);
            lblStartwaarde.TabIndex = 1;
            lblStartwaarde.Text = "Startwaarde";
            // 
            // lblEindwaarde
            // 
            lblEindwaarde.AutoSize = true;
            lblEindwaarde.Location = new Point(32, 124);
            lblEindwaarde.Name = "lblEindwaarde";
            lblEindwaarde.Size = new Size(87, 20);
            lblEindwaarde.TabIndex = 2;
            lblEindwaarde.Text = "Eindwaarde";
            // 
            // txtSymbool
            // 
            txtSymbool.Location = new Point(179, 27);
            txtSymbool.Name = "txtSymbool";
            txtSymbool.Size = new Size(125, 27);
            txtSymbool.TabIndex = 3;
            // 
            // txtStartwaarde
            // 
            txtStartwaarde.Location = new Point(179, 73);
            txtStartwaarde.Name = "txtStartwaarde";
            txtStartwaarde.Size = new Size(125, 27);
            txtStartwaarde.TabIndex = 4;
            // 
            // txtEindwaarde
            // 
            txtEindwaarde.Location = new Point(179, 119);
            txtEindwaarde.Name = "txtEindwaarde";
            txtEindwaarde.Size = new Size(125, 27);
            txtEindwaarde.TabIndex = 5;
            // 
            // btnTeken
            // 
            btnTeken.Location = new Point(376, 76);
            btnTeken.Name = "btnTeken";
            btnTeken.Size = new Size(94, 29);
            btnTeken.TabIndex = 6;
            btnTeken.Text = "Teken";
            btnTeken.UseVisualStyleBackColor = true;
            btnTeken.Click += btnTeken_Click;
            // 
            // txtTeken
            // 
            txtTeken.Location = new Point(32, 168);
            txtTeken.Multiline = true;
            txtTeken.Name = "txtTeken";
            txtTeken.Size = new Size(272, 234);
            txtTeken.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTeken);
            Controls.Add(btnTeken);
            Controls.Add(txtEindwaarde);
            Controls.Add(txtStartwaarde);
            Controls.Add(txtSymbool);
            Controls.Add(lblEindwaarde);
            Controls.Add(lblStartwaarde);
            Controls.Add(lblSymbool);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSymbool;
        private Label lblStartwaarde;
        private Label lblEindwaarde;
        private TextBox txtSymbool;
        private TextBox txtStartwaarde;
        private TextBox txtEindwaarde;
        private Button btnTeken;
        private TextBox txtTeken;
    }
}
