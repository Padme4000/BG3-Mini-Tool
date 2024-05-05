using System.Reflection;
using System;
using System.Linq;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace BG3_Mod_Templates
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            numericUpDown4.Tag = numericUpDown4.Value;

            FolderMods.ReadOnly = true;

            foreach (Control control in Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    ((System.Windows.Forms.TextBox)control).ReadOnly = false;
                    textBoxVersion.ReadOnly = true;
                }
                else if (control is System.Windows.Forms.Button)
                {
                    // Enable Buttons for interaction
                    control.Enabled = true;
                }
                else if (control is System.Windows.Forms.NumericUpDown)
                {

                    ((NumericUpDown)control).Enabled = true;

                    numericUpDown1.Value = 1;
                    numericUpDown3.Value = 0;
                    numericUpDown3.Enabled = false;

                    numericUpDown2.Value = 0;
                    numericUpDown2.Enabled = false;

                }
                else
                {
                    // Disable other controls to prevent interaction
                    control.Enabled = false;
                }
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            {
                Guid guid = Guid.NewGuid();
                textBoxUniqueUUID.Text = "" + guid.ToString();
            }
        }

        private void Button5_Click(object sender, EventArgs e) //Mod Creator
        {
            string filePath = "LSX Files\\meta.lsx";
            string newValue = textBox_creator.Text;

            string[] lines = File.ReadAllLines(filePath);
            string pattern = "\"Author\" type=\"LSString\" value=\"";

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

        private void Button1_Click(object sender, EventArgs e) //Mod Name
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

        private void Button2_Click(object sender, EventArgs e) //Mod Description
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

        private void Button3_Click(object sender, EventArgs e) //Shared Folder
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

        private void Button4_Click(object sender, EventArgs e) //Unique UUID
        {
            string filePath = "LSX Files\\meta.lsx";
            string newValue = textBoxUniqueUUID.Text;

            string[] lines = File.ReadAllLines(filePath);
            string pattern = "\"UUID\" type=\"FixedString\" value=\"";

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
                    // Don't break here, so that it continues searching for other instances
                }
            }

            File.WriteAllLines(filePath, lines);
        }

        private void Button7_Click(object sender, EventArgs e)
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
                }
            }

            File.WriteAllLines(filePath, lines);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            long currentValue = long.Parse(textBoxVersion.Text);
            decimal previousValue = (decimal)numericUpDown4.Tag;

            if (numericUpDown4.Value > previousValue)
            {
                currentValue += 1;
            }
            else if (numericUpDown4.Value < previousValue)
            {
                currentValue -= 1;
            }

            textBoxVersion.Text = currentValue.ToString("D17");
            numericUpDown4.Tag = numericUpDown4.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 1)
            {
                numericUpDown1.Value = 1;
            }

            numericUpDown4.Value = 0;

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
        private void ButtonSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            DialogResult result = folderDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
            {
                string selectedFolder = folderDialog.SelectedPath;
                string modsFolder = Path.Combine(selectedFolder, "Mods");

                if (Directory.Exists(modsFolder))
                {
                    string? parentFolder = Directory.GetParent(modsFolder)?.FullName;
                    if (!string.IsNullOrEmpty(parentFolder))
                    {
                        FolderModName.Text = Path.GetFileName(parentFolder);
                    }

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


        private void ButtonCreateFolders_Click(object sender, EventArgs e)
        {
            string exeLocation = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string modsFolderPath = Path.Combine(exeLocation, "Mods"); // Assuming you want "Mods1" folder

            if (!Directory.Exists(modsFolderPath))
            {
                Directory.CreateDirectory(modsFolderPath);
            }

            string folderModName = Path.Combine(modsFolderPath, FolderModName.Text ?? string.Empty);
            string publicFolderPath = Path.Combine(modsFolderPath, folderModName, "Mods");
            string sharedFolderPath = Path.Combine(publicFolderPath, FolderYourShared.Text ?? string.Empty);

            if (folderModName is null || publicFolderPath is null || sharedFolderPath is null)
            {
                // Handle the case when any of the paths are null
                MessageBox.Show("Invalid folder paths.");
                return;
            }

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



        private void Button8_Click(object sender, EventArgs e)
        {
            // Get the current directory and the original file path
            string currentDirectory = Directory.GetCurrentDirectory();
            string originalFilePath = Path.Combine(currentDirectory, "LSX Files\\meta.lsx");

            // Show the save file dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "LSX Files (*.lsx)|*.lsx";
            saveFileDialog.FileName = "meta.lsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Check if the file already exists
                if (File.Exists(saveFileDialog.FileName))
                {
                    DialogResult result = MessageBox.Show("The file already exists. Do you want to overwrite it?", "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }

                // Save the file to the new location
                File.Copy(originalFilePath, saveFileDialog.FileName, true);
                MessageBox.Show("File saved successfully!", "File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form3_FormClosing(object? sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing event
            this.Hide(); // Hide the form instead of closing it
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form3_FormClosing);
        }

        private void numericUpDown1_Resize(object sender, EventArgs e)
        {
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form3_FormClosing);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("Fill in or use the Check Mod Folder Button to check if your mod folder includes the folder for the meta.lsx file");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("Add the name you want the mod to be shown as created by. This can be your nexusmods handle or whatever you want.");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("Whatever you want the name of your mod to be.");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("Give your mod a little description, can be a brief description on what it does.");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("Give your shared folder a name, most usually give it same name as the mod name. It is your mods equivelant of the games Pathing system. For example Public\\Shared\\CharacterCreation. and this needs to be different to the word Shared in our mods which is why we give it a unique name such as the name of our mod. This is also what we name the Shared folder when creating out folders. Like you may have done in the folder creation at the top of this page.");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("Always generate a new Unique UUID when creating a new mod so this doesn't override other peoples mods. Use the Generate Unique UUID button to generate a new one");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("Clicking the Generate Unique UUID button will generate a new unique UUID which will auto fill the above box which then you can click update to update your meta.lsx with a new UUID.");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("This is how the number shows in the meta.lsx, in bg3 mod manager it will show as the number below. If this is your first version of your mod you can leave the numbers at 1.0.0.0 and just click Update to make sure the version number is set to 1.0.0.0 (36028797018963968). If you are updating the whole meta.lsx for your mod you can change the version number to match your update.");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("If you do not have a meta.lsx file or wish to override one please use this Save as and save it to your Mods\\YourShared folder once you have finished editing");
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("This file needs to remain as .lsx so once you have finished adding to it and saved your file, the file is finished and needs no further actions");
        }

        private void textBoxVersion_Click(object sender, EventArgs e)
        {
            // Copy the text to the clipboard
            Clipboard.SetText(textBoxVersion.Text);
        }
    }
}
