namespace Defecte_pc
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
            lblWerkendePC = new Label();
            lstWerkendePC = new ListBox();
            lstDefectePC = new ListBox();
            lblDefectePC = new Label();
            btnWerkendNaarDefect = new Button();
            btnDefectNaarWerkend = new Button();
            SuspendLayout();
            // 
            // lblWerkendePC
            // 
            lblWerkendePC.AutoSize = true;
            lblWerkendePC.Location = new Point(13, 25);
            lblWerkendePC.Name = "lblWerkendePC";
            lblWerkendePC.Size = new Size(105, 20);
            lblWerkendePC.TabIndex = 0;
            lblWerkendePC.Text = "Werkende PC's";
            // 
            // lstWerkendePC
            // 
            lstWerkendePC.FormattingEnabled = true;
            lstWerkendePC.Location = new Point(13, 62);
            lstWerkendePC.Name = "lstWerkendePC";
            lstWerkendePC.Size = new Size(153, 304);
            lstWerkendePC.TabIndex = 1;
            // 
            // lstDefectePC
            // 
            lstDefectePC.FormattingEnabled = true;
            lstDefectePC.Location = new Point(612, 62);
            lstDefectePC.Name = "lstDefectePC";
            lstDefectePC.Size = new Size(153, 304);
            lstDefectePC.TabIndex = 2;
            // 
            // lblDefectePC
            // 
            lblDefectePC.AutoSize = true;
            lblDefectePC.Location = new Point(674, 25);
            lblDefectePC.Name = "lblDefectePC";
            lblDefectePC.Size = new Size(91, 20);
            lblDefectePC.TabIndex = 3;
            lblDefectePC.Text = "Defecte PC's";
            // 
            // btnWerkendNaarDefect
            // 
            btnWerkendNaarDefect.Font = new Font("Segoe UI", 15F);
            btnWerkendNaarDefect.Location = new Point(349, 161);
            btnWerkendNaarDefect.Name = "btnWerkendNaarDefect";
            btnWerkendNaarDefect.Size = new Size(79, 45);
            btnWerkendNaarDefect.TabIndex = 4;
            btnWerkendNaarDefect.Text = "-->";
            btnWerkendNaarDefect.UseVisualStyleBackColor = true;
            btnWerkendNaarDefect.Click += btnWerkendNaarDefect_Click;
            // 
            // btnDefectNaarWerkend
            // 
            btnDefectNaarWerkend.Font = new Font("Segoe UI", 15F);
            btnDefectNaarWerkend.Location = new Point(349, 212);
            btnDefectNaarWerkend.Name = "btnDefectNaarWerkend";
            btnDefectNaarWerkend.Size = new Size(79, 45);
            btnDefectNaarWerkend.TabIndex = 5;
            btnDefectNaarWerkend.Text = "<--";
            btnDefectNaarWerkend.UseVisualStyleBackColor = true;
            btnDefectNaarWerkend.Click += btnDefectNaarWerkend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDefectNaarWerkend);
            Controls.Add(btnWerkendNaarDefect);
            Controls.Add(lblDefectePC);
            Controls.Add(lstDefectePC);
            Controls.Add(lstWerkendePC);
            Controls.Add(lblWerkendePC);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWerkendePC;
        private ListBox lstWerkendePC;
        private ListBox lstDefectePC;
        private Label lblDefectePC;
        private Button btnWerkendNaarDefect;
        private Button btnDefectNaarWerkend;
    }
}
