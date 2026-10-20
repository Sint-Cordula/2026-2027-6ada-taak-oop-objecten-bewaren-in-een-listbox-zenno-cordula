namespace Steam_Calculator
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
            lblGameName = new Label();
            txtGameName = new TextBox();
            lblPrijsGame = new Label();
            lblUrenGame = new Label();
            txtPrijs = new TextBox();
            txtUren = new TextBox();
            lstGames = new ListBox();
            btnToevoegen = new Button();
            lblSelectedGame = new Label();
            lblSelectedPrijs = new Label();
            lblSelectedUren = new Label();
            lblPrijsPerUur = new Label();
            btnBereken = new Button();
            lblGame = new Label();
            lblPrijs = new Label();
            lblUren = new Label();
            btnTotalCalculator = new Button();
            lblTotalCalculated = new Label();
            SuspendLayout();
            // 
            // lblGameName
            // 
            lblGameName.AutoSize = true;
            lblGameName.Location = new Point(21, 23);
            lblGameName.Name = "lblGameName";
            lblGameName.Size = new Size(92, 20);
            lblGameName.TabIndex = 0;
            lblGameName.Text = "Game name:";
            // 
            // txtGameName
            // 
            txtGameName.Location = new Point(117, 20);
            txtGameName.Name = "txtGameName";
            txtGameName.Size = new Size(125, 27);
            txtGameName.TabIndex = 1;
            // 
            // lblPrijsGame
            // 
            lblPrijsGame.AutoSize = true;
            lblPrijsGame.Location = new Point(21, 64);
            lblPrijsGame.Name = "lblPrijsGame";
            lblPrijsGame.Size = new Size(39, 20);
            lblPrijsGame.TabIndex = 2;
            lblPrijsGame.Text = "Prijs:";
            // 
            // lblUrenGame
            // 
            lblUrenGame.AutoSize = true;
            lblUrenGame.Location = new Point(21, 104);
            lblUrenGame.Name = "lblUrenGame";
            lblUrenGame.Size = new Size(43, 20);
            lblUrenGame.TabIndex = 3;
            lblUrenGame.Text = "Uren:";
            // 
            // txtPrijs
            // 
            txtPrijs.Location = new Point(117, 61);
            txtPrijs.Name = "txtPrijs";
            txtPrijs.Size = new Size(125, 27);
            txtPrijs.TabIndex = 4;
            // 
            // txtUren
            // 
            txtUren.Location = new Point(117, 101);
            txtUren.Name = "txtUren";
            txtUren.Size = new Size(125, 27);
            txtUren.TabIndex = 5;
            // 
            // lstGames
            // 
            lstGames.FormattingEnabled = true;
            lstGames.Location = new Point(21, 140);
            lstGames.Name = "lstGames";
            lstGames.Size = new Size(221, 264);
            lstGames.TabIndex = 6;
            lstGames.SelectedIndexChanged += lstGames_SelectedIndexChanged;
            // 
            // btnToevoegen
            // 
            btnToevoegen.Location = new Point(248, 60);
            btnToevoegen.Name = "btnToevoegen";
            btnToevoegen.Size = new Size(94, 29);
            btnToevoegen.TabIndex = 7;
            btnToevoegen.Text = "Toevoegen";
            btnToevoegen.UseVisualStyleBackColor = true;
            btnToevoegen.Click += btnToevoegen_Click;
            // 
            // lblSelectedGame
            // 
            lblSelectedGame.AutoSize = true;
            lblSelectedGame.Location = new Point(334, 140);
            lblSelectedGame.Name = "lblSelectedGame";
            lblSelectedGame.Size = new Size(0, 20);
            lblSelectedGame.TabIndex = 8;
            // 
            // lblSelectedPrijs
            // 
            lblSelectedPrijs.AutoSize = true;
            lblSelectedPrijs.Location = new Point(334, 172);
            lblSelectedPrijs.Name = "lblSelectedPrijs";
            lblSelectedPrijs.Size = new Size(0, 20);
            lblSelectedPrijs.TabIndex = 9;
            // 
            // lblSelectedUren
            // 
            lblSelectedUren.AutoSize = true;
            lblSelectedUren.Location = new Point(334, 204);
            lblSelectedUren.Name = "lblSelectedUren";
            lblSelectedUren.Size = new Size(0, 20);
            lblSelectedUren.TabIndex = 10;
            // 
            // lblPrijsPerUur
            // 
            lblPrijsPerUur.AutoSize = true;
            lblPrijsPerUur.Location = new Point(248, 285);
            lblPrijsPerUur.Name = "lblPrijsPerUur";
            lblPrijsPerUur.Size = new Size(0, 20);
            lblPrijsPerUur.TabIndex = 11;
            // 
            // btnBereken
            // 
            btnBereken.Location = new Point(248, 242);
            btnBereken.Name = "btnBereken";
            btnBereken.Size = new Size(205, 29);
            btnBereken.TabIndex = 12;
            btnBereken.Text = "Get dissapointed in your life";
            btnBereken.UseVisualStyleBackColor = true;
            btnBereken.Click += btnBereken_Click;
            // 
            // lblGame
            // 
            lblGame.AutoSize = true;
            lblGame.Location = new Point(248, 140);
            lblGame.Name = "lblGame";
            lblGame.Size = new Size(51, 20);
            lblGame.TabIndex = 13;
            lblGame.Text = "Game:";
            // 
            // lblPrijs
            // 
            lblPrijs.AutoSize = true;
            lblPrijs.Location = new Point(248, 174);
            lblPrijs.Name = "lblPrijs";
            lblPrijs.Size = new Size(51, 20);
            lblPrijs.TabIndex = 14;
            lblPrijs.Text = "Prijs: €";
            // 
            // lblUren
            // 
            lblUren.AutoSize = true;
            lblUren.Location = new Point(248, 208);
            lblUren.Name = "lblUren";
            lblUren.Size = new Size(43, 20);
            lblUren.TabIndex = 15;
            lblUren.Text = "Uren:";
            // 
            // btnTotalCalculator
            // 
            btnTotalCalculator.Location = new Point(248, 317);
            btnTotalCalculator.Name = "btnTotalCalculator";
            btnTotalCalculator.Size = new Size(94, 29);
            btnTotalCalculator.TabIndex = 16;
            btnTotalCalculator.Text = "Start crying";
            btnTotalCalculator.UseVisualStyleBackColor = true;
            btnTotalCalculator.Click += btnTotalCalculator_Click;
            // 
            // lblTotalCalculated
            // 
            lblTotalCalculated.AutoSize = true;
            lblTotalCalculated.Location = new Point(248, 360);
            lblTotalCalculated.Name = "lblTotalCalculated";
            lblTotalCalculated.Size = new Size(0, 20);
            lblTotalCalculated.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotalCalculated);
            Controls.Add(btnTotalCalculator);
            Controls.Add(lblUren);
            Controls.Add(lblPrijs);
            Controls.Add(lblGame);
            Controls.Add(btnBereken);
            Controls.Add(lblPrijsPerUur);
            Controls.Add(lblSelectedUren);
            Controls.Add(lblSelectedPrijs);
            Controls.Add(lblSelectedGame);
            Controls.Add(btnToevoegen);
            Controls.Add(lstGames);
            Controls.Add(txtUren);
            Controls.Add(txtPrijs);
            Controls.Add(lblUrenGame);
            Controls.Add(lblPrijsGame);
            Controls.Add(txtGameName);
            Controls.Add(lblGameName);
            Name = "Form1";
            Text = "Game Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGameName;
        private TextBox txtGameName;
        private Label lblPrijsGame;
        private Label lblUrenGame;
        private TextBox txtPrijs;
        private TextBox txtUren;
        private ListBox lstGames;
        private Button btnToevoegen;
        private Label lblSelectedGame;
        private Label lblSelectedPrijs;
        private Label lblSelectedUren;
        private Label lblPrijsPerUur;
        private Button btnBereken;
        private Label lblGame;
        private Label lblPrijs;
        private Label lblUren;
        private Button btnTotalCalculator;
        private Label lblTotalCalculated;
    }
}
