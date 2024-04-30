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
            label2 = new Label();
            label7 = new Label();
            colorDialog1 = new ColorDialog();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label13 = new Label();
            textBoxVersion = new TextBox();
            label11 = new Label();
            Button7 = new Button();
            Button4 = new Button();
            button1 = new Button();
            button6 = new Button();
            label1 = new Label();
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
            label2.Location = new Point(198, 9);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 16;
            label2.Text = "Extra Tools";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(47, 34);
            label7.MaximumSize = new Size(450, 0);
            label7.Name = "label7";
            label7.Size = new Size(433, 40);
            label7.TabIndex = 97;
            label7.Text = "A separate page for all the tools available on this exe in case you just want to use the tools and not the lsx editors\r\n";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(268, 320);
            numericUpDown4.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(39, 26);
            numericUpDown4.TabIndex = 112;
            numericUpDown4.ValueChanged += numericUpDown4_ValueChanged_1;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(223, 319);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(39, 26);
            numericUpDown3.TabIndex = 111;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(178, 319);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(39, 26);
            numericUpDown2.TabIndex = 110;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(133, 319);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(39, 26);
            numericUpDown1.TabIndex = 109;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged_1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(313, 322);
            label13.Name = "label13";
            label13.Size = new Size(207, 20);
            label13.TabIndex = 108;
            label13.Text = "choose your version number";
            // 
            // textBoxVersion
            // 
            textBoxVersion.Location = new Point(133, 285);
            textBoxVersion.Margin = new Padding(4, 5, 4, 5);
            textBoxVersion.Name = "textBoxVersion";
            textBoxVersion.Size = new Size(174, 26);
            textBoxVersion.TabIndex = 107;
            textBoxVersion.Text = "36028797018963968";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(2, 288);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(123, 20);
            label11.TabIndex = 105;
            label11.Text = "Version Number";
            // 
            // Button7
            // 
            Button7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Button7.Location = new Point(314, 283);
            Button7.Name = "Button7";
            Button7.Size = new Size(118, 31);
            Button7.TabIndex = 106;
            Button7.Text = "Save to";
            Button7.UseVisualStyleBackColor = true;
            Button7.Click += Button7_Click_1;
            // 
            // Button4
            // 
            Button4.AutoSize = true;
            Button4.Location = new Point(71, 89);
            Button4.Name = "Button4";
            Button4.Size = new Size(387, 41);
            Button4.TabIndex = 156;
            Button4.Text = "Colour Wheel - Hex/sRGB Converter";
            Button4.UseVisualStyleBackColor = true;
            Button4.Click += Button4_Click_1;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(71, 136);
            button1.Name = "button1";
            button1.Size = new Size(387, 41);
            button1.TabIndex = 157;
            button1.Text = "Texture Map Seam Transfer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.Location = new Point(71, 183);
            button6.Name = "button6";
            button6.Size = new Size(387, 41);
            button6.TabIndex = 158;
            button6.Text = "Mass Replace UUIDs/Handles";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(164, 244);
            label1.Name = "label1";
            label1.Size = new Size(206, 25);
            label1.TabIndex = 159;
            label1.Text = "Version Calculator";
            // 
            // Tools
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(527, 375);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(Button4);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label13);
            Controls.Add(textBoxVersion);
            Controls.Add(Button7);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(label2);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Tools";
            Text = "Extra Tools";
            FormClosing += Form4_FormClosing;
            Load += Tools_Load;
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
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label13;
        private TextBox textBoxVersion;
        private Label label11;
        private Button Button7;
        private Button Button4;
        private Button button1;
        private Button button6;
        private Label label1;
    }
}