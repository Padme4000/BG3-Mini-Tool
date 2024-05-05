namespace BG3_Mini_Tool
{
    partial class Form5
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
            button10 = new Button();
            button11 = new Button();
            label14 = new Label();
            button5 = new Button();
            label10 = new Label();
            textBox1 = new TextBox();
            button4 = new Button();
            Update_name = new Button();
            label1 = new Label();
            textBoxNameHandle = new TextBox();
            Button_locatexml = new Button();
            textBoxpath = new TextBox();
            label8 = new Label();
            ButtonCreateFolders = new Button();
            ButtonSelectFolder = new Button();
            label16 = new Label();
            label18 = new Label();
            label19 = new Label();
            FolderEnglish = new TextBox();
            FolderLocalization = new TextBox();
            FolderModName = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button12 = new Button();
            SuspendLayout();
            // 
            // button10
            // 
            button10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(22, 334);
            button10.Name = "button10";
            button10.Size = new Size(140, 31);
            button10.TabIndex = 153;
            button10.Text = "Save as";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(22, 297);
            button11.Name = "button11";
            button11.Size = new Size(173, 31);
            button11.TabIndex = 152;
            button11.Text = "Add to your mod file";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(422, 21);
            label14.Name = "label14";
            label14.Size = new Size(208, 25);
            label14.TabIndex = 151;
            label14.Text = "Localization Editor";
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(489, 187);
            button5.Name = "button5";
            button5.Size = new Size(69, 31);
            button5.TabIndex = 150;
            button5.Text = "Update";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 191);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(106, 20);
            label10.TabIndex = 149;
            label10.Text = "Display Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 188);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(348, 26);
            textBox1.TabIndex = 148;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(564, 150);
            button4.Name = "button4";
            button4.Size = new Size(219, 31);
            button4.TabIndex = 147;
            button4.Text = "Generate Unique Handle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Update_name
            // 
            Update_name.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Update_name.Location = new Point(489, 150);
            Update_name.Name = "Update_name";
            Update_name.Size = new Size(69, 31);
            Update_name.TabIndex = 146;
            Update_name.Text = "Update";
            Update_name.UseVisualStyleBackColor = true;
            Update_name.Click += Update_name_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 154);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 145;
            label1.Text = "Name Handle";
            // 
            // textBoxNameHandle
            // 
            textBoxNameHandle.Location = new Point(134, 151);
            textBoxNameHandle.Margin = new Padding(4, 5, 4, 5);
            textBoxNameHandle.Multiline = true;
            textBoxNameHandle.Name = "textBoxNameHandle";
            textBoxNameHandle.Size = new Size(348, 26);
            textBoxNameHandle.TabIndex = 144;
            textBoxNameHandle.Click += textBoxNameHandle_Click;
            // 
            // Button_locatexml
            // 
            Button_locatexml.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Button_locatexml.Location = new Point(22, 260);
            Button_locatexml.Name = "Button_locatexml";
            Button_locatexml.Size = new Size(458, 31);
            Button_locatexml.TabIndex = 155;
            Button_locatexml.Text = "Locate your Localization xml\r\n";
            Button_locatexml.UseVisualStyleBackColor = true;
            Button_locatexml.Click += Button_locateLSX_Click;
            // 
            // textBoxpath
            // 
            textBoxpath.Location = new Point(22, 226);
            textBoxpath.Margin = new Padding(4, 5, 4, 5);
            textBoxpath.Name = "textBoxpath";
            textBoxpath.Size = new Size(1011, 26);
            textBoxpath.TabIndex = 154;
            textBoxpath.Text = "Path to your mod file including the name of the lsx. This is so when you click \"Add to your mod file\" your new entry is added to your file";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(130, 126);
            label8.Name = "label8";
            label8.Size = new Size(824, 20);
            label8.TabIndex = 164;
            label8.Text = "Fill in or use the Check Mod Folder Button to check if your mod folder includes the folder for the Localization xml/loca";
            // 
            // ButtonCreateFolders
            // 
            ButtonCreateFolders.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonCreateFolders.Location = new Point(717, 79);
            ButtonCreateFolders.Name = "ButtonCreateFolders";
            ButtonCreateFolders.Size = new Size(105, 44);
            ButtonCreateFolders.TabIndex = 163;
            ButtonCreateFolders.Text = "Create Folders";
            ButtonCreateFolders.UseVisualStyleBackColor = true;
            ButtonCreateFolders.Click += ButtonCreateFolders_Click;
            // 
            // ButtonSelectFolder
            // 
            ButtonSelectFolder.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSelectFolder.Location = new Point(614, 79);
            ButtonSelectFolder.Name = "ButtonSelectFolder";
            ButtonSelectFolder.Size = new Size(97, 44);
            ButtonSelectFolder.TabIndex = 162;
            ButtonSelectFolder.Text = "Check Mod Folder";
            ButtonSelectFolder.UseVisualStyleBackColor = true;
            ButtonSelectFolder.Click += ButtonSelectFolder_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(35, 93);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(91, 20);
            label16.TabIndex = 161;
            label16.Text = "Folder Path";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(475, 93);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(17, 20);
            label18.TabIndex = 160;
            label18.Text = "\\\\";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(334, 93);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(17, 20);
            label19.TabIndex = 159;
            label19.Text = "\\\\";
            // 
            // FolderEnglish
            // 
            FolderEnglish.Location = new Point(500, 90);
            FolderEnglish.Margin = new Padding(4, 5, 4, 5);
            FolderEnglish.Name = "FolderEnglish";
            FolderEnglish.Size = new Size(107, 26);
            FolderEnglish.TabIndex = 158;
            FolderEnglish.Text = "English";
            FolderEnglish.TextAlign = HorizontalAlignment.Center;
            // 
            // FolderLocalization
            // 
            FolderLocalization.Location = new Point(359, 90);
            FolderLocalization.Margin = new Padding(4, 5, 4, 5);
            FolderLocalization.Name = "FolderLocalization";
            FolderLocalization.Size = new Size(108, 26);
            FolderLocalization.TabIndex = 157;
            FolderLocalization.Text = "Localization";
            FolderLocalization.TextAlign = HorizontalAlignment.Center;
            // 
            // FolderModName
            // 
            FolderModName.Location = new Point(134, 90);
            FolderModName.Margin = new Padding(4, 5, 4, 5);
            FolderModName.Name = "FolderModName";
            FolderModName.Size = new Size(192, 26);
            FolderModName.TabIndex = 156;
            FolderModName.Text = "ModName";
            FolderModName.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(843, 85);
            button1.Name = "button1";
            button1.Size = new Size(44, 31);
            button1.TabIndex = 165;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(949, 149);
            button2.Name = "button2";
            button2.Size = new Size(44, 31);
            button2.TabIndex = 166;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(614, 186);
            button3.Name = "button3";
            button3.Size = new Size(44, 31);
            button3.TabIndex = 167;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(514, 259);
            button6.Name = "button6";
            button6.Size = new Size(44, 31);
            button6.TabIndex = 168;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(229, 297);
            button7.Name = "button7";
            button7.Size = new Size(44, 31);
            button7.TabIndex = 169;
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(229, 333);
            button8.Name = "button8";
            button8.Size = new Size(44, 31);
            button8.TabIndex = 170;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(698, 342);
            button9.Name = "button9";
            button9.Size = new Size(341, 31);
            button9.TabIndex = 171;
            button9.Text = "Finished setting it up now what do I do?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(789, 154);
            button12.Name = "button12";
            button12.Size = new Size(154, 27);
            button12.TabIndex = 172;
            button12.Text = "Copy to Clipboard";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1051, 385);
            Controls.Add(button12);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(ButtonCreateFolders);
            Controls.Add(ButtonSelectFolder);
            Controls.Add(label16);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(FolderEnglish);
            Controls.Add(FolderLocalization);
            Controls.Add(FolderModName);
            Controls.Add(Button_locatexml);
            Controls.Add(textBoxpath);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(label14);
            Controls.Add(button5);
            Controls.Add(label10);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(Update_name);
            Controls.Add(label1);
            Controls.Add(textBoxNameHandle);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form5";
            Text = "Localisation Editor";
            FormClosing += Form5_FormClosing;
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button10;
        private Button button11;
        private Label label14;
        private Button button5;
        private Label label10;
        private TextBox textBox1;
        private Button button4;
        private Button Update_name;
        private Label label1;
        private TextBox textBoxNameHandle;
        private Button Button_locatexml;
        private TextBox textBoxpath;
        private Label label8;
        private Button ButtonCreateFolders;
        private Button ButtonSelectFolder;
        private Label label16;
        private Label label18;
        private Label label19;
        private TextBox FolderEnglish;
        private TextBox FolderLocalization;
        private TextBox FolderModName;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button12;
    }
}