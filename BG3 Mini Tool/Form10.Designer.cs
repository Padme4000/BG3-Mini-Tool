namespace BG3_Mini_Tool
{
    partial class Form10
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
            label13 = new Label();
            button9 = new Button();
            button3 = new Button();
            label4 = new Label();
            textBoxVisualResource = new TextBox();
            button10 = new Button();
            label20 = new Label();
            FolderTimeline = new TextBox();
            ButtonCreateFolders = new Button();
            ButtonSelectFolder = new Button();
            label16 = new Label();
            label18 = new Label();
            label19 = new Label();
            FolderEngine = new TextBox();
            FolderPublic = new TextBox();
            FolderModName = new TextBox();
            label3 = new Label();
            FolderMaterialGroups = new TextBox();
            label5 = new Label();
            button4 = new Button();
            button18 = new Button();
            Button_saveas = new Button();
            button19 = new Button();
            Button_locateLSX = new Button();
            textBoxpath = new TextBox();
            Button_add = new Button();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            Button6 = new Button();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(366, 9);
            label13.Name = "label13";
            label13.Size = new Size(251, 25);
            label13.TabIndex = 189;
            label13.Text = "VFX for Custom Heads";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(488, 100);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(69, 34);
            button9.TabIndex = 201;
            button9.Text = "Update";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(563, 100);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(44, 34);
            button3.TabIndex = 200;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 109);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 199;
            label4.Text = "VisualResource";
            // 
            // textBoxVisualResource
            // 
            textBoxVisualResource.Location = new Point(133, 106);
            textBoxVisualResource.Margin = new Padding(4, 6, 4, 6);
            textBoxVisualResource.Name = "textBoxVisualResource";
            textBoxVisualResource.Size = new Size(348, 26);
            textBoxVisualResource.TabIndex = 198;
            textBoxVisualResource.Text = "Same UUID as the merged";
            // 
            // button10
            // 
            button10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(936, 57);
            button10.Margin = new Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Size = new Size(44, 39);
            button10.TabIndex = 217;
            button10.Text = "?";
            button10.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(450, 67);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(17, 20);
            label20.TabIndex = 216;
            label20.Text = "\\\\";
            // 
            // FolderTimeline
            // 
            FolderTimeline.Location = new Point(473, 63);
            FolderTimeline.Margin = new Padding(4, 6, 4, 6);
            FolderTimeline.Name = "FolderTimeline";
            FolderTimeline.Size = new Size(82, 26);
            FolderTimeline.TabIndex = 215;
            FolderTimeline.TabStop = false;
            FolderTimeline.Text = "Timeline";
            FolderTimeline.TextAlign = HorizontalAlignment.Center;
            // 
            // ButtonCreateFolders
            // 
            ButtonCreateFolders.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonCreateFolders.Location = new Point(825, 50);
            ButtonCreateFolders.Margin = new Padding(3, 4, 3, 4);
            ButtonCreateFolders.Name = "ButtonCreateFolders";
            ButtonCreateFolders.Size = new Size(105, 55);
            ButtonCreateFolders.TabIndex = 214;
            ButtonCreateFolders.Text = "Create Folders";
            ButtonCreateFolders.UseVisualStyleBackColor = true;
            ButtonCreateFolders.Click += ButtonCreateFolders_Click;
            // 
            // ButtonSelectFolder
            // 
            ButtonSelectFolder.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSelectFolder.Location = new Point(722, 50);
            ButtonSelectFolder.Margin = new Padding(3, 4, 3, 4);
            ButtonSelectFolder.Name = "ButtonSelectFolder";
            ButtonSelectFolder.Size = new Size(97, 55);
            ButtonSelectFolder.TabIndex = 213;
            ButtonSelectFolder.Text = "Check Mod Folder";
            ButtonSelectFolder.UseVisualStyleBackColor = true;
            ButtonSelectFolder.Click += ButtonSelectFolder_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(34, 67);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(91, 20);
            label16.TabIndex = 212;
            label16.Text = "Folder Path";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(340, 67);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(17, 20);
            label18.TabIndex = 211;
            label18.Text = "\\\\";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(253, 67);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(17, 20);
            label19.TabIndex = 210;
            label19.Text = "\\\\";
            // 
            // FolderEngine
            // 
            FolderEngine.Location = new Point(365, 63);
            FolderEngine.Margin = new Padding(4, 6, 4, 6);
            FolderEngine.Name = "FolderEngine";
            FolderEngine.Size = new Size(77, 26);
            FolderEngine.TabIndex = 209;
            FolderEngine.Text = "Engine";
            FolderEngine.TextAlign = HorizontalAlignment.Center;
            // 
            // FolderPublic
            // 
            FolderPublic.Location = new Point(278, 63);
            FolderPublic.Margin = new Padding(4, 6, 4, 6);
            FolderPublic.Name = "FolderPublic";
            FolderPublic.Size = new Size(54, 26);
            FolderPublic.TabIndex = 208;
            FolderPublic.Text = "Public";
            FolderPublic.TextAlign = HorizontalAlignment.Center;
            // 
            // FolderModName
            // 
            FolderModName.Location = new Point(133, 63);
            FolderModName.Margin = new Padding(4, 6, 4, 6);
            FolderModName.Name = "FolderModName";
            FolderModName.Size = new Size(112, 26);
            FolderModName.TabIndex = 207;
            FolderModName.Text = "ModName";
            FolderModName.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(563, 67);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 219;
            label3.Text = "\\\\";
            // 
            // FolderMaterialGroups
            // 
            FolderMaterialGroups.Location = new Point(588, 64);
            FolderMaterialGroups.Margin = new Padding(4, 6, 4, 6);
            FolderMaterialGroups.Name = "FolderMaterialGroups";
            FolderMaterialGroups.Size = new Size(127, 26);
            FolderMaterialGroups.TabIndex = 218;
            FolderMaterialGroups.TabStop = false;
            FolderMaterialGroups.Text = "MaterialGroups";
            FolderMaterialGroups.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 220);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 227;
            label5.Text = "File Path";
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(648, 215);
            button4.Name = "button4";
            button4.Size = new Size(44, 31);
            button4.TabIndex = 226;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button18.Location = new Point(381, 251);
            button18.Name = "button18";
            button18.Size = new Size(44, 31);
            button18.TabIndex = 225;
            button18.Text = "?";
            button18.UseVisualStyleBackColor = true;
            // 
            // Button_saveas
            // 
            Button_saveas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Button_saveas.Location = new Point(133, 251);
            Button_saveas.Name = "Button_saveas";
            Button_saveas.Size = new Size(140, 31);
            Button_saveas.TabIndex = 224;
            Button_saveas.Text = "Save as";
            Button_saveas.UseVisualStyleBackColor = true;
            Button_saveas.Click += Button_saveas_Click;
            // 
            // button19
            // 
            button19.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button19.Location = new Point(381, 287);
            button19.Name = "button19";
            button19.Size = new Size(44, 31);
            button19.TabIndex = 223;
            button19.Text = "?";
            button19.UseVisualStyleBackColor = true;
            // 
            // Button_locateLSX
            // 
            Button_locateLSX.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Button_locateLSX.Location = new Point(133, 178);
            Button_locateLSX.Name = "Button_locateLSX";
            Button_locateLSX.Size = new Size(264, 31);
            Button_locateLSX.TabIndex = 222;
            Button_locateLSX.Text = "Locate your MaterialGroups folder\r\n";
            Button_locateLSX.UseVisualStyleBackColor = true;
            Button_locateLSX.Click += Button_locateLSX_Click;
            // 
            // textBoxpath
            // 
            textBoxpath.Location = new Point(133, 217);
            textBoxpath.Margin = new Padding(4, 5, 4, 5);
            textBoxpath.Name = "textBoxpath";
            textBoxpath.Size = new Size(508, 26);
            textBoxpath.TabIndex = 221;
            // 
            // Button_add
            // 
            Button_add.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Button_add.Location = new Point(133, 288);
            Button_add.Name = "Button_add";
            Button_add.Size = new Size(173, 31);
            Button_add.TabIndex = 220;
            Button_add.Text = "Add to your mod file";
            Button_add.UseVisualStyleBackColor = true;
            Button_add.Click += Button_add_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(623, 4);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(44, 39);
            button1.TabIndex = 228;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(563, 140);
            button2.Name = "button2";
            button2.Size = new Size(44, 31);
            button2.TabIndex = 231;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 145);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 230;
            label1.Text = "Unique UUID";
            // 
            // Button6
            // 
            Button6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Button6.Location = new Point(133, 141);
            Button6.Name = "Button6";
            Button6.Size = new Size(219, 31);
            Button6.TabIndex = 229;
            Button6.Text = "Generate Unique UUIDs";
            Button6.UseVisualStyleBackColor = true;
            Button6.Click += Button6_Click;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(992, 336);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(Button6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button18);
            Controls.Add(Button_saveas);
            Controls.Add(button19);
            Controls.Add(Button_locateLSX);
            Controls.Add(textBoxpath);
            Controls.Add(Button_add);
            Controls.Add(label3);
            Controls.Add(FolderMaterialGroups);
            Controls.Add(button10);
            Controls.Add(label20);
            Controls.Add(FolderTimeline);
            Controls.Add(ButtonCreateFolders);
            Controls.Add(ButtonSelectFolder);
            Controls.Add(label16);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(FolderEngine);
            Controls.Add(FolderPublic);
            Controls.Add(FolderModName);
            Controls.Add(button9);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(textBoxVisualResource);
            Controls.Add(label13);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form10";
            Text = "Form10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label13;
        private Button button9;
        private Button button3;
        private Label label4;
        private TextBox textBoxVisualResource;
        private Button button10;
        private Label label20;
        private TextBox FolderTimeline;
        private Button ButtonCreateFolders;
        private Button ButtonSelectFolder;
        private Label label16;
        private Label label18;
        private Label label19;
        private TextBox FolderEngine;
        private TextBox FolderPublic;
        private TextBox FolderModName;
        private Label label3;
        private TextBox FolderMaterialGroups;
        private Label label5;
        private Button button4;
        private Button button18;
        private Button Button_saveas;
        private Button button19;
        private Button Button_locateLSX;
        private TextBox textBoxpath;
        private Button Button_add;
        private Button button1;
        private Button button2;
        private Label label1;
        private Button Button6;
    }
}