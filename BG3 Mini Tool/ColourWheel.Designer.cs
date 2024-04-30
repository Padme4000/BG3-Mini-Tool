namespace BG3_Mini_Tool
{
    partial class ColourWheel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button4 = new Button();
            button1 = new Button();
            button13 = new Button();
            label4 = new Label();
            label3 = new Label();
            textBoxSRGB = new TextBox();
            textBoxHex = new TextBox();
            label1 = new Label();
            panelColorBox = new Panel();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(389, 106);
            button4.Name = "button4";
            button4.Size = new Size(44, 31);
            button4.TabIndex = 165;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(84, 215);
            button1.Name = "button1";
            button1.Size = new Size(154, 27);
            button1.TabIndex = 164;
            button1.Text = "Copy to Clipboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(244, 215);
            button13.Name = "button13";
            button13.Size = new Size(118, 27);
            button13.TabIndex = 163;
            button13.Text = "Update Hex";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 186);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 162;
            label4.Text = "sRGB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 117);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 161;
            label3.Text = "Hex";
            // 
            // textBoxSRGB
            // 
            textBoxSRGB.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSRGB.Location = new Point(84, 183);
            textBoxSRGB.Margin = new Padding(4, 5, 4, 5);
            textBoxSRGB.Name = "textBoxSRGB";
            textBoxSRGB.Size = new Size(299, 24);
            textBoxSRGB.TabIndex = 160;
            textBoxSRGB.Text = "0.501961 1.000000 1.000000";
            // 
            // textBoxHex
            // 
            textBoxHex.Location = new Point(84, 114);
            textBoxHex.Margin = new Padding(4, 5, 4, 5);
            textBoxHex.Name = "textBoxHex";
            textBoxHex.Size = new Size(242, 26);
            textBoxHex.TabIndex = 159;
            textBoxHex.Text = "#80FFFF";
            textBoxHex.TextChanged += textBoxHex_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 89);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 158;
            label1.Text = "Click to Select Colour:";
            // 
            // panelColorBox
            // 
            panelColorBox.BackColor = Color.FromArgb(128, 255, 255);
            panelColorBox.Location = new Point(333, 92);
            panelColorBox.Name = "panelColorBox";
            panelColorBox.Size = new Size(50, 50);
            panelColorBox.TabIndex = 157;
            panelColorBox.Click += panelColorBox_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(123, 29);
            label2.Name = "label2";
            label2.Size = new Size(189, 31);
            label2.TabIndex = 166;
            label2.Text = "Colour Wheel";
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(84, 148);
            button2.Name = "button2";
            button2.Size = new Size(154, 27);
            button2.TabIndex = 167;
            button2.Text = "Copy to Clipboard";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ColourWheel
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(455, 262);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(button13);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxSRGB);
            Controls.Add(textBoxHex);
            Controls.Add(label1);
            Controls.Add(panelColorBox);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ColourWheel";
            Text = "ColourWheel";
            FormClosing += ColourWheel_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button1;
        private Button button13;
        private Label label4;
        private Label label3;
        private TextBox textBoxSRGB;
        private TextBox textBoxHex;
        private Label label1;
        private Panel panelColorBox;
        private Label label2;
        private Button button2;
    }
}