using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlTypes;
using System.ComponentModel;
using System.Xml.Linq;
using System.Reflection;

namespace BG3_Mod_Templates
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
                       
            numericUpDown1.Value = 1;
            numericUpDown3.Value = 0;
            numericUpDown3.Enabled = false;

            numericUpDown2.Value = 0;
            numericUpDown2.Enabled = false;
            FolderMods.ReadOnly = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                Guid guid = Guid.NewGuid();
                textBoxUniqueUUID.Text = "" + guid.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e) //Mod Creator
        {
            string filePath = "LSX Files\\meta.lsx";
            string newValue = textBox_creator.Text;

            string[] lines = File.ReadAllLines(filePath);
            string pattern = "\"Author\" type=\"LSWString\" value=\"";

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(pattern))
                {
                    int startIndex = lines[i].IndexOf(pattern) + pattern.Length;
                    int endIndex = lines[i].IndexOf("\"", startIndex);
                    string linePrefix = lines[i].Substring(0, startIndex);
                    string lineSuffix = lines[i].Substring(endIndex);
                    string replacedLine = linePrefix + newValue + lineSuffix;
                    lines[i] = replacedLine;
                    break; // 
                }
            }

            File.WriteAllLines(filePath, lines);
        }

        private void button1_Click(object sender, EventArgs e) //Mod Name
        {
            string filePath = "LSX Files\\meta.lsx";
            string newValue = textBoxName.Text;

            string[] lines = File.ReadAllLines(filePath);
            string pattern = "\"Name\" type=\"FixedString\" value=\"";

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(pattern))
                {
                    int startIndex = lines[i].IndexOf(pattern) + pattern.Length;
                    int endIndex = lines[i].IndexOf("\"", startIndex);
                    string linePrefix = lines[i].Substring(0, startIndex);
                    string lineSuffix = lines[i].Substring(endIndex);
                    string replacedLine = linePrefix + newValue + lineSuffix;
                    lines[i] = replacedLine;
                    break; // 
                }
            }

            File.WriteAllLines(filePath, lines);
        }

        private void button2_Click(object sender, EventArgs e) //Mod Description
        {
            string filePath = "LSX Files\\meta.lsx";
            string newValue = textBoxDesc.Text;

            string[] lines = File.ReadAllLines(filePath);
            string pattern = "\"Description\" type=\"LSWString\" value=\"";

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(pattern))
                {
                    int startIndex = lines[i].IndexOf(pattern) + pattern.Length;
                    int endIndex = lines[i].IndexOf("\"", startIndex);
                    string linePrefix = lines[i].Substring(0, startIndex);
                    string lineSuffix = lines[i].Substring(endIndex);
                    string replacedLine = linePrefix + newValue + lineSuffix;
                    lines[i] = replacedLine;
                    break; // 
                }
            }

            File.WriteAllLines(filePath, lines);
        }

        private void button3_Click(object sender, EventArgs e) //Shared Folder
        {
            string filePath = "LSX Files\\meta.lsx";
            string newValue = textBoxShared2.Text;

            string[] lines = File.ReadAllLines(filePath);
            string pattern = "\"Folder\" type=\"LSWString\" value=\"";

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(pattern))
                {
                    int startIndex = lines[i].IndexOf(pattern) + pattern.Length;
                    int endIndex = lines[i].IndexOf("\"", startIndex);
                    string linePrefix = lines[i].Substring(0, startIndex);
                    string lineSuffix = lines[i].Substring(endIndex);
                    string replacedLine = linePrefix + newValue + lineSuffix;
                    lines[i] = replacedLine;
                    break; // 
                }
            }

            File.WriteAllLines(filePath, lines);
        }

        private void button4_Click(object sender, EventArgs e) //Unique UUID
        {
            string filePath = "LSX Files\\meta.lsx";
            string newValue = textBoxUniqueUUID.Text;

            string[] lines = File.ReadAllLines(filePath);
            string pattern = "\"UUID\" type=\"guid\" value=\"";

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(pattern))
                {
                    int startIndex = lines[i].IndexOf(pattern) + pattern.Length;
                    int endIndex = lines[i].IndexOf("\"", startIndex);
                    string linePrefix = lines[i].Substring(0, startIndex);
                    string lineSuffix = lines[i].Substring(endIndex);
                    string replacedLine = linePrefix + newValue + lineSuffix;
                    lines[i] = replacedLine;
                    break; // 
                }
            }

            File.WriteAllLines(filePath, lines);
        }
        private void button7_Click(object sender, EventArgs e) //Version Number
        {
            string filePath = "LSX Files\\meta.lsx";
            string newValue = textBoxVersion.Text;

            string[] lines = File.ReadAllLines(filePath);
            string pattern = "\"Version64\" type=\"int64\" value=\"";

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(pattern))
                {
                    int startIndex = lines[i].IndexOf(pattern) + pattern.Length;
                    int endIndex = lines[i].IndexOf("\"", startIndex);
                    string linePrefix = lines[i].Substring(0, startIndex);
                    string lineSuffix = lines[i].Substring(endIndex);
                    string replacedLine = linePrefix + newValue + lineSuffix;
                    lines[i] = replacedLine;
                    break; // 
                }
            }

            File.WriteAllLines(filePath, lines);
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 1)
            {
                numericUpDown1.Value = 1;
            }

            int[] versionNumbers = new int[] {
            (int)numericUpDown1.Value,
            (int) numericUpDown2.Value,
            (int)numericUpDown3.Value,
            (int)numericUpDown4.Value
           };
        
            long int64Value = 0;

            for (int i = 0; i < versionNumbers.Length; i++)
            {
                int64Value += (long)versionNumbers[i] << (55 - 15 * i);
            }

            // Set the value of textBoxVersion to the int64Value as a 17-character string
            textBoxVersion.Text = int64Value.ToString("D17");
        }
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown4.Value > 0)
            {
                long currentValue = long.Parse(textBoxVersion.Text);
                currentValue += 1;
                textBoxVersion.Text = currentValue.ToString("D17");
            }
            else
            {
                long currentValue = long.Parse(textBoxVersion.Text);
                currentValue -= 1;
                textBoxVersion.Text = currentValue.ToString("D17");
            }
        }
        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            DialogResult result = folderDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
            {
                string selectedFolder = folderDialog.SelectedPath;
                string modsFolder = Path.Combine(selectedFolder, "Mods");

                if (Directory.Exists(modsFolder))
                {
                    string parentFolder = Directory.GetParent(modsFolder).FullName;

                    FolderModName.Text = Path.GetFileName(parentFolder);

                    string[] subFolders = Directory.GetDirectories(modsFolder);
                    if (subFolders.Length > 0)
                    {
                        FolderYourShared.Text = Path.GetFileName(subFolders[0]);
                    }
                    else
                    {
                        MessageBox.Show("The \"Mods\" folder does not have any subfolders.");
                    }
                }
                else
                {
                    MessageBox.Show("Selected folder does not contain a \"Mods\" folder.");
                }
            }
        }
        private void buttonCreateFolders_Click(object sender, EventArgs e)
        {
            string exeLocation = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string modsFolderPath = Path.Combine("\"", "Mods" + 1);

            if (!Directory.Exists(modsFolderPath))
            {
                Directory.CreateDirectory(modsFolderPath);
            }

            string folderModName = Path.Combine(modsFolderPath, FolderModName.Text);
            string publicFolderPath = Path.Combine(modsFolderPath, folderModName, "Mods");
            string sharedFolderPath = Path.Combine(publicFolderPath, FolderYourShared.Text);

            // Check if the folders already exist, and create them if they don't
            if (!Directory.Exists(folderModName))
            {
                Directory.CreateDirectory(folderModName);
            }

            if (!Directory.Exists(publicFolderPath))
            {
                Directory.CreateDirectory(publicFolderPath);
            }

            if (!Directory.Exists(sharedFolderPath))
            {
                Directory.CreateDirectory(sharedFolderPath);
            }

            MessageBox.Show("Folders created successfully!");
        }
        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form3_FormClosing);

            // Set tooltip text for buttons
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.SetToolTip(buttonSelectFolder, "Select your main mod folder");
            toolTip1.SetToolTip(buttonCreateFolders, "Create Folders");
            toolTip1.SetToolTip(textBoxName, "Name of your mod folder. Auto filled in if you located your mod folder.");
            toolTip1.SetToolTip(textBox_creator, "Your Username on Nexus for example. Or if you want the name you want to go by for your BG3 mods");
            toolTip1.SetToolTip(textBoxDesc, "The description of your mod. In BG3 mod manager it shows up when hovering over the mod name");
            toolTip1.SetToolTip(textBoxShared2, "This is the name of your Shared folder in a similar structure to the above folder structure");
            toolTip1.SetToolTip(textBoxUniqueUUID, "This is your unique uuid. click update when you are happy");
            toolTip1.SetToolTip(button6, "Generate a Unique UUID. Your mod must have a unique UUID");
            toolTip1.SetToolTip(textBoxVersion, "This is how the number shows in the meta.lsx, in bg3 mod manager it will show as the number below");
            toolTip1.SetToolTip(button8, "Save your file to a location of your choice.");
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing event
            this.Hide(); // Hide the form instead of closing it
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form3_FormClosing);
        }

        private void textBoxUniqueUUID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVersion_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
