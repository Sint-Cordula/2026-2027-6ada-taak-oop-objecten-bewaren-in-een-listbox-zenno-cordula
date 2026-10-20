namespace Sandbox
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
            lblHelloWorld = new Label();
            btnMelding = new Button();
            txtInput = new TextBox();
            pictureBox1 = new PictureBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.AutoSize = true;
            lblHelloWorld.Font = new Font("Segoe UI", 25F, FontStyle.Bold | FontStyle.Underline);
            lblHelloWorld.Location = new Point(19, 24);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(264, 57);
            lblHelloWorld.TabIndex = 0;
            lblHelloWorld.Text = "Hello World";
            lblHelloWorld.Click += label1_Click;
            // 
            // btnMelding
            // 
            btnMelding.Font = new Font("Segoe UI", 20F);
            btnMelding.Location = new Point(12, 84);
            btnMelding.Name = "btnMelding";
            btnMelding.Size = new Size(200, 100);
            btnMelding.TabIndex = 1;
            btnMelding.Text = "Klik hier";
            btnMelding.UseVisualStyleBackColor = true;
            btnMelding.Click += btnMelding_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(24, 219);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(125, 27);
            txtInput.TabIndex = 2;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(231, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(337, 296);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(611, 120);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(77, 24);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "optie 1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(611, 160);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(77, 24);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "optie 2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(611, 200);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(77, 24);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "optie 3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(145, 130);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(90, 24);
            radioButton4.TabIndex = 9;
            radioButton4.TabStop = true;
            radioButton4.Text = "Ik kom ni";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(145, 90);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(57, 24);
            radioButton5.TabIndex = 8;
            radioButton5.TabStop = true;
            radioButton5.Text = "Nee";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(145, 50);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(43, 24);
            radioButton6.TabIndex = 7;
            radioButton6.TabStop = true;
            radioButton6.Text = "Ja";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Location = new Point(702, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(252, 176);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "LO op woensdag?";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(550, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 450);
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(pictureBox1);
            Controls.Add(txtInput);
            Controls.Add(btnMelding);
            Controls.Add(lblHelloWorld);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHelloWorld;
        private Button btnMelding;
        private TextBox txtInput;
        private PictureBox pictureBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
    }
}
