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

            foreach (Control control in Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    // Enable user input in text boxes
                    ((System.Windows.Forms.TextBox)control).ReadOnly = false;
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
        private void Button7_Click(object sender, EventArgs e) //Version Number
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
            string modsFolderPath = Path.Combine("\"", "Mods" + 1);

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

        private void Form3_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form3_FormClosing);

            // Set tooltip text for Buttons
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.SetToolTip(ButtonSelectFolder, "Select your main mod folder");
            toolTip1.SetToolTip(ButtonCreateFolders, "Create Folders");
            toolTip1.SetToolTip(textBoxName, "Name of your mod folder. Auto filled in if you located your mod folder.");
            toolTip1.SetToolTip(textBox_creator, "Your Username on Nexus for example. Or if you want the name you want to go by for your BG3 mods");
            toolTip1.SetToolTip(textBoxDesc, "The description of your mod. In BG3 mod manager it shows up when hovering over the mod name");
            toolTip1.SetToolTip(textBoxShared2, "This is the name of your Shared folder in a similar structure to the above folder structure");
            toolTip1.SetToolTip(textBoxUniqueUUID, "This is your unique uuid. click Update when you are happy");
            toolTip1.SetToolTip(Button6, "Generate a Unique UUID. Your mod must have a unique UUID");
            toolTip1.SetToolTip(textBoxVersion, "This is how the number shows in the meta.lsx, in bg3 mod manager it will show as the number below");
            toolTip1.SetToolTip(Button8, "Save your file to a location of your choice.");
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

        private void FolderModName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
