﻿
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxVisualResource = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Update_name = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Update_VisualResource = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Update_UniqueUUID = new System.Windows.Forms.Button();
            this.textBoxUniqueUUID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Button_add = new System.Windows.Forms.Button();
            this.textBoxpath = new System.Windows.Forms.TextBox();
            this.Button_locateLSX = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.Update_RaceUUID = new System.Windows.Forms.Button();
            this.comboBoxRaceUUID = new System.Windows.Forms.ComboBox();
            this.Button_saveas = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.UUIDGen_Unique = new System.Windows.Forms.Button();
            this.UUIDGen_VisualResource = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ButtonCreateFolders = new System.Windows.Forms.Button();
            this.ButtonSelectFolder = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textboxYourShared = new System.Windows.Forms.TextBox();
            this.FolderPublic = new System.Windows.Forms.TextBox();
            this.FolderModName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.FolderCharacterCreation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(161, 115);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(348, 26);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Text = "Name shown in character creation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Display Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bodytype";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "RaceUUID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "VisualResource";
            // 
            // textBoxVisualResource
            // 
            this.textBoxVisualResource.Location = new System.Drawing.Point(161, 295);
            this.textBoxVisualResource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxVisualResource.Name = "textBoxVisualResource";
            this.textBoxVisualResource.Size = new System.Drawing.Size(348, 26);
            this.textBoxVisualResource.TabIndex = 10;
            this.textBoxVisualResource.Text = "Same UUID as the merged";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Unique UUID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "SlotName";
            // 
            // Update_name
            // 
            this.Update_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Update_name.Location = new System.Drawing.Point(516, 114);
            this.Update_name.Name = "Update_name";
            this.Update_name.Size = new System.Drawing.Size(69, 31);
            this.Update_name.TabIndex = 12;
            this.Update_name.Text = "Update";
            this.Update_name.UseVisualStyleBackColor = true;
            this.Update_name.Click += new System.EventHandler(this.Update_name_Click);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button2.Location = new System.Drawing.Point(161, 149);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(69, 31);
            this.Button2.TabIndex = 13;
            this.Button2.Text = "Masc";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button3.Location = new System.Drawing.Point(161, 220);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(69, 31);
            this.Button3.TabIndex = 15;
            this.Button3.Text = "Head";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Update_VisualResource
            // 
            this.Update_VisualResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Update_VisualResource.Location = new System.Drawing.Point(516, 295);
            this.Update_VisualResource.Name = "Update_VisualResource";
            this.Update_VisualResource.Size = new System.Drawing.Size(69, 31);
            this.Update_VisualResource.TabIndex = 17;
            this.Update_VisualResource.Text = "Update";
            this.Update_VisualResource.UseVisualStyleBackColor = true;
            this.Update_VisualResource.Click += new System.EventHandler(this.Update_VisualResource_Click);
            // 
            // Button8
            // 
            this.Button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button8.Location = new System.Drawing.Point(236, 149);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(92, 31);
            this.Button8.TabIndex = 19;
            this.Button8.Text = "Feminine";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button9
            // 
            this.Button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button9.Location = new System.Drawing.Point(236, 220);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(69, 31);
            this.Button9.TabIndex = 20;
            this.Button9.Text = "Horns";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Update_UniqueUUID
            // 
            this.Update_UniqueUUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Update_UniqueUUID.Location = new System.Drawing.Point(516, 258);
            this.Update_UniqueUUID.Name = "Update_UniqueUUID";
            this.Update_UniqueUUID.Size = new System.Drawing.Size(69, 31);
            this.Update_UniqueUUID.TabIndex = 23;
            this.Update_UniqueUUID.Text = "Update";
            this.Update_UniqueUUID.UseVisualStyleBackColor = true;
            this.Update_UniqueUUID.Click += new System.EventHandler(this.Update_UniqueUUID_Click);
            // 
            // textBoxUniqueUUID
            // 
            this.textBoxUniqueUUID.Location = new System.Drawing.Point(161, 259);
            this.textBoxUniqueUUID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUniqueUUID.Name = "textBoxUniqueUUID";
            this.textBoxUniqueUUID.Size = new System.Drawing.Size(348, 26);
            this.textBoxUniqueUUID.TabIndex = 22;
            this.textBoxUniqueUUID.Text = "Unique UUID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(311, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Choose what you are making";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(336, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(322, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "Choose the bodytype you are making this for";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(263, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(407, 25);
            this.label13.TabIndex = 49;
            this.label13.Text = "CharacterCreationAppearanceVisuals";
            // 
            // Button_add
            // 
            this.Button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button_add.Location = new System.Drawing.Point(36, 366);
            this.Button_add.Name = "Button_add";
            this.Button_add.Size = new System.Drawing.Size(173, 31);
            this.Button_add.TabIndex = 51;
            this.Button_add.Text = "Add to your mod file";
            this.Button_add.UseVisualStyleBackColor = true;
            this.Button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // textBoxpath
            // 
            this.textBoxpath.Location = new System.Drawing.Point(36, 442);
            this.textBoxpath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxpath.Name = "textBoxpath";
            this.textBoxpath.Size = new System.Drawing.Size(1011, 26);
            this.textBoxpath.TabIndex = 52;
            this.textBoxpath.Text = "Path to your mod file including the name of the lsx. This is so when you click \"A" +
    "dd to your mod file\" your new entry is added to your file";
            this.textBoxpath.TextChanged += new System.EventHandler(this.textBoxpath_TextChanged);
            // 
            // Button_locateLSX
            // 
            this.Button_locateLSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button_locateLSX.Location = new System.Drawing.Point(36, 403);
            this.Button_locateLSX.Name = "Button_locateLSX";
            this.Button_locateLSX.Size = new System.Drawing.Size(458, 31);
            this.Button_locateLSX.TabIndex = 54;
            this.Button_locateLSX.Text = "Locate your CharacterCreationAppearanceVisuals.lsx";
            this.Button_locateLSX.UseVisualStyleBackColor = true;
            this.Button_locateLSX.Click += new System.EventHandler(this.Button_locateLSX_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(215, 370);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(215, 20);
            this.label15.TabIndex = 55;
            this.label15.Text = "Add the slot to an existing file";
            // 
            // Update_RaceUUID
            // 
            this.Update_RaceUUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Update_RaceUUID.Location = new System.Drawing.Point(516, 185);
            this.Update_RaceUUID.Name = "Update_RaceUUID";
            this.Update_RaceUUID.Size = new System.Drawing.Size(69, 31);
            this.Update_RaceUUID.TabIndex = 59;
            this.Update_RaceUUID.Text = "Update";
            this.Update_RaceUUID.UseVisualStyleBackColor = true;
            this.Update_RaceUUID.Click += new System.EventHandler(this.Update_RaceUUID_Click);
            // 
            // comboBoxRaceUUID
            // 
            this.comboBoxRaceUUID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRaceUUID.FormattingEnabled = true;
            this.comboBoxRaceUUID.Location = new System.Drawing.Point(161, 186);
            this.comboBoxRaceUUID.Name = "comboBoxRaceUUID";
            this.comboBoxRaceUUID.Size = new System.Drawing.Size(348, 28);
            this.comboBoxRaceUUID.TabIndex = 61;
            this.comboBoxRaceUUID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBoxRaceUUID.Click += new System.EventHandler(this.comboBoxRaceUUID_Click);
            // 
            // Button_saveas
            // 
            this.Button_saveas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button_saveas.Location = new System.Drawing.Point(36, 329);
            this.Button_saveas.Name = "Button_saveas";
            this.Button_saveas.Size = new System.Drawing.Size(140, 31);
            this.Button_saveas.TabIndex = 64;
            this.Button_saveas.Text = "Save as";
            this.Button_saveas.UseVisualStyleBackColor = true;
            this.Button_saveas.Click += new System.EventHandler(this.Button_saveas_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(182, 333);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(393, 20);
            this.label17.TabIndex = 65;
            this.label17.Text = "If you do not already have one generated save your file";
            // 
            // UUIDGen_Unique
            // 
            this.UUIDGen_Unique.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UUIDGen_Unique.Location = new System.Drawing.Point(591, 259);
            this.UUIDGen_Unique.Name = "UUIDGen_Unique";
            this.UUIDGen_Unique.Size = new System.Drawing.Size(219, 31);
            this.UUIDGen_Unique.TabIndex = 66;
            this.UUIDGen_Unique.Text = "Generate Unique UUID";
            this.UUIDGen_Unique.UseVisualStyleBackColor = true;
            this.UUIDGen_Unique.Click += new System.EventHandler(this.UUIDGen_Unique_Click);
            // 
            // UUIDGen_VisualResource
            // 
            this.UUIDGen_VisualResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UUIDGen_VisualResource.Location = new System.Drawing.Point(591, 296);
            this.UUIDGen_VisualResource.Name = "UUIDGen_VisualResource";
            this.UUIDGen_VisualResource.Size = new System.Drawing.Size(219, 31);
            this.UUIDGen_VisualResource.TabIndex = 69;
            this.UUIDGen_VisualResource.Text = "Generate Unique UUID";
            this.UUIDGen_VisualResource.UseVisualStyleBackColor = true;
            this.UUIDGen_VisualResource.Click += new System.EventHandler(this.UUIDGen_VisualResource_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(157, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(738, 20);
            this.label8.TabIndex = 122;
            this.label8.Text = "Fill in or use the Check Mod Folder Button to check if your mod folder includes t" +
    "he folder for the meta.lsx";
            // 
            // ButtonCreateFolders
            // 
            this.ButtonCreateFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonCreateFolders.Location = new System.Drawing.Point(947, 43);
            this.ButtonCreateFolders.Name = "ButtonCreateFolders";
            this.ButtonCreateFolders.Size = new System.Drawing.Size(105, 44);
            this.ButtonCreateFolders.TabIndex = 121;
            this.ButtonCreateFolders.Text = "Create Folders";
            this.ButtonCreateFolders.UseVisualStyleBackColor = true;
            this.ButtonCreateFolders.Click += new System.EventHandler(this.ButtonCreateFolders_Click);
            // 
            // ButtonSelectFolder
            // 
            this.ButtonSelectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonSelectFolder.Location = new System.Drawing.Point(844, 43);
            this.ButtonSelectFolder.Name = "ButtonSelectFolder";
            this.ButtonSelectFolder.Size = new System.Drawing.Size(97, 44);
            this.ButtonSelectFolder.TabIndex = 120;
            this.ButtonSelectFolder.Text = "Check Mod Folder";
            this.ButtonSelectFolder.UseVisualStyleBackColor = true;
            this.ButtonSelectFolder.Click += new System.EventHandler(this.ButtonSelectFolder_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(62, 57);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 20);
            this.label16.TabIndex = 119;
            this.label16.Text = "Folder Path";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(448, 57);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 20);
            this.label18.TabIndex = 118;
            this.label18.Text = "\\\\";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(361, 57);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 20);
            this.label19.TabIndex = 117;
            this.label19.Text = "\\\\";
            // 
            // textboxYourShared
            // 
            this.textboxYourShared.Location = new System.Drawing.Point(473, 51);
            this.textboxYourShared.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textboxYourShared.Name = "textboxYourShared";
            this.textboxYourShared.Size = new System.Drawing.Size(186, 26);
            this.textboxYourShared.TabIndex = 116;
            this.textboxYourShared.Text = "YourShared";
            this.textboxYourShared.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxYourShared.TextChanged += new System.EventHandler(this.textboxYourShared_TextChanged);
            // 
            // FolderPublic
            // 
            this.FolderPublic.Location = new System.Drawing.Point(386, 54);
            this.FolderPublic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FolderPublic.Name = "FolderPublic";
            this.FolderPublic.Size = new System.Drawing.Size(54, 26);
            this.FolderPublic.TabIndex = 115;
            this.FolderPublic.Text = "Public";
            this.FolderPublic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FolderModName
            // 
            this.FolderModName.Location = new System.Drawing.Point(161, 54);
            this.FolderModName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FolderModName.Name = "FolderModName";
            this.FolderModName.Size = new System.Drawing.Size(192, 26);
            this.FolderModName.TabIndex = 114;
            this.FolderModName.Text = "ModName";
            this.FolderModName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FolderModName.TextChanged += new System.EventHandler(this.FolderModName_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(667, 54);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 20);
            this.label20.TabIndex = 124;
            this.label20.Text = "\\\\";
            // 
            // FolderCharacterCreation
            // 
            this.FolderCharacterCreation.Location = new System.Drawing.Point(692, 51);
            this.FolderCharacterCreation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FolderCharacterCreation.Name = "FolderCharacterCreation";
            this.FolderCharacterCreation.Size = new System.Drawing.Size(145, 26);
            this.FolderCharacterCreation.TabIndex = 123;
            this.FolderCharacterCreation.TabStop = false;
            this.FolderCharacterCreation.Text = "CharacterCreation";
            this.FolderCharacterCreation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1075, 486);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.FolderCharacterCreation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ButtonCreateFolders);
            this.Controls.Add(this.ButtonSelectFolder);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textboxYourShared);
            this.Controls.Add(this.FolderPublic);
            this.Controls.Add(this.FolderModName);
            this.Controls.Add(this.UUIDGen_VisualResource);
            this.Controls.Add(this.UUIDGen_Unique);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Button_saveas);
            this.Controls.Add(this.comboBoxRaceUUID);
            this.Controls.Add(this.Update_RaceUUID);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Button_locateLSX);
            this.Controls.Add(this.textBoxpath);
            this.Controls.Add(this.Button_add);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Update_UniqueUUID);
            this.Controls.Add(this.textBoxUniqueUUID);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Update_VisualResource);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Update_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxVisualResource);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "CharacterCreationAppearanceValues";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxVisualResource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Update_name;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Update_VisualResource;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Update_UniqueUUID;
        private System.Windows.Forms.TextBox textBoxUniqueUUID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Button_add;
        private System.Windows.Forms.TextBox textBoxpath;
        private System.Windows.Forms.Button Button_locateLSX;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Update_RaceUUID;
        private System.Windows.Forms.ComboBox comboBoxRaceUUID;
        private System.Windows.Forms.Button Button_saveas;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button UUIDGen_Unique;
        private System.Windows.Forms.Button UUIDGen_VisualResource;
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
    }
}

