
using System.Windows.Forms;

namespace BG3_Mini_Tool
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxVisualResource = new TextBox();
            label5 = new Label();
            label6 = new Label();
            Button2 = new Button();
            Update_VisualResource = new Button();
            Button8 = new Button();
            Update_UniqueUUID = new Button();
            textBoxUniqueUUID = new TextBox();
            label9 = new Label();
            label11 = new Label();
            label13 = new Label();
            Button_add = new Button();
            textBoxpath = new TextBox();
            Button_locateLSX = new Button();
            label15 = new Label();
            Update_RaceUUID = new Button();
            comboBoxRaceUUID = new ComboBox();
            Button_saveas = new Button();
            label17 = new Label();
            UUIDGen_Unique = new Button();
            UUIDGen_VisualResource = new Button();
            label8 = new Label();
            ButtonCreateFolders = new Button();
            ButtonSelectFolder = new Button();
            label16 = new Label();
            label18 = new Label();
            label19 = new Label();
            textboxYourShared = new TextBox();
            FolderPublic = new TextBox();
            FolderModName = new TextBox();
            label20 = new Label();
            FolderCharacterCreation = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label7 = new Label();
            button3 = new Button();
            button6 = new Button();
            label12 = new Label();
            button7 = new Button();
            button9 = new Button();
            label21 = new Label();
            textBoxNameHandle = new TextBox();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 221);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Bodytype";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 303);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 5;
            label3.Text = "RaceUUID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 410);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 11;
            label4.Text = "VisualResource";
            // 
            // textBoxVisualResource
            // 
            textBoxVisualResource.Location = new Point(161, 410);
            textBoxVisualResource.Margin = new Padding(4, 5, 4, 5);
            textBoxVisualResource.Name = "textBoxVisualResource";
            textBoxVisualResource.Size = new Size(348, 26);
            textBoxVisualResource.TabIndex = 10;
            textBoxVisualResource.Text = "Same UUID as the merged";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 374);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 9;
            label5.Text = "Unique UUID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 340);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 7;
            label6.Text = "SlotName";
            // 
            // Button2
            // 
            Button2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Button2.Location = new Point(161, 217);
            Button2.Name = "Button2";
            Button2.Size = new Size(69, 31);
            Button2.TabIndex = 13;
            Button2.Text = "Masc";
            Button2.UseVisualStyleBackColor = true;
            Button2.Click += Button2_Click;
            // 
            // Update_VisualResource
            // 
            Update_VisualResource.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Update_VisualResource.Location = new Point(516, 410);
            Update_VisualResource.Name = "Update_VisualResource";
            Update_VisualResource.Size = new Size(69, 31);
            Update_VisualResource.TabIndex = 17;
            Update_VisualResource.Text = "Update";
            Update_VisualResource.UseVisualStyleBackColor = true;
            Update_VisualResource.Click += Update_VisualResource_Click;
            // 
            // Button8
            // 
            Button8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Button8.Location = new Point(236, 217);
            Button8.Name = "Button8";
            Button8.Size = new Size(92, 31);
            Button8.TabIndex = 19;
            Button8.Text = "Feminine";
            Button8.UseVisualStyleBackColor = true;
            Button8.Click += Button8_Click;
            // 
            // Update_UniqueUUID
            // 
            Update_UniqueUUID.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Update_UniqueUUID.Location = new Point(516, 373);
            Update_UniqueUUID.Name = "Update_UniqueUUID";
            Update_UniqueUUID.Size = new Size(69, 31);
            Update_UniqueUUID.TabIndex = 23;
            Update_UniqueUUID.Text = "Update";
            Update_UniqueUUID.UseVisualStyleBackColor = true;
            Update_UniqueUUID.Click += Update_UniqueUUID_Click;
            // 
            // textBoxUniqueUUID
            // 
            textBoxUniqueUUID.Location = new Point(161, 374);
            textBoxUniqueUUID.Margin = new Padding(4, 5, 4, 5);
            textBoxUniqueUUID.Name = "textBoxUniqueUUID";
            textBoxUniqueUUID.Size = new Size(348, 26);
            textBoxUniqueUUID.TabIndex = 22;
            textBoxUniqueUUID.Text = "Unique UUID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(591, 340);
            label9.Name = "label9";
            label9.Size = new Size(213, 20);
            label9.TabIndex = 35;
            label9.Text = "Choose what you are making";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(334, 221);
            label11.Name = "label11";
            label11.Size = new Size(322, 20);
            label11.TabIndex = 37;
            label11.Text = "Choose the bodytype you are making this for";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(334, 9);
            label13.Name = "label13";
            label13.Size = new Size(407, 25);
            label13.TabIndex = 49;
            label13.Text = "CharacterCreationAppearanceVisuals";
            // 
            // Button_add
            // 
            Button_add.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Button_add.Location = new Point(36, 481);
            Button_add.Name = "Button_add";
            Button_add.Size = new Size(173, 31);
            Button_add.TabIndex = 51;
            Button_add.Text = "Add to your mod file";
            Button_add.UseVisualStyleBackColor = true;
            Button_add.Click += Button_add_Click;
            // 
            // textBoxpath
            // 
            textBoxpath.Location = new Point(36, 557);
            textBoxpath.Margin = new Padding(4, 5, 4, 5);
            textBoxpath.Name = "textBoxpath";
            textBoxpath.Size = new Size(1011, 26);
            textBoxpath.TabIndex = 52;
            textBoxpath.Text = "Path to your mod file including the name of the lsx. This is so when you click \"Add to your mod file\" your new entry is added to your file";
            textBoxpath.TextChanged += textBoxpath_TextChanged;
            // 
            // Button_locateLSX
            // 
            Button_locateLSX.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Button_locateLSX.Location = new Point(36, 518);
            Button_locateLSX.Name = "Button_locateLSX";
            Button_locateLSX.Size = new Size(458, 31);
            Button_locateLSX.TabIndex = 54;
            Button_locateLSX.Text = "Locate your CharacterCreationAppearanceVisuals.lsx";
            Button_locateLSX.UseVisualStyleBackColor = true;
            Button_locateLSX.Click += Button_locateLSX_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(215, 485);
            label15.Name = "label15";
            label15.Size = new Size(215, 20);
            label15.TabIndex = 55;
            label15.Text = "Add the slot to an existing file";
            // 
            // Update_RaceUUID
            // 
            Update_RaceUUID.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Update_RaceUUID.Location = new Point(516, 299);
            Update_RaceUUID.Name = "Update_RaceUUID";
            Update_RaceUUID.Size = new Size(69, 31);
            Update_RaceUUID.TabIndex = 59;
            Update_RaceUUID.Text = "Update";
            Update_RaceUUID.UseVisualStyleBackColor = true;
            Update_RaceUUID.Click += Update_RaceUUID_Click;
            // 
            // comboBoxRaceUUID
            // 
            comboBoxRaceUUID.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRaceUUID.FormattingEnabled = true;
            comboBoxRaceUUID.Location = new Point(161, 300);
            comboBoxRaceUUID.Name = "comboBoxRaceUUID";
            comboBoxRaceUUID.Size = new Size(348, 28);
            comboBoxRaceUUID.TabIndex = 61;
            comboBoxRaceUUID.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBoxRaceUUID.Click += comboBoxRaceUUID_Click;
            // 
            // Button_saveas
            // 
            Button_saveas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Button_saveas.Location = new Point(36, 444);
            Button_saveas.Name = "Button_saveas";
            Button_saveas.Size = new Size(140, 31);
            Button_saveas.TabIndex = 64;
            Button_saveas.Text = "Save as";
            Button_saveas.UseVisualStyleBackColor = true;
            Button_saveas.Click += Button_saveas_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(182, 448);
            label17.Name = "label17";
            label17.Size = new Size(393, 20);
            label17.TabIndex = 65;
            label17.Text = "If you do not already have one generated save your file";
            // 
            // UUIDGen_Unique
            // 
            UUIDGen_Unique.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            UUIDGen_Unique.Location = new Point(591, 374);
            UUIDGen_Unique.Name = "UUIDGen_Unique";
            UUIDGen_Unique.Size = new Size(219, 31);
            UUIDGen_Unique.TabIndex = 66;
            UUIDGen_Unique.Text = "Generate Unique UUID";
            UUIDGen_Unique.UseVisualStyleBackColor = true;
            UUIDGen_Unique.Click += UUIDGen_Unique_Click;
            // 
            // UUIDGen_VisualResource
            // 
            UUIDGen_VisualResource.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            UUIDGen_VisualResource.Location = new Point(591, 411);
            UUIDGen_VisualResource.Name = "UUIDGen_VisualResource";
            UUIDGen_VisualResource.Size = new Size(219, 31);
            UUIDGen_VisualResource.TabIndex = 69;
            UUIDGen_VisualResource.Text = "Generate Unique UUID";
            UUIDGen_VisualResource.UseVisualStyleBackColor = true;
            UUIDGen_VisualResource.Click += UUIDGen_VisualResource_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(157, 90);
            label8.Name = "label8";
            label8.Size = new Size(738, 20);
            label8.TabIndex = 122;
            label8.Text = "Fill in or use the Check Mod Folder Button to check if your mod folder includes the folder for the meta.lsx";
            // 
            // ButtonCreateFolders
            // 
            ButtonCreateFolders.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonCreateFolders.Location = new Point(947, 43);
            ButtonCreateFolders.Name = "ButtonCreateFolders";
            ButtonCreateFolders.Size = new Size(105, 44);
            ButtonCreateFolders.TabIndex = 121;
            ButtonCreateFolders.Text = "Create Folders";
            ButtonCreateFolders.UseVisualStyleBackColor = true;
            ButtonCreateFolders.Click += ButtonCreateFolders_Click;
            // 
            // ButtonSelectFolder
            // 
            ButtonSelectFolder.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSelectFolder.Location = new Point(844, 43);
            ButtonSelectFolder.Name = "ButtonSelectFolder";
            ButtonSelectFolder.Size = new Size(97, 44);
            ButtonSelectFolder.TabIndex = 120;
            ButtonSelectFolder.Text = "Check Mod Folder";
            ButtonSelectFolder.UseVisualStyleBackColor = true;
            ButtonSelectFolder.Click += ButtonSelectFolder_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(62, 57);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(91, 20);
            label16.TabIndex = 119;
            label16.Text = "Folder Path";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(448, 57);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(17, 20);
            label18.TabIndex = 118;
            label18.Text = "\\\\";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(361, 57);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(17, 20);
            label19.TabIndex = 117;
            label19.Text = "\\\\";
            // 
            // textboxYourShared
            // 
            textboxYourShared.Location = new Point(473, 51);
            textboxYourShared.Margin = new Padding(4, 5, 4, 5);
            textboxYourShared.Name = "textboxYourShared";
            textboxYourShared.Size = new Size(186, 26);
            textboxYourShared.TabIndex = 116;
            textboxYourShared.Text = "YourShared";
            textboxYourShared.TextAlign = HorizontalAlignment.Center;
            textboxYourShared.TextChanged += textboxYourShared_TextChanged;
            // 
            // FolderPublic
            // 
            FolderPublic.Location = new Point(386, 54);
            FolderPublic.Margin = new Padding(4, 5, 4, 5);
            FolderPublic.Name = "FolderPublic";
            FolderPublic.Size = new Size(54, 26);
            FolderPublic.TabIndex = 115;
            FolderPublic.Text = "Public";
            FolderPublic.TextAlign = HorizontalAlignment.Center;
            // 
            // FolderModName
            // 
            FolderModName.Location = new Point(161, 54);
            FolderModName.Margin = new Padding(4, 5, 4, 5);
            FolderModName.Name = "FolderModName";
            FolderModName.Size = new Size(192, 26);
            FolderModName.TabIndex = 114;
            FolderModName.Text = "ModName";
            FolderModName.TextAlign = HorizontalAlignment.Center;
            FolderModName.TextChanged += FolderModName_TextChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(667, 54);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(17, 20);
            label20.TabIndex = 124;
            label20.Text = "\\\\";
            // 
            // FolderCharacterCreation
            // 
            FolderCharacterCreation.Location = new Point(692, 51);
            FolderCharacterCreation.Margin = new Padding(4, 5, 4, 5);
            FolderCharacterCreation.Name = "FolderCharacterCreation";
            FolderCharacterCreation.Size = new Size(145, 26);
            FolderCharacterCreation.TabIndex = 123;
            FolderCharacterCreation.TabStop = false;
            FolderCharacterCreation.Text = "CharacterCreation";
            FolderCharacterCreation.TextAlign = HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(161, 337);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(348, 28);
            comboBox1.TabIndex = 125;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            comboBox1.Click += comboBox1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(516, 336);
            button1.Name = "button1";
            button1.Size = new Size(69, 31);
            button1.TabIndex = 126;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 117);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 127;
            label7.Text = "Bodyshape";
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(236, 113);
            button3.Name = "button3";
            button3.Size = new Size(92, 31);
            button3.TabIndex = 135;
            button3.Text = "Other";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(161, 113);
            button6.Name = "button6";
            button6.Size = new Size(69, 31);
            button6.TabIndex = 134;
            button6.Text = "Default";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(79, 147);
            label12.Name = "label12";
            label12.Size = new Size(774, 60);
            label12.TabIndex = 136;
            label12.Text = resources.GetString("label12.Text");
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(591, 265);
            button7.Name = "button7";
            button7.Size = new Size(219, 31);
            button7.TabIndex = 141;
            button7.Text = "Generate Unique Handle";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(516, 265);
            button9.Name = "button9";
            button9.Size = new Size(69, 31);
            button9.TabIndex = 140;
            button9.Text = "Update";
            button9.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(49, 269);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(106, 20);
            label21.TabIndex = 139;
            label21.Text = "Name Handle";
            // 
            // textBoxNameHandle
            // 
            textBoxNameHandle.Location = new Point(161, 266);
            textBoxNameHandle.Margin = new Padding(4, 5, 4, 5);
            textBoxNameHandle.Multiline = true;
            textBoxNameHandle.Name = "textBoxNameHandle";
            textBoxNameHandle.Size = new Size(348, 26);
            textBoxNameHandle.TabIndex = 138;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(816, 265);
            button4.Name = "button4";
            button4.Size = new Size(219, 31);
            button4.TabIndex = 142;
            button4.Text = "Open Localization Editor\r\n";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(386, 113);
            button5.Name = "button5";
            button5.Size = new Size(54, 31);
            button5.TabIndex = 143;
            button5.Text = "Info";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1075, 621);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button7);
            Controls.Add(button9);
            Controls.Add(label21);
            Controls.Add(textBoxNameHandle);
            Controls.Add(label12);
            Controls.Add(button3);
            Controls.Add(button6);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label20);
            Controls.Add(FolderCharacterCreation);
            Controls.Add(label8);
            Controls.Add(ButtonCreateFolders);
            Controls.Add(ButtonSelectFolder);
            Controls.Add(label16);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(textboxYourShared);
            Controls.Add(FolderPublic);
            Controls.Add(FolderModName);
            Controls.Add(UUIDGen_VisualResource);
            Controls.Add(UUIDGen_Unique);
            Controls.Add(label17);
            Controls.Add(Button_saveas);
            Controls.Add(comboBoxRaceUUID);
            Controls.Add(Update_RaceUUID);
            Controls.Add(label15);
            Controls.Add(Button_locateLSX);
            Controls.Add(textBoxpath);
            Controls.Add(Button_add);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(Update_UniqueUUID);
            Controls.Add(textBoxUniqueUUID);
            Controls.Add(Button8);
            Controls.Add(Update_VisualResource);
            Controls.Add(Button2);
            Controls.Add(label4);
            Controls.Add(textBoxVisualResource);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            Text = "CharacterCreationAppearanceValues";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load_1;
            Resize += Form2_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxVisualResource;
        private Label label5;
        private Label label6;
        private Button Button2;
        private Button Update_VisualResource;
        private Button Button8;
        private Button Update_UniqueUUID;
        private TextBox textBoxUniqueUUID;
        private Label label9;
        private Label label11;
        private Label label13;
        private Button Button_add;
        private TextBox textBoxpath;
        private Button Button_locateLSX;
        private Label label15;
        private Button Update_RaceUUID;
        private ComboBox comboBoxRaceUUID;
        private Button Button_saveas;
        private Label label17;
        private Button UUIDGen_Unique;
        private Button UUIDGen_VisualResource;
        private Label label8;
        private Button ButtonCreateFolders;
        private Button ButtonSelectFolder;
        private Label label16;
        private Label label18;
        private Label label19;
        private TextBox textboxYourShared;
        private TextBox FolderPublic;
        private TextBox FolderModName;
        private Label label20;
        private TextBox FolderCharacterCreation;
        private ComboBox comboBox1;
        private Button button1;
        private Label label7;
        private Button button3;
        private Button button6;
        private Label label12;
        private Button button7;
        private Button button9;
        private Label label21;
        private TextBox textBoxNameHandle;
        private Button button4;
        private Button button5;
    }
}

