using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BG3_Mini_Tool
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent(); 
            
            FolderPublic.Enabled = false;
            FolderCharacterCreation.Enabled = false;

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

        private void Update_name_Click(object sender, EventArgs e) //NewName
        {
            {
                string filePath = "LSX Files\\CharacterCreationAppearanceVisuals.lsx";
                string newValue = textBoxName.Text; // Replace with the name of your text box control

                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length >= 8)
                {
                    string pattern = "\".+\""; // Matches any value within quotation marks
                    string currentLine = lines[7]; // Line 9 is index 8 in the array
                    string replacedLine = Regex.Replace(currentLine, pattern, "\"DisplayName\" type=\"FixedString\" value=\"" + newValue + "\"");
                    lines[7] = replacedLine;
                    File.WriteAllLines(filePath, lines);
                }

            }
        }

        private void Update_UniqueUUID_Click(object sender, EventArgs e) //Unique UUID
        {
            {
                string filePath = "LSX Files\\CharacterCreationAppearanceVisuals.lsx";
                string newValue = textBoxUniqueUUID.Text; // Replace with the name of your text box control

                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length >= 13)
                {
                    string pattern = "\".+\""; // Matches any value within quotation marks
                    string currentLine = lines[12]; // Line 9 is index 8 in the array
                    string replacedLine = Regex.Replace(currentLine, pattern, "\"UUID\" type=\"guid\" value=\"" + newValue + "\"");
                    lines[12] = replacedLine;
                    File.WriteAllLines(filePath, lines);
                }
            }
        }

        private void Update_VisualResource_Click(object sender, EventArgs e) //Visual Resource UUID
        {
            {
                string filePath = "LSX Files\\CharacterCreationAppearanceVisuals.lsx";
                string newValue = textBoxVisualResource.Text; // Replace with the name of your text box control

                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length >= 14)
                {
                    string pattern = "\".+\""; // Matches any value within quotation marks
                    string currentLine = lines[13]; // Line 9 is index 8 in the array
                    string replacedLine = Regex.Replace(currentLine, pattern, "\"VisualResource\" type=\"guid\" value=\"" + newValue + "\"");
                    lines[13] = replacedLine;
                    File.WriteAllLines(filePath, lines);
                }

            }
        }

        private void Button2_Click(object sender, EventArgs e) //Bodytype Masc
        {
            {
                string filePath = "LSX Files\\CharacterCreationAppearanceVisuals.lsx";
                int lineToChange = 9;

                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length >= lineToChange)
                {
                    string lineToModify = lines[lineToChange - 1];
                    if (lineToModify.Contains("value=\"1\""))
                    {
                        lineToModify = lineToModify.Replace("value=\"1\"", "value=\"0\"");
                    }
                    lines[lineToChange - 1] = lineToModify;
                    File.WriteAllLines(filePath, lines);
                }

            }
        }

        private void Button8_Click(object sender, EventArgs e) //Bodytype Feminine
        {
            {
                string filePath = "LSX Files\\CharacterCreationAppearanceVisuals.lsx";
                int lineToChange = 9;

                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length >= lineToChange)
                {
                    string lineToModify = lines[lineToChange - 1];
                    if (lineToModify.Contains("value=\"0\""))
                    {
                        lineToModify = lineToModify.Replace("value=\"0\"", "value=\"1\"");
                    }
                    lines[lineToChange - 1] = lineToModify;
                    File.WriteAllLines(filePath, lines);
                }

            }
        }
        private void Button9_Click(object sender, EventArgs e) //Slotname Horns
        {

            string filePath = "LSX Files\\CharacterCreationAppearanceVisuals.lsx";
            string oldFixedString1 = "id=\"SlotName\" type=\"FixedString\" value=\"Head\"";
            string oldFixedString2 = "id=\"SlotName\" type=\"FixedString\" value=\"Horns\"";
            string newFixedString = "id=\"SlotName\" type=\"FixedString\" value=\"Horns\"";

            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(oldFixedString1))
                {
                    lines[i] = lines[i].Replace(oldFixedString1, newFixedString);
                }
                else if (lines[i].Contains(oldFixedString2))
                {
                    lines[i] = lines[i].Replace(oldFixedString2, newFixedString);
                }
            }
            File.WriteAllLines(filePath, lines);

        }
        private void Button3_Click(object sender, EventArgs e) //Slotname Head
        {

            string filePath = "LSX Files\\CharacterCreationAppearanceVisuals.lsx";
            string oldFixedString1 = "id=\"SlotName\" type=\"FixedString\" value=\"Head\"";
            string oldFixedString2 = "id=\"SlotName\" type=\"FixedString\" value=\"Horns\"";
            string newFixedString = "id=\"SlotName\" type=\"FixedString\" value=\"Head\"";

            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(oldFixedString1))
                {
                    lines[i] = lines[i].Replace(oldFixedString1, newFixedString);
                }
                else if (lines[i].Contains(oldFixedString2))
                {
                    lines[i] = lines[i].Replace(oldFixedString2, newFixedString);
                }
            }
            File.WriteAllLines(filePath, lines);

        }
        //Add new head/horns to existing CharacterCreationAppearanceVisuals
        //Save to existing file
        private void Button_add_Click(object sender, EventArgs e)
        {
            // Get the path of the file to add lines to
            string filePath = textBoxpath.Text;

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Path cannot be empty. Please use Locate lsx Button");
                return; // End the code execution here
            }

            // Ask for user confirmation before adding the lines
            DialogResult result = MessageBox.Show("Are you sure you want to add the lines from CharacterCreationAppearanceVisuals.lsx to the selected file?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return; // End the code execution here
            }

            // Read all lines from the file
            string[] allLines = File.ReadAllLines(filePath);

            // Get the path of the file to get lines from
            string sourceFilePath = "LSX Files\\CharacterCreationAppearanceVisuals.lsx";

            // Read lines 7 to 16 from the source file
            string[] linesToAdd = File.ReadAllLines(sourceFilePath).Skip(6).Take(9).ToArray();

            // Create a list to store the new lines
            List<string> newLines = new List<string>();

            // Loop through each line in the original file
            for (int i = 0; i < allLines.Length; i++)
            {
                // If we're at line 7, add the lines from the source file
                if (i == 6)
                {
                    newLines.AddRange(linesToAdd);
                }

                // Add the current line from the original file
                newLines.Add(allLines[i]);
            }

            // Write the new lines to the file
            File.WriteAllLines(filePath, newLines.ToArray());
        }
        //Determine file path and then add to text box
        private void Button_locateLSX_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.lsx)|*.lsx|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the text box text to the path of the selected file
                textBoxpath.Text = openFileDialog.FileName;
            }

            else
            {
                // Display a message if no file was selected
                MessageBox.Show("Please select a CharacterCreationAppearanceVisuals.lsx");
            }
        }

        private void textBoxpath_TextChanged(object sender, EventArgs e)
        {
            var textBox = (System.Windows.Forms.TextBox)sender;
            var g = textBox.CreateGraphics();
            var size = g.MeasureString(textBox.Text, textBox.Font);

            float widthRatio = textBox.Width / size.Width;
            float heightRatio = textBox.Height / size.Height;
            float ratio = Math.Min(widthRatio, heightRatio);

            float newSize = textBox.Font.Size * ratio;
            textBox.Font = new Font(textBox.Font.FontFamily, newSize, textBox.Font.Style);
        }
        private void Button_saveas_Click(object sender, EventArgs e)
        {
            // Get the current directory and the original file path
            string currentDirectory = Directory.GetCurrentDirectory();
            string originalFilePath = Path.Combine(currentDirectory, "LSX Files\\CharacterCreationAppearanceVisuals.lsx");

            // Show the save file dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "LSX Files (*.lsx)|*.lsx";
            saveFileDialog.FileName = "CharacterCreationAppearanceVisuals.lsx";
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
        private string? raceValue;

        private void comboBoxRaceUUID_Click(object sender, EventArgs e)
        {
            string filePath = "LSX Files\\Races.txt";
            List<string> comboBoxItems = new List<string>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                int colonIndex = line.IndexOf(':');
                if (colonIndex != -1)
                {
                    string item = line.Substring(0, colonIndex).Trim();
                    comboBoxItems.Add(item);

                    // Extract value after the colon
                    string value = line.Substring(colonIndex + 1).Trim();
                    // Assign to raceValue field
                    raceValue = value;
                }
            }
            comboBoxRaceUUID.DataSource = comboBoxItems;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRaceUUID.SelectedItem is null)
            {
                // Handle the case when no item is selected
                return;
            }

            string selectedItem = comboBoxRaceUUID.SelectedItem.ToString();
            string filePath = "LSX Files\\Races.txt";
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                int colonIndex = line.IndexOf(':');
                if (colonIndex != -1)
                {
                    string item = line.Substring(0, colonIndex).Trim();
                    if (item == selectedItem)
                    {
                        string value = line.Substring(colonIndex + 1).Trim();
                        raceValue = value;
                        break;
                    }
                }
            }
        }


        private void Update_RaceUUID_Click(object sender, EventArgs e)
        {
            string filePath = "LSX Files\\CharacterCreationAppearanceVisuals.lsx";

            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length >= 15)
            {
                string pattern = "\".+\""; // Matches any value within quotation marks
                string currentLine = lines[9]; // Line 9 is index 8 in the array
                string replacedLine = Regex.Replace(currentLine, pattern, "\"RaceUUID\" type=\"guid\" value=\"" + raceValue + "\"");
                lines[9] = replacedLine;
                File.WriteAllLines(filePath, lines);
            }
        }
        private void UUIDGen_Unique_Click(object sender, EventArgs e)
        {
            {
                Guid guid = Guid.NewGuid();
                textBoxUniqueUUID.Text = "" + guid.ToString();
            }

        }

        private void UUIDGen_VisualResource_Click(object sender, EventArgs e)
        {
            {
                Guid guid = Guid.NewGuid();
                textBoxVisualResource.Text = "" + guid.ToString();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Set tooltip text for Buttons
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.SetToolTip(comboBoxRaceUUID, "Select the race you are making the head/horns for. Then click Update");
            toolTip1.SetToolTip(textBoxName, "Can be anything you want.");
            toolTip1.SetToolTip(Button_saveas, "Save as a new file.");
            toolTip1.SetToolTip(Button_add, "Adds the information filled above from Display Name to VisualResource to the CharacterCreationAppearanceVisuals.lsx you define with Locate Button");
            toolTip1.SetToolTip(textBoxUniqueUUID, "Must be a unique UUID");
            toolTip1.SetToolTip(textBoxVisualResource, "Unique UUID must match your head/horns ID in their_merged");
            toolTip1.SetToolTip(textBoxpath, "Path to your mod file including the name of the lsx. This is so when you click \"Add to your mod file\" your new entry is added to your existing CharacterCreationAppearanceVisuals");
        }
        private void ButtonSelectFolder_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = dialog.SelectedPath;

                    string publicPath = Path.Combine(selectedPath, "Public");
                    if (Directory.Exists(publicPath))
                    {
                        string parentFolder = Directory.GetParent(publicPath).FullName;
                        FolderModName.Text = Path.GetFileName(parentFolder);

                        string[] subfolders = Directory.GetDirectories(publicPath);
                        if (subfolders.Length > 0)
                        {
                            string publicSubfolder = Path.GetFileName(subfolders[0]);
                            textboxYourShared.Text = publicSubfolder;

                            string characterCreationPath = Path.Combine(publicPath, publicSubfolder, "CharacterCreation");
                            if (!Directory.Exists(characterCreationPath))
                            {
                                MessageBox.Show("The selected folder does not contain a 'CharacterCreation' subfolder.", "Missing Subfolder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("The selected folder does not contain a subfolder in 'Public'.", "Missing Subfolder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The selected folder does not contain a 'Public' subfolder.", "Missing Subfolder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string publicFolderPath = Path.Combine(modsFolderPath, folderModName, "Public");
            string sharedFolderPath = Path.Combine(publicFolderPath, textboxYourShared.Text ?? string.Empty);
            string characterCreationFolderPath = Path.Combine(sharedFolderPath, "CharacterCreation");

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

            if (!Directory.Exists(characterCreationFolderPath))
            {
                Directory.CreateDirectory(characterCreationFolderPath);
            }

            MessageBox.Show("Folders created successfully!");
        }

        private void FolderModName_TextChanged(object sender, EventArgs e)
        {
            var textBox = (System.Windows.Forms.TextBox)sender;

            using (Graphics g = textBox.CreateGraphics())
            {
                SizeF textSize = g.MeasureString(textBox.Text, textBox.Font);

                float widthRatio = textBox.Width / textSize.Width;
                float heightRatio = textBox.Height / textSize.Height;
                float ratio = Math.Min(widthRatio, heightRatio);

                const float maxFontSize = 12f; 
                float newSize = textBox.Font.Size * ratio;

                if (newSize > maxFontSize)
                {
                    newSize = maxFontSize;
                }

                textBox.Font = new Font(textBox.Font.FontFamily, newSize, textBox.Font.Style);
            }
        }



        private void textboxYourShared_TextChanged(object sender, EventArgs e)
        {
            var textBox = (System.Windows.Forms.TextBox)sender;

            using (Graphics g = textBox.CreateGraphics())
            {
                SizeF textSize = g.MeasureString(textBox.Text, textBox.Font);

                float widthRatio = textBox.Width / textSize.Width;
                float heightRatio = textBox.Height / textSize.Height;
                float ratio = Math.Min(widthRatio, heightRatio);

                const float maxFontSize = 12f;
                float newSize = textBox.Font.Size * ratio;

                if (newSize > maxFontSize)
                {
                    newSize = maxFontSize;
                }

                textBox.Font = new Font(textBox.Font.FontFamily, newSize, textBox.Font.Style);
            }
        }

        private void Form2_FormClosing(object? sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing event
            this.Hide(); // Hide the form instead of closing it
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form2_FormClosing);
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            // Set the desired size of the form
            this.Size = new Size(1091, 525);
        }
    }
}

