namespace BG3_Mod_Templates
{
    partial class Form7
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
            label5 = new Label();
            Button14 = new Button();
            Button7 = new Button();
            Button8 = new Button();
            Button9 = new Button();
            Button10 = new Button();
            Button11 = new Button();
            Button12 = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(116, 9);
            label5.Name = "label5";
            label5.Size = new Size(132, 25);
            label5.TabIndex = 37;
            label5.Text = "CC Colours";
            // 
            // Button14
            // 
            Button14.Location = new Point(39, 50);
            Button14.Name = "Button14";
            Button14.Size = new Size(150, 41);
            Button14.TabIndex = 36;
            Button14.Text = "Makeup Colour";
            Button14.UseVisualStyleBackColor = true;
            // 
            // Button7
            // 
            Button7.Location = new Point(39, 97);
            Button7.Name = "Button7";
            Button7.Size = new Size(150, 41);
            Button7.TabIndex = 38;
            Button7.Text = "Skin";
            Button7.UseVisualStyleBackColor = true;
            // 
            // Button8
            // 
            Button8.Location = new Point(195, 50);
            Button8.Name = "Button8";
            Button8.Size = new Size(150, 41);
            Button8.TabIndex = 39;
            Button8.Text = "Tattoo Colour";
            Button8.UseVisualStyleBackColor = true;
            // 
            // Button9
            // 
            Button9.Location = new Point(195, 97);
            Button9.Name = "Button9";
            Button9.Size = new Size(150, 41);
            Button9.TabIndex = 40;
            Button9.Text = "Eye Colour";
            Button9.UseVisualStyleBackColor = true;
            // 
            // Button10
            // 
            Button10.Location = new Point(39, 144);
            Button10.Name = "Button10";
            Button10.Size = new Size(150, 41);
            Button10.TabIndex = 41;
            Button10.Text = "Hair Colour";
            Button10.UseVisualStyleBackColor = true;
            // 
            // Button11
            // 
            Button11.Location = new Point(195, 144);
            Button11.Name = "Button11";
            Button11.Size = new Size(150, 41);
            Button11.TabIndex = 42;
            Button11.Text = "Highlight Colour";
            Button11.UseVisualStyleBackColor = true;
            // 
            // Button12
            // 
            Button12.Location = new Point(116, 191);
            Button12.Name = "Button12";
            Button12.Size = new Size(150, 41);
            Button12.TabIndex = 43;
            Button12.Text = "Greying Colour";
            Button12.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(384, 254);
            Controls.Add(Button12);
            Controls.Add(Button11);
            Controls.Add(Button10);
            Controls.Add(Button9);
            Controls.Add(Button8);
            Controls.Add(Button7);
            Controls.Add(label5);
            Controls.Add(Button14);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form7";
            Text = "CC Colours";
            FormClosing += Form7_FormClosing;
            Load += Form7_Load;
            Resize += Form7_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Button Button14;
        private Button Button7;
        private Button Button8;
        private Button Button9;
        private Button Button10;
        private Button Button11;
        private Button Button12;
    }
}