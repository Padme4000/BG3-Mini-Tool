namespace BG3_Mod_Templates
{
    partial class Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tools));
            label2 = new Label();
            label7 = new Label();
            colorDialog1 = new ColorDialog();
            panelColorBox = new Panel();
            label1 = new Label();
            textBoxHex = new TextBox();
            textBoxSRGB = new TextBox();
            label3 = new Label();
            label4 = new Label();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label13 = new Label();
            textBoxVersion = new TextBox();
            label11 = new Label();
            Button7 = new Button();
            button13 = new Button();
            button1 = new Button();
            replace_uuid = new Button();
            replacehandles = new Button();
            label5 = new Label();
            button5 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(227, 9);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 16;
            label2.Text = "Extra Tools";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(76, 34);
            label7.MaximumSize = new Size(450, 0);
            label7.Name = "label7";
            label7.Size = new Size(433, 40);
            label7.TabIndex = 97;
            label7.Text = "A separate page for all the tools available on this exe in case you just want to use the tools and not the lsx editors\r\n";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelColorBox
            // 
            panelColorBox.BackColor = Color.FromArgb(128, 255, 255);
            panelColorBox.Location = new Point(386, 92);
            panelColorBox.Name = "panelColorBox";
            panelColorBox.Size = new Size(50, 50);
            panelColorBox.TabIndex = 98;
            panelColorBox.Click += panelColorBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 89);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 99;
            label1.Text = "Click to Select Colour:";
            // 
            // textBoxHex
            // 
            textBoxHex.Location = new Point(137, 114);
            textBoxHex.Margin = new Padding(4, 5, 4, 5);
            textBoxHex.Name = "textBoxHex";
            textBoxHex.Size = new Size(242, 26);
            textBoxHex.TabIndex = 100;
            textBoxHex.Text = "#80FFFF";
            textBoxHex.TextChanged += textBoxHex_TextChanged;
            // 
            // textBoxSRGB
            // 
            textBoxSRGB.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSRGB.Location = new Point(137, 150);
            textBoxSRGB.Margin = new Padding(4, 5, 4, 5);
            textBoxSRGB.Name = "textBoxSRGB";
            textBoxSRGB.Size = new Size(299, 24);
            textBoxSRGB.TabIndex = 101;
            textBoxSRGB.Text = "0.501961 1.000000 1.000000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 117);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 102;
            label3.Text = "Hex";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 153);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 103;
            label4.Text = "sRGB";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(272, 260);
            numericUpDown4.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(39, 26);
            numericUpDown4.TabIndex = 112;
            numericUpDown4.ValueChanged += numericUpDown4_ValueChanged_1;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(227, 259);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(39, 26);
            numericUpDown3.TabIndex = 111;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(182, 259);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(39, 26);
            numericUpDown2.TabIndex = 110;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(137, 259);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(39, 26);
            numericUpDown1.TabIndex = 109;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged_1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(317, 262);
            label13.Name = "label13";
            label13.Size = new Size(207, 20);
            label13.TabIndex = 108;
            label13.Text = "choose your version number";
            // 
            // textBoxVersion
            // 
            textBoxVersion.Location = new Point(137, 225);
            textBoxVersion.Margin = new Padding(4, 5, 4, 5);
            textBoxVersion.Name = "textBoxVersion";
            textBoxVersion.Size = new Size(174, 26);
            textBoxVersion.TabIndex = 107;
            textBoxVersion.Text = "36028797018963968";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 228);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(123, 20);
            label11.TabIndex = 105;
            label11.Text = "Version Number";
            // 
            // Button7
            // 
            Button7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Button7.Location = new Point(318, 223);
            Button7.Name = "Button7";
            Button7.Size = new Size(118, 31);
            Button7.TabIndex = 106;
            Button7.Text = "Save to";
            Button7.UseVisualStyleBackColor = true;
            Button7.Click += Button7_Click_1;
            // 
            // button13
            // 
            button13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(297, 182);
            button13.Name = "button13";
            button13.Size = new Size(118, 27);
            button13.TabIndex = 148;
            button13.Text = "Update Hex";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(137, 182);
            button1.Name = "button1";
            button1.Size = new Size(154, 27);
            button1.TabIndex = 149;
            button1.Text = "Copy to Clipboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // replace_uuid
            // 
            replace_uuid.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            replace_uuid.Location = new Point(171, 301);
            replace_uuid.Name = "replace_uuid";
            replace_uuid.Size = new Size(255, 57);
            replace_uuid.TabIndex = 150;
            replace_uuid.Text = "Mass Replace UUIDS";
            replace_uuid.UseVisualStyleBackColor = true;
            replace_uuid.Click += replace_uuid_Click;
            // 
            // replacehandles
            // 
            replacehandles.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            replacehandles.Location = new Point(171, 364);
            replacehandles.Name = "replacehandles";
            replacehandles.Size = new Size(255, 57);
            replacehandles.TabIndex = 151;
            replacehandles.Text = "Mass Replace handles";
            replacehandles.UseVisualStyleBackColor = true;
            replacehandles.Click += replace_handles_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(74, 424);
            label5.MaximumSize = new Size(450, 0);
            label5.Name = "label5";
            label5.Size = new Size(435, 140);
            label5.TabIndex = 152;
            label5.Text = resources.GetString("label5.Text");
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Click += label5_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(432, 376);
            button5.Name = "button5";
            button5.Size = new Size(44, 31);
            button5.TabIndex = 153;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(432, 313);
            button2.Name = "button2";
            button2.Size = new Size(44, 31);
            button2.TabIndex = 154;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(482, 313);
            button3.Name = "button3";
            button3.Size = new Size(44, 31);
            button3.TabIndex = 155;
            button3.Text = "??";
            button3.UseVisualStyleBackColor = true;
            // 
            // Tools
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(584, 571);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(replacehandles);
            Controls.Add(replace_uuid);
            Controls.Add(button1);
            Controls.Add(button13);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label13);
            Controls.Add(textBoxVersion);
            Controls.Add(Button7);
            Controls.Add(label11);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxSRGB);
            Controls.Add(textBoxHex);
            Controls.Add(label1);
            Controls.Add(panelColorBox);
            Controls.Add(label7);
            Controls.Add(label2);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Tools";
            Text = "Form8";
            FormClosing += Form8_FormClosing;
            Resize += Tools_Resize;
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label7;
        private ColorDialog colorDialog1;
        private Panel panelColorBox;
        private Label label1;
        private TextBox textBoxHex;
        private TextBox textBoxSRGB;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label13;
        private TextBox textBoxVersion;
        private Label label11;
        private Button Button7;
        private Button button13;
        private Button button1;
        private Button replace_uuid;
        private Button replacehandles;
        private Label label5;
        private Button button5;
        private Button button2;
        private Button button3;
    }
}