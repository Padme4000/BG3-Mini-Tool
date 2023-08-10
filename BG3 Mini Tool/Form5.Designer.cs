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
            textBoxName = new TextBox();
            Button_locateLSX = new Button();
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
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(217, 24);
            label14.Name = "label14";
            label14.Size = new Size(602, 25);
            label14.TabIndex = 151;
            label14.Text = "CharacterCreationAppearanceVisuals - Localization File";
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
            // textBoxName
            // 
            textBoxName.Location = new Point(134, 151);
            textBoxName.Margin = new Padding(4, 5, 4, 5);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(348, 26);
            textBoxName.TabIndex = 144;
            // 
            // Button_locateLSX
            // 
            Button_locateLSX.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Button_locateLSX.Location = new Point(22, 260);
            Button_locateLSX.Name = "Button_locateLSX";
            Button_locateLSX.Size = new Size(458, 31);
            Button_locateLSX.TabIndex = 155;
            Button_locateLSX.Text = "Locate your Localization xml\r\n";
            Button_locateLSX.UseVisualStyleBackColor = true;
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
            // Form5
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1051, 385);
            Controls.Add(label8);
            Controls.Add(ButtonCreateFolders);
            Controls.Add(ButtonSelectFolder);
            Controls.Add(label16);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(FolderEnglish);
            Controls.Add(FolderLocalization);
            Controls.Add(FolderModName);
            Controls.Add(Button_locateLSX);
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
            Controls.Add(textBoxName);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form5";
            Text = "Form5";
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
        private TextBox textBoxName;
        private Button Button_locateLSX;
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
    }
}