namespace BG3_Mini_Tool
{
    partial class MassReplace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MassReplace));
            button3 = new Button();
            button2 = new Button();
            label5 = new Label();
            replacehandles = new Button();
            replace_uuid = new Button();
            label2 = new Label();
            button1 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(423, 117);
            button3.Name = "button3";
            button3.Size = new Size(44, 31);
            button3.TabIndex = 161;
            button3.Text = "??";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(373, 117);
            button2.Name = "button2";
            button2.Size = new Size(44, 31);
            button2.TabIndex = 160;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(32, 193);
            label5.MaximumSize = new Size(450, 0);
            label5.Name = "label5";
            label5.Size = new Size(435, 140);
            label5.TabIndex = 158;
            label5.Text = resources.GetString("label5.Text");
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // replacehandles
            // 
            replacehandles.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            replacehandles.Location = new Point(112, 133);
            replacehandles.Name = "replacehandles";
            replacehandles.Size = new Size(255, 57);
            replacehandles.TabIndex = 157;
            replacehandles.Text = "Mass Replace handles";
            replacehandles.UseVisualStyleBackColor = true;
            replacehandles.Click += replace_handles_Click;
            // 
            // replace_uuid
            // 
            replace_uuid.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            replace_uuid.Location = new Point(112, 70);
            replace_uuid.Name = "replace_uuid";
            replace_uuid.Size = new Size(255, 57);
            replace_uuid.TabIndex = 156;
            replace_uuid.Text = "Mass Replace UUIDS";
            replace_uuid.UseVisualStyleBackColor = true;
            replace_uuid.Click += replace_uuid_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(80, 21);
            label2.Name = "label2";
            label2.Size = new Size(327, 25);
            label2.TabIndex = 162;
            label2.Text = "Mass Replace UUIDs/Handles";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(112, 349);
            button1.Name = "button1";
            button1.Size = new Size(255, 57);
            button1.TabIndex = 163;
            button1.Text = "Generate Unique UUIDs\r\nfor UUID line only";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(373, 361);
            button4.Name = "button4";
            button4.Size = new Size(44, 31);
            button4.TabIndex = 164;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // MassReplace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(496, 422);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(replacehandles);
            Controls.Add(replace_uuid);
            Name = "MassReplace";
            Text = "MassReplace";
            FormClosing += MassReplace_FormClosing;
            FormClosed += MassReplace_FormClosed;
            Load += MassReplace_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Label label5;
        private Button replacehandles;
        private Button replace_uuid;
        private Label label2;
        private Button button1;
        private Button button4;
    }
}