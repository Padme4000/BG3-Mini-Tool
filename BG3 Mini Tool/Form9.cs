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

namespace BG3_Mod_Templates
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();

            this.SuspendLayout();
            // 
            // Form9
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load_1);
            this.ResumeLayout(false);

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
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            {
                string filePath = "LSX Files\\Head_Merged.lsx";
                string newValue = textBox4.Text; // Replace with the name of your text box control

                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length >= 13)
                {
                    string pattern = "\".+\""; // Matches any value within quotation marks
                    string currentLine = lines[16]; // Line 16 is index 17 in the array
                    string replacedLine = Regex.Replace(currentLine, pattern, "\"ID\" type=\"FixedString\" value=\"" + newValue + "\"");
                    lines[16] = replacedLine;
                    File.WriteAllLines(filePath, lines);
                }
            }
        }

        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing event
            this.Hide(); // Hide the form instead of closing it
        }

        private void Form9_Load(object sender, EventArgs e)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Files (*.gr2)|*.gr2|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fullPath = openFileDialog.FileName;
                int index = fullPath.IndexOf("Generated", StringComparison.OrdinalIgnoreCase);

                if (index != -1)
                {
                    string selectedPath = fullPath.Substring(index);
                    textBoxMesh.Text = selectedPath;
                }
                else
                {
                    MessageBox.Show("Please select a file with 'Generated' in the path.");
                }
            }
            else
            {
                MessageBox.Show("Please select a .gr2 file.");
            }
        }

        private string HeadMaterialValue;

        private void comboBox1_Click(object sender, EventArgs e)
        {
            string filePath = "LSX Files\\Head Materials.txt";
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
                    HeadMaterialValue = value;
                }
            }
            comboBox1.DataSource = comboBoxItems;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedItem = comboBox1.SelectedItem.ToString();
                string filePath = "LSX Files\\Head Materials.txt";
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
                            HeadMaterialValue = value;
                            break;
                        }
                    }
                }
            }
        }


        private void UUIDGen_Unique_Click(object sender, EventArgs e)
        {
            {
                Guid guid = Guid.NewGuid();
                textBox4.Text = "" + guid.ToString();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string filePath = "LSX Files\\Head_Merged.lsx";

            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length >= 15)
            {
                string pattern = "\".+\""; // Matches any value within quotation marks
                string currentLine = lines[63]; // Line 63 is index 64 in the array
                string replacedLine = Regex.Replace(currentLine, pattern, "\"MaterialID\" type=\"FixedString\" value=\"" + HeadMaterialValue + "\"");
                lines[63] = replacedLine;
                File.WriteAllLines(filePath, lines);
            }

        }

        private void textBoxMesh_TextChanged(object sender, EventArgs e)
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

        private void Button1_Click(object sender, EventArgs e)
        {
            {
                string filePath = "LSX Files\\Head_Merged.lsx";
                string newValue = textBoxMesh.Text; // Replace with the name of your text box control

                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length >= 13)
                {
                    string pattern = "\".+\""; // Matches any value within quotation marks
                    string currentLine = lines[27]; // Line 27 is index 28 in the array
                    string replacedLine = Regex.Replace(currentLine, pattern, "\"SourceFile\" type=\"LSString\" value=\"" + newValue + "\"");
                    lines[27] = replacedLine;
                    File.WriteAllLines(filePath, lines);
                }
                if (lines.Length >= 13)
                {
                    string pattern2 = "\".+\""; // Matches any value within quotation marks
                    string currentLine = lines[29]; // Line 27 is index 28 in the array
                    string newValueWithoutExtension = Path.GetFileNameWithoutExtension(newValue);
                    string newPath = Path.GetDirectoryName(newValue); // Get the directory path of the new value
                    string replacedLine = Regex.Replace(currentLine, pattern2, "\"SourceFile\" type=\"LSString\" value=\"" + Path.Combine(newPath, newValueWithoutExtension + ".Dummy_Root.0") + "\"");
                    lines[29] = replacedLine;
                    File.WriteAllLines(filePath, lines);
                }
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            string filePath = "LSX Files\\Head_Merged.lsx";
            string searchFor = "\"Name\" type=\"LSString\" value=\"";
            string replaceWith = textBox2.Text;

            try
            {
                string fileContents;
                using (StreamReader sr = new StreamReader(filePath))
                {
                    fileContents = sr.ReadToEnd();
                }

                int startIndex = fileContents.IndexOf(searchFor) + searchFor.Length;
                if (startIndex == -1)
                {
                    Console.WriteLine("Search string not found.");
                    return;
                }

                int endIndex = fileContents.IndexOf('"', startIndex);
                if (endIndex == -1)
                {
                    Console.WriteLine("End of string not found.");
                    return;
                }

                string oldValue = fileContents.Substring(startIndex, endIndex - startIndex);
                string newValue = oldValue.Replace(oldValue, replaceWith);

                string newContents = fileContents.Substring(0, startIndex) + newValue + fileContents.Substring(endIndex);

                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.Write(newContents);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void ButtonCreateFolders_Click(object sender, EventArgs e)
        {
            string exeLocation = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string modsFolderPath = Path.Combine(exeLocation, "Mods");

            if (!Directory.Exists(modsFolderPath))
            {
                Directory.CreateDirectory(modsFolderPath);
            }

            string folderModName = Path.Combine(modsFolderPath, FolderModName.Text);
            string publicFolderPath = Path.Combine(modsFolderPath, folderModName, "Public");
            string yourSharedFolderPath = Path.Combine(publicFolderPath, textboxYourShared.Text);
            string contentFolderPath = Path.Combine(yourSharedFolderPath, "Content");
            string assetsFolderPath = Path.Combine(contentFolderPath, "Assets");
            string charactersFolderPath = Path.Combine(assetsFolderPath, "Characters");
            string customFolderPath = Path.Combine(charactersFolderPath, textboxCustom.Text);
            string headsFolderPath = Path.Combine(customFolderPath, "Heads");
            string headNameFolderPath = Path.Combine(headsFolderPath, textboxHeadName.Text);

            // Check if the folders already exist, and create them if they don't
            if (!Directory.Exists(folderModName))
            {
                Directory.CreateDirectory(folderModName);
            }

            if (!Directory.Exists(publicFolderPath))
            {
                Directory.CreateDirectory(publicFolderPath);
            }

            if (!Directory.Exists(yourSharedFolderPath))
            {
                Directory.CreateDirectory(yourSharedFolderPath);
            }

            if (!Directory.Exists(contentFolderPath))
            {
                Directory.CreateDirectory(contentFolderPath);
            }

            if (!Directory.Exists(assetsFolderPath))
            {
                Directory.CreateDirectory(assetsFolderPath);
            }

            if (!Directory.Exists(charactersFolderPath))
            {
                Directory.CreateDirectory(charactersFolderPath);
            }

            if (!Directory.Exists(customFolderPath))
            {
                Directory.CreateDirectory(customFolderPath);
            }

            if (!Directory.Exists(headsFolderPath))
            {
                Directory.CreateDirectory(headsFolderPath);
            }

            if (!Directory.Exists(headNameFolderPath))
            {
                Directory.CreateDirectory(headNameFolderPath);
            }

            MessageBox.Show("Folders created successfully!");
        }

        private void ButtonSelectFolder_Click(object sender, EventArgs e)
        {
            string exeLocation = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string modsFolderPath = Path.Combine(exeLocation, "Mods");

            using (var dialog = new FolderBrowserDialog())
            {
                dialog.SelectedPath = modsFolderPath;

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

                            string ContentPath = Path.Combine(publicPath, publicSubfolder, "Content");
                            if (!Directory.Exists(ContentPath))
                            {
                                MessageBox.Show("The selected folder does not contain a 'Content' subfolder.", "Missing Subfolder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private static string FindSubfolder(string[] folders, string subfolderName)
        {
            foreach (string folder in folders)
            {
                if (Path.GetFileName(folder) == subfolderName)
                {
                    return folder;
                }
            }
            return null;
        }

        private void Button_saveas_Click(object sender, EventArgs e)
        {
            // Get the current directory and the original file path
            string currentDirectory = Directory.GetCurrentDirectory();
            string originalFilePath = Path.Combine(currentDirectory, "LSX Files\\Head_Merged.lsx");

            // Show the save file dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "LSX Files (*.lsx)|*.lsx";
            saveFileDialog.FileName = "_merged.lsx";
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
        private void ButtonAddRegion_Click(object sender, EventArgs e)
        {
            string lsxFilePath = textBoxpath.Text;
            string lsxDirectory = Path.GetDirectoryName(lsxFilePath);

            // Check if the path is a valid path and doesn't contain illegal characters
            char[] invalidPathChars = Path.GetInvalidPathChars();
            if (lsxFilePath.IndexOfAny(invalidPathChars) >= 0)
            {
                MessageBox.Show("Please enter a valid path.", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the path includes a file extension
            if (!Path.HasExtension(lsxFilePath))
            {
                MessageBox.Show("Please enter a valid file path with extension.", "Invalid Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the LSX file exists
            if (!File.Exists(lsxFilePath))
            {
                MessageBox.Show("LSX file does not exist.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Read the LSX file and load it into an XML document
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(lsxFilePath);

            // Find the VisualBank region in the "LSX Files\\Head_Merged.lsx" file
            XmlDocument headXmlDocument = new XmlDocument();
            headXmlDocument.Load("LSX Files\\Head_Merged.lsx");
            XmlNode visualBankNode = headXmlDocument.SelectSingleNode("//region[@id='VisualBank']");

            // If the VisualBank region is not found, show an error message
            if (visualBankNode == null)
            {
                MessageBox.Show("VisualBank region not found in the Head_Merged.lsx file.", "Region Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Find the TextureBank region in the LSX file
            XmlNode TextureBankNode = xmlDocument.SelectSingleNode("//region[@id='TextureBank']");

            // If the TextureBank region is not found, show an error message
            if (TextureBankNode == null)
            {
                MessageBox.Show("TextureBank region not found in the LSX file.", "Region Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new VisualBank node with the text from the Head_Merged.lsx file
            XmlNode newVisualBankNode = xmlDocument.CreateElement("region");
            XmlAttribute newVisualBankIdAttribute = xmlDocument.CreateAttribute("id");
            newVisualBankIdAttribute.Value = "VisualBank";
            newVisualBankNode.Attributes.Append(newVisualBankIdAttribute);
            newVisualBankNode.InnerXml = visualBankNode.InnerXml;

            // Replace the existing VisualBank node or insert the new one after TextureBank node
            XmlNode existingVisualBankNode = xmlDocument.SelectSingleNode("//region[@id='VisualBank']");
            if (existingVisualBankNode != null)
            {
                existingVisualBankNode.ParentNode.ReplaceChild(newVisualBankNode, existingVisualBankNode);
            }
            else if (TextureBankNode.NextSibling != null)
            {
                TextureBankNode.ParentNode.InsertAfter(newVisualBankNode, TextureBankNode);
            }
            else
            {
                MessageBox.Show("Please use Save As to create a new LSX file with VisualBank region added.", "Region Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save the changes to the LSX file
            xmlDocument.Save(lsxFilePath);

            MessageBox.Show("VisualBank region added to the LSX file successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

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
                MessageBox.Show("Please select a Head _merged.lsx");
            }
        }       

        private void Form9_Load_1(object sender, EventArgs e)
        {

        }

        private void Form9_Resize(object sender, EventArgs e)
        {
            // Set the desired size of the form
            this.Size = new Size(1256, 556);

        }
    }
}
