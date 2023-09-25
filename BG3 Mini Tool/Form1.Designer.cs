
namespace BG3_Mini_Tool
{
    partial class Form1
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
            label1 = new Label();
            colorDialog1 = new ColorDialog();
            Button16 = new Button();
            Button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Button4 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 201);
            label1.Name = "label1";
            label1.Size = new Size(271, 25);
            label1.TabIndex = 5;
            label1.Text = "Character Customisation";
            // 
            // Button16
            // 
            Button16.AutoSize = true;
            Button16.Location = new Point(77, 152);
            Button16.Name = "Button16";
            Button16.Size = new Size(121, 41);
            Button16.TabIndex = 18;
            Button16.Text = "Meta";
            Button16.UseVisualStyleBackColor = true;
            Button16.Click += Button16_Click;
            // 
            // Button1
            // 
            Button1.AutoSize = true;
            Button1.Location = new Point(54, 229);
            Button1.Name = "Button1";
            Button1.Size = new Size(161, 65);
            Button1.TabIndex = 25;
            Button1.Text = "Character Creation\r\nAppearance Visuals\r\n";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 9);
            label2.Name = "label2";
            label2.Size = new Size(198, 31);
            label2.TabIndex = 27;
            label2.Text = "BG3 LSX Tool";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 124);
            label3.Name = "label3";
            label3.Size = new Size(237, 25);
            label3.TabIndex = 17;
            label3.Text = "Required for all mods";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(65, 40);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 28;
            label4.Text = "Home Page";
            // 
            // Button4
            // 
            Button4.AutoSize = true;
            Button4.Location = new Point(77, 361);
            Button4.Name = "Button4";
            Button4.Size = new Size(121, 41);
            Button4.TabIndex = 29;
            Button4.Text = "Extra Tools";
            Button4.UseVisualStyleBackColor = true;
            Button4.Click += Button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(42, 333);
            label5.Name = "label5";
            label5.Size = new Size(185, 25);
            label5.TabIndex = 30;
            label5.Text = "Tools Separated";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(286, 421);
            Controls.Add(label5);
            Controls.Add(Button4);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(Button1);
            Controls.Add(Button16);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Menu";
            Load += Form1_Load;
            Resize += Form1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ColorDialog colorDialog1;
        private Button Button16;
        private Button Button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Button4;
        private Label label5;
    }
}