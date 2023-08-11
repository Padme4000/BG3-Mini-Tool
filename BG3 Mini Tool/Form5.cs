using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BG3_Mini_Tool
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            FolderLocalization.Enabled = false;
            FolderEnglish.Enabled = false;

            foreach (Control control in Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    // Enable user input in text boxes
                    ((System.Windows.Forms.TextBox)control).ReadOnly = false;
                }
                else if (control is System.Windows.Forms.Button)
                {
                    // Enable Buttons for interaction
                    control.Enabled = true;
                }
                else
                {
                    // Disable other controls to prevent interaction
                    control.Enabled = false;
                }
                if (control is System.Windows.Forms.ComboBox)
                {
                    control.Enabled = true;
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSelectFolder_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = dialog.SelectedPath;

                    string LocalizationPath = Path.Combine(selectedPath, "Localization");
                    if (Directory.Exists(LocalizationPath))
                    {
                        string parentFolder = Directory.GetParent(LocalizationPath).FullName;
                        FolderModName.Text = Path.GetFileName(parentFolder);

                        string[] subfolders = Directory.GetDirectories(LocalizationPath);
                        if (subfolders.Length > 0)
                        {
                            string EnglishFolderPath = Path.Combine(LocalizationPath, "English");
                            if (!Directory.Exists(EnglishFolderPath))
                            {
                                MessageBox.Show("The selected folder does not contain a 'English' subfolder.", "Missing Subfolder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("The selected folder does not contain a subfolder in 'Localization'.", "Missing Subfolder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The selected folder does not contain a 'Localization' subfolder.", "Missing Subfolder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void ButtonCreateFolders_Click(object sender, EventArgs e)
        {
            string exeLocation = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string modsFolderPath = Path.Combine(exeLocation ?? throw new InvalidOperationException(), "Mods");

            if (!Directory.Exists(modsFolderPath))
            {
                Directory.CreateDirectory(modsFolderPath);
            }

            string folderModName = Path.Combine(modsFolderPath, FolderModName.Text ?? string.Empty);
            string LocalizationPath = Path.Combine(modsFolderPath, folderModName, "Localization");
            string EnglishFolderPath = Path.Combine(LocalizationPath, "English");

            // Check if the folders already exist, and create them if they don't
            if (!Directory.Exists(folderModName))
            {
                Directory.CreateDirectory(folderModName);
            }

            if (!Directory.Exists(LocalizationPath))
            {
                Directory.CreateDirectory(LocalizationPath);
            }

            if (!Directory.Exists(EnglishFolderPath))
            {
                Directory.CreateDirectory(EnglishFolderPath);
            }

            MessageBox.Show("Folders created successfully!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("Fill in or use the Check Mod Folder Button to check if your mod folder includes the folder for the Localization file");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("Make sure this matches the handle you give on the CharacterCreationAppearanceVisuals editor. For assets sharing same name you can keep same handle and only are required to have it once in the xml/loca file");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("What you put here is what shows up as its name in Character Creation.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("Locate your Localization file if you have one already. If you do not have one. once you have finished filling this form out and using the Update buttons please use Save As");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("If you have located your localization file then use this to add new lines to that file.");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("If you do not have a localization file please use this Save as and save it to your Localization\\English folder once you have finished editing");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("If you have finished adding to your localization file open up LSLib and go to the Localization tab and in the Input file Path put your path to your xml including the extension of .xml and then paste the same into Output File Path but now make the extension .loca and click convert");
        }

        private void Button_locateLSX_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.xml)|*.xml|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the text box text to the path of the selected file
                textBoxpath.Text = openFileDialog.FileName;
            }

            else
            {
                // Display a message if no file was selected
                MessageBox.Show("Please select a localization .xml file");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Get the current directory and the original file path
            string currentDirectory = Directory.GetCurrentDirectory();
            string originalFilePath = Path.Combine(currentDirectory, "LSX Files\\custom_name_here.xml");

            // Show the save file dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog.FileName = ".xml";
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

        private void button11_Click(object sender, EventArgs e)
        {
            // Get the path of the file to add lines to
            string filePath = textBoxpath.Text;

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Path cannot be empty. Please use Locate Localization Button");
                return; // End the code execution here
            }

            // Ask for user confirmation before adding the lines
            DialogResult result = MessageBox.Show("Are you sure you want to add the lines from custom_name_here.xml to the selected file?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return; // End the code execution here
            }

            // Read all lines from the file
            string[] allLines = File.ReadAllLines(filePath);

            // Get the path of the file to get lines from
            string sourceFilePath = "LSX Files\\custom_name_here.xml";

            // Read lines 7 to 16 from the source file
            string[] linesToAdd = File.ReadAllLines(sourceFilePath).Skip(2).Take(1).ToArray();

            // Create a list to store the new lines
            List<string> newLines = new List<string>();

            // Loop through each line in the original file
            for (int i = 0; i < allLines.Length; i++)
            {
                // If we're at line 7, add the lines from the source file
                if (i == 2)
                {
                    newLines.AddRange(linesToAdd);
                }

                // Add the current line from the original file
                newLines.Add(allLines[i]);
            }

            // Write the new lines to the file
            File.WriteAllLines(filePath, newLines.ToArray());
        }
        private string GenerateUniqueUuid()
        {
            return "h" + Guid.NewGuid().ToString("N");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string newUuid = GenerateUniqueUuid();
            textBoxNameHandle.Text = newUuid;
        }

        private void Update_name_Click(object sender, EventArgs e)
        {
            string filePath = "LSX Files\\custom_name_here.xml";
            string newValue = textBoxNameHandle.Text;

            string[] lines = File.ReadAllLines(filePath);
            string pattern = "<content contentuid=\"";


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
                    break; // Assuming you want to replace only the first occurrence
                }
            }

            // Write the modified lines back to the file
            File.WriteAllLines(filePath, lines);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filePath = "LSX Files\\custom_name_here.xml";
            string newValue = textBox1.Text;

            string[] lines = File.ReadAllLines(filePath);
            string patternStart = "version=\"1\">";
            string patternEnd = "</content>";

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(patternStart) && lines[i].Contains(patternEnd))
                {
                    int startIndex = lines[i].IndexOf(patternStart) + patternStart.Length;
                    int endIndex = lines[i].IndexOf(patternEnd, startIndex);
                    string linePrefix = lines[i].Substring(0, startIndex);
                    string lineSuffix = lines[i].Substring(endIndex);
                    string replacedLine = linePrefix + newValue + lineSuffix;
                    lines[i] = replacedLine;
                    break; // Assuming you want to replace only the first occurrence
                }
            }
            // Write the modified lines back to the file
            File.WriteAllLines(filePath, lines);
        }

        private void textBoxNameHandle_Click(object sender, EventArgs e)
        {
            // Copy the text to the clipboard
            Clipboard.SetText(textBoxNameHandle.Text);
        }
    }
}
