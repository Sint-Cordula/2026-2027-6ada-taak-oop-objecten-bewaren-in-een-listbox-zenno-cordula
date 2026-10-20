namespace Menu_keuzes
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
            ckbSpaghetti = new CheckBox();
            ckbLasagna = new CheckBox();
            ckbVleesbrood = new CheckBox();
            ckbAppelmoes = new CheckBox();
            ckbMacaroni = new CheckBox();
            ckbTagliatelli = new CheckBox();
            ckbAardappelen = new CheckBox();
            ckbHamburger = new CheckBox();
            grpKeuzelijst = new GroupBox();
            lblKeuzeInfo = new Label();
            lblUwKeuzes = new Label();
            btnKeuzeTonen = new Button();
            grpKeuzelijst.SuspendLayout();
            SuspendLayout();
            // 
            // ckbSpaghetti
            // 
            ckbSpaghetti.AutoSize = true;
            ckbSpaghetti.Location = new Point(28, 26);
            ckbSpaghetti.Name = "ckbSpaghetti";
            ckbSpaghetti.Size = new Size(95, 24);
            ckbSpaghetti.TabIndex = 0;
            ckbSpaghetti.Text = "Spaghetti";
            ckbSpaghetti.UseVisualStyleBackColor = true;
            // 
            // ckbLasagna
            // 
            ckbLasagna.AutoSize = true;
            ckbLasagna.Location = new Point(28, 72);
            ckbLasagna.Name = "ckbLasagna";
            ckbLasagna.Size = new Size(85, 24);
            ckbLasagna.TabIndex = 1;
            ckbLasagna.Text = "Lasagna";
            ckbLasagna.UseVisualStyleBackColor = true;
            // 
            // ckbVleesbrood
            // 
            ckbVleesbrood.AutoSize = true;
            ckbVleesbrood.Location = new Point(28, 118);
            ckbVleesbrood.Name = "ckbVleesbrood";
            ckbVleesbrood.Size = new Size(107, 24);
            ckbVleesbrood.TabIndex = 2;
            ckbVleesbrood.Text = "Vleesbrood";
            ckbVleesbrood.UseVisualStyleBackColor = true;
            // 
            // ckbAppelmoes
            // 
            ckbAppelmoes.AutoSize = true;
            ckbAppelmoes.Location = new Point(28, 164);
            ckbAppelmoes.Name = "ckbAppelmoes";
            ckbAppelmoes.Size = new Size(107, 24);
            ckbAppelmoes.TabIndex = 3;
            ckbAppelmoes.Text = "Appelmoes";
            ckbAppelmoes.UseVisualStyleBackColor = true;
            // 
            // ckbMacaroni
            // 
            ckbMacaroni.AutoSize = true;
            ckbMacaroni.Location = new Point(168, 26);
            ckbMacaroni.Name = "ckbMacaroni";
            ckbMacaroni.Size = new Size(93, 24);
            ckbMacaroni.TabIndex = 4;
            ckbMacaroni.Text = "Macaroni";
            ckbMacaroni.UseVisualStyleBackColor = true;
            // 
            // ckbTagliatelli
            // 
            ckbTagliatelli.AutoSize = true;
            ckbTagliatelli.Location = new Point(168, 72);
            ckbTagliatelli.Name = "ckbTagliatelli";
            ckbTagliatelli.Size = new Size(95, 24);
            ckbTagliatelli.TabIndex = 5;
            ckbTagliatelli.Text = "Tagliatelli";
            ckbTagliatelli.UseVisualStyleBackColor = true;
            // 
            // ckbAardappelen
            // 
            ckbAardappelen.AutoSize = true;
            ckbAardappelen.Location = new Point(168, 118);
            ckbAardappelen.Name = "ckbAardappelen";
            ckbAardappelen.Size = new Size(117, 24);
            ckbAardappelen.TabIndex = 6;
            ckbAardappelen.Text = "Aardappelen";
            ckbAardappelen.UseVisualStyleBackColor = true;
            // 
            // ckbHamburger
            // 
            ckbHamburger.AutoSize = true;
            ckbHamburger.Location = new Point(168, 164);
            ckbHamburger.Name = "ckbHamburger";
            ckbHamburger.Size = new Size(107, 24);
            ckbHamburger.TabIndex = 7;
            ckbHamburger.Text = "Hamburger";
            ckbHamburger.UseVisualStyleBackColor = true;
            // 
            // grpKeuzelijst
            // 
            grpKeuzelijst.Controls.Add(ckbHamburger);
            grpKeuzelijst.Controls.Add(ckbAardappelen);
            grpKeuzelijst.Controls.Add(ckbTagliatelli);
            grpKeuzelijst.Controls.Add(ckbMacaroni);
            grpKeuzelijst.Controls.Add(ckbAppelmoes);
            grpKeuzelijst.Controls.Add(ckbVleesbrood);
            grpKeuzelijst.Controls.Add(ckbLasagna);
            grpKeuzelijst.Controls.Add(ckbSpaghetti);
            grpKeuzelijst.Location = new Point(20, 61);
            grpKeuzelijst.Name = "grpKeuzelijst";
            grpKeuzelijst.Size = new Size(291, 221);
            grpKeuzelijst.TabIndex = 8;
            grpKeuzelijst.TabStop = false;
            grpKeuzelijst.Text = "Keuzelijst";
            // 
            // lblKeuzeInfo
            // 
            lblKeuzeInfo.AutoSize = true;
            lblKeuzeInfo.Location = new Point(20, 15);
            lblKeuzeInfo.Name = "lblKeuzeInfo";
            lblKeuzeInfo.Size = new Size(262, 20);
            lblKeuzeInfo.TabIndex = 9;
            lblKeuzeInfo.Text = "Kies één of meerdere items uit de lijst.";
            // 
            // lblUwKeuzes
            // 
            lblUwKeuzes.AutoSize = true;
            lblUwKeuzes.Location = new Point(20, 298);
            lblUwKeuzes.Name = "lblUwKeuzes";
            lblUwKeuzes.Size = new Size(0, 20);
            lblUwKeuzes.TabIndex = 10;
            // 
            // btnKeuzeTonen
            // 
            btnKeuzeTonen.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnKeuzeTonen.Location = new Point(175, 294);
            btnKeuzeTonen.Name = "btnKeuzeTonen";
            btnKeuzeTonen.Size = new Size(136, 82);
            btnKeuzeTonen.TabIndex = 11;
            btnKeuzeTonen.Text = "Keuze Tonen";
            btnKeuzeTonen.UseVisualStyleBackColor = true;
            btnKeuzeTonen.Click += btnKeuzeTonen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 532);
            Controls.Add(btnKeuzeTonen);
            Controls.Add(lblUwKeuzes);
            Controls.Add(lblKeuzeInfo);
            Controls.Add(grpKeuzelijst);
            Name = "Form1";
            Text = "Menu met foreach";
            grpKeuzelijst.ResumeLayout(false);
            grpKeuzelijst.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ckbSpaghetti;
        private CheckBox ckbLasagna;
        private CheckBox ckbVleesbrood;
        private CheckBox ckbAppelmoes;
        private CheckBox ckbMacaroni;
        private CheckBox ckbTagliatelli;
        private CheckBox ckbAardappelen;
        private CheckBox ckbHamburger;
        private GroupBox grpKeuzelijst;
        private Label lblKeuzeInfo;
        private Label lblUwKeuzes;
        private Button btnKeuzeTonen;
    }
}
