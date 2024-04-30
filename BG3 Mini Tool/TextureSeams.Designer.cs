namespace BG3_Mini_Tool
{
    partial class TextureSeams
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            buttonCLEA = new Button();
            buttonHMVY = new Button();
            buttonNM = new Button();
            button5 = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 23);
            label2.Name = "label2";
            label2.Size = new Size(376, 31);
            label2.TabIndex = 167;
            label2.Text = "Texture Map Seam Transfer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 84);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 177;
            label5.Text = "CLEA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 127);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 178;
            label6.Text = "HMVY";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(68, 170);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(33, 20);
            label7.TabIndex = 179;
            label7.Text = "NM";
            // 
            // buttonCLEA
            // 
            buttonCLEA.AutoSize = true;
            buttonCLEA.Location = new Point(108, 76);
            buttonCLEA.Name = "buttonCLEA";
            buttonCLEA.Size = new Size(286, 37);
            buttonCLEA.TabIndex = 180;
            buttonCLEA.Text = "Transfer Seam for CLEA";
            buttonCLEA.UseVisualStyleBackColor = true;
            buttonCLEA.Click += buttonCLEA_Click;
            // 
            // buttonHMVY
            // 
            buttonHMVY.AutoSize = true;
            buttonHMVY.Location = new Point(108, 119);
            buttonHMVY.Name = "buttonHMVY";
            buttonHMVY.Size = new Size(286, 37);
            buttonHMVY.TabIndex = 181;
            buttonHMVY.Text = "Transfer Seam for HMVY";
            buttonHMVY.UseVisualStyleBackColor = true;
            buttonHMVY.Click += buttonHMVY_Click;
            // 
            // buttonNM
            // 
            buttonNM.AutoSize = true;
            buttonNM.Location = new Point(108, 162);
            buttonNM.Name = "buttonNM";
            buttonNM.Size = new Size(286, 37);
            buttonNM.TabIndex = 182;
            buttonNM.Text = "Transfer Seam for NM";
            buttonNM.UseVisualStyleBackColor = true;
            buttonNM.Click += buttonNM_Click;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.Location = new Point(108, 205);
            button5.Name = "button5";
            button5.Size = new Size(286, 37);
            button5.TabIndex = 184;
            button5.Text = "Transfer Seam for MSK";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonMSK_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(59, 213);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 183;
            label8.Text = "MSK";
            // 
            // TextureSeams
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(460, 273);
            Controls.Add(button5);
            Controls.Add(label8);
            Controls.Add(buttonNM);
            Controls.Add(buttonHMVY);
            Controls.Add(buttonCLEA);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "TextureSeams";
            Text = "TextureSeams";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button buttonCLEA;
        private Button buttonHMVY;
        private Button buttonNM;
        private Button button5;
        private Label label8;
    }
}