namespace BG3_Mini_Tool
{
    partial class Form11
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
            button3 = new Button();
            Button1 = new Button();
            label1 = new Label();
            button4 = new Button();
            label5 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Location = new Point(58, 243);
            button3.Name = "button3";
            button3.Size = new Size(276, 65);
            button3.TabIndex = 35;
            button3.Text = "Add VFX to Custom Heads";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Button1
            // 
            Button1.AutoSize = true;
            Button1.Location = new Point(80, 76);
            Button1.Name = "Button1";
            Button1.Size = new Size(240, 65);
            Button1.TabIndex = 33;
            Button1.Text = "CCAV One Entry at a Time";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(88, 9);
            label1.Name = "label1";
            label1.Size = new Size(232, 29);
            label1.TabIndex = 36;
            label1.Text = "Character Creation";
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Location = new Point(23, 147);
            button4.Name = "button4";
            button4.Size = new Size(351, 65);
            button4.TabIndex = 37;
            button4.Text = "CCAV Entries for All, Short, Default and Strong";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(161, 215);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 38;
            label5.Text = "Other";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 48);
            label2.Name = "label2";
            label2.Size = new Size(407, 25);
            label2.TabIndex = 39;
            label2.Text = "CharacterCreationAppearanceVisuals\r\n";
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(403, 318);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(Button1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form11";
            Text = "Character Creation";
            FormClosing += Form11_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button Button1;
        private Label label1;
        private Button button4;
        private Label label5;
        private Label label2;
    }
}