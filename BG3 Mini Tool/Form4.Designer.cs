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
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panelColorBox = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHex = new System.Windows.Forms.TextBox();
            this.textBoxSRGB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxVersion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(296, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tools";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(107, 34);
            this.label7.MaximumSize = new System.Drawing.Size(450, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(433, 40);
            this.label7.TabIndex = 97;
            this.label7.Text = "A separate page for all the tools available on this exe in case you just want to " +
    "use the tools and not the lsx editors\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelColorBox
            // 
            this.panelColorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelColorBox.Location = new System.Drawing.Point(417, 92);
            this.panelColorBox.Name = "panelColorBox";
            this.panelColorBox.Size = new System.Drawing.Size(50, 50);
            this.panelColorBox.TabIndex = 98;
            this.panelColorBox.Click += new System.EventHandler(this.panelColorBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 99;
            this.label1.Text = "Click to Select Colour:";
            // 
            // textBoxHex
            // 
            this.textBoxHex.Location = new System.Drawing.Point(168, 114);
            this.textBoxHex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxHex.Name = "textBoxHex";
            this.textBoxHex.Size = new System.Drawing.Size(242, 26);
            this.textBoxHex.TabIndex = 100;
            this.textBoxHex.Text = "#80FFFF";
            // 
            // textBoxSRGB
            // 
            this.textBoxSRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSRGB.Location = new System.Drawing.Point(168, 150);
            this.textBoxSRGB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSRGB.Name = "textBoxSRGB";
            this.textBoxSRGB.Size = new System.Drawing.Size(299, 24);
            this.textBoxSRGB.TabIndex = 101;
            this.textBoxSRGB.Text = "(0.501961, 1.000000, 1.000000, 1.000000)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 102;
            this.label3.Text = "Hex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 103;
            this.label4.Text = "sRGB";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(303, 219);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(39, 26);
            this.numericUpDown4.TabIndex = 112;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged_1);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(258, 218);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(39, 26);
            this.numericUpDown3.TabIndex = 111;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(213, 218);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(39, 26);
            this.numericUpDown2.TabIndex = 110;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(168, 218);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(39, 26);
            this.numericUpDown1.TabIndex = 109;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(348, 221);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(207, 20);
            this.label13.TabIndex = 108;
            this.label13.Text = "choose your version number";
            // 
            // textBoxVersion
            // 
            this.textBoxVersion.Location = new System.Drawing.Point(168, 184);
            this.textBoxVersion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxVersion.Name = "textBoxVersion";
            this.textBoxVersion.Size = new System.Drawing.Size(174, 26);
            this.textBoxVersion.TabIndex = 107;
            this.textBoxVersion.Text = "36028797018963968";
            this.textBoxVersion.TextChanged += new System.EventHandler(this.textBoxVersion_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 187);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 20);
            this.label11.TabIndex = 105;
            this.label11.Text = "Version Number";
            // 
            // Button7
            // 
            this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button7.Location = new System.Drawing.Point(349, 182);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(118, 31);
            this.Button7.TabIndex = 106;
            this.Button7.Text = "Save to";
            this.Button7.UseVisualStyleBackColor = true;
            // 
            // Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(682, 310);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxVersion);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSRGB);
            this.Controls.Add(this.textBoxHex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelColorBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Tools";
            this.Text = "Form8";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form8_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panelColorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHex;
        private System.Windows.Forms.TextBox textBoxSRGB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label13;
        private TextBox textBoxVersion;
        private Label label11;
        private Button Button7;
    }
}