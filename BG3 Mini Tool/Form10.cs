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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Button_saveas_Click(object sender, EventArgs e)
        {
            // Get the current directory and the path to the "MaterialGroups" folder
            string currentDirectory = Directory.GetCurrentDirectory();
            string MaterialGroupsFolderPath = Path.Combine(currentDirectory, "MaterialGroups");

            // Show the folder browser dialog to select the destination folder
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select a destination folder";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string destinationFolderPath = folderBrowserDialog.SelectedPath;

                // Get all files in the "MaterialGroups" folder
                string[] materialGroupFiles = Directory.GetFiles(MaterialGroupsFolderPath);

                // Copy each file to the selected destination folder
                foreach (string sourceFilePath in materialGroupFiles)
                {
                    string fileName = Path.GetFileName(sourceFilePath);
                    string destinationFilePath = Path.Combine(destinationFolderPath, fileName);

                    // Check if the file already exists in the destination folder
                    if (File.Exists(destinationFilePath))
                    {
                        DialogResult result = MessageBox.Show($"The file '{fileName}' already exists in the destination folder. Do you want to overwrite it?", "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                        {
                            continue;
                        }
                    }

                    // Copy the file to the destination folder
                    File.Copy(sourceFilePath, destinationFilePath, true);
                }

                MessageBox.Show("Files saved to the destination folder successfully!", "Files Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                        // Get the first subfolder before "Public"
                        string parentFolder = Directory.GetParent(publicPath).FullName;
                        FolderModName.Text = Path.GetFileName(parentFolder);

                        string enginePath = Path.Combine(publicPath, "Engine");

                        if (Directory.Exists(enginePath))
                        {
                            string timelinePath = Path.Combine(enginePath, "Timeline");

                            if (Directory.Exists(timelinePath))
                            {
                                string materialGroupsPath = Path.Combine(timelinePath, "MaterialGroups");

                                if (Directory.Exists(materialGroupsPath))
                                {
                                    // The entire folder structure "Public > Engine > Timeline > MaterialGroups" exists
                                    // Do your further processing here
                                }
                                else
                                {
                                    MessageBox.Show("The selected folder does not contain a 'MaterialGroups' subfolder in 'Timeline'.", "Missing Subfolder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("The selected folder does not contain a 'Timeline' subfolder in 'Engine'.", "Missing Subfolder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("The selected folder does not contain an 'Engine' subfolder in 'Public'.", "Missing Subfolder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string publicFolderPath = Path.Combine(folderModName, "Public");
            string engineFolderPath = Path.Combine(publicFolderPath, "Engine");
            string timelineFolderPath = Path.Combine(engineFolderPath, "Timeline");
            string materialGroupsFolderPath = Path.Combine(timelineFolderPath, "MaterialGroups");

            // Check if the folders already exist, and create them if they don't
            if (!Directory.Exists(folderModName))
            {
                Directory.CreateDirectory(folderModName);
            }

            if (!Directory.Exists(publicFolderPath))
            {
                Directory.CreateDirectory(publicFolderPath);
            }

            if (!Directory.Exists(engineFolderPath))
            {
                Directory.CreateDirectory(engineFolderPath);
            }

            if (!Directory.Exists(timelineFolderPath))
            {
                Directory.CreateDirectory(timelineFolderPath);
            }

            if (!Directory.Exists(materialGroupsFolderPath))
            {
                Directory.CreateDirectory(materialGroupsFolderPath);
            }

            MessageBox.Show("Folders created successfully!");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Get the value from textBoxVisualResource
            string newValue = textBoxVisualResource.Text;

            // Specify the folder path
            string folderPath = @"LSX Files/MaterialGroups_Edited";

            // Check if the folder exists
            if (Directory.Exists(folderPath))
            {
                // Get all XML files in the folder
                string[] xmlFiles = Directory.GetFiles(folderPath, "*.lsx");

                foreach (string xmlFile in xmlFiles)
                {
                    try
                    {
                        // Load the XML document
                        XmlDocument doc = new XmlDocument();
                        doc.Load(xmlFile);

                        // Find the element with the specified attribute
                        XmlNode node = doc.SelectSingleNode("//attribute[@id='VisualResourceID']");

                        // Update the attribute value
                        if (node != null)
                        {
                            node.Attributes["value"].Value = newValue;

                            // Save the modified XML back to the file
                            doc.Save(xmlFile);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any errors that occur during processing
                        Console.WriteLine($"Error updating file {xmlFile}: {ex.Message}");
                    }
                }

                MessageBox.Show("Attribute updated in all XML files.");
            }
            else
            {
                MessageBox.Show("Folder not found: " + folderPath);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            // Specify the folder path
            string folderPath = @"LSX Files/MaterialGroups_Edited";

            // Check if the folder exists
            if (Directory.Exists(folderPath))
            {
                // Get all XML files in the folder
                string[] xmlFiles = Directory.GetFiles(folderPath, "*.lsx");

                foreach (string xmlFile in xmlFiles)
                {
                    try
                    {
                        // Load the XML document
                        XmlDocument doc = new XmlDocument();
                        doc.Load(xmlFile);

                        // Find all elements with the specified attribute
                        XmlNodeList nodes = doc.SelectNodes("//attribute[@id='Key']");

                        // Generate unique UUIDs for each element
                        foreach (XmlNode node in nodes)
                        {
                            string uniqueUuid = Guid.NewGuid().ToString();
                            node.Attributes["value"].Value = uniqueUuid;
                        }

                        // Save the modified XML back to the file
                        doc.Save(xmlFile);
                    }
                    catch (Exception ex)
                    {
                        // Handle any errors that occur during processing
                        Console.WriteLine($"Error updating file {xmlFile}: {ex.Message}");
                    }
                }

                MessageBox.Show("Unique UUIDs generated and updated in all XML files.");
            }
            else
            {
                MessageBox.Show("Folder not found: " + folderPath);
            }
        }

        private void Button_locateLSX_Click(object sender, EventArgs e)
        {
            // Create a FolderBrowserDialog and set its properties
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select the folder containing XML files";

            // Show the FolderBrowserDialog
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected folder path
                string selectedFolderPath = folderBrowserDialog.SelectedPath;

                // Update the designated text box with the selected folder path
                textBoxpath.Text = selectedFolderPath;

                // Now, you can use 'selectedFolderPath' for further processing.
            }
            else
            {
                // Display a message if the folder selection was canceled
                MessageBox.Show("Folder selection canceled.");
            }
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the path of the target folder
                string targetFolderPath = textBoxpath.Text;

                if (string.IsNullOrEmpty(targetFolderPath) || !Directory.Exists(targetFolderPath))
                {
                    MessageBox.Show("Target folder does not exist. Please use the Locate lsx Button.");
                    return;
                }

                // Get the folder path of the source files
                string sourceFolderPath = "LSX Files/MaterialGroups_Edited";

                // Get a list of all XML files in the source folder
                string[] sourceFiles = Directory.GetFiles(sourceFolderPath, "*.lsx");

                foreach (string sourceFile in sourceFiles)
                {
                    // Get the file name without extension
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(sourceFile);

                    // Construct the target file path based on the file name
                    string targetFilePath = Path.Combine(targetFolderPath, fileNameWithoutExtension + ".lsx");

                    // Check if the target file exists
                    if (File.Exists(targetFilePath))
                    {
                        // Load the XML content from the source file
                        XmlDocument sourceXmlDoc = new XmlDocument();
                        sourceXmlDoc.Load(sourceFile);

                        // Get the <children> element from the source XML
                        XmlNode sourceChildrenNode = sourceXmlDoc.SelectSingleNode("//children");

                        if (sourceChildrenNode != null)
                        {
                            // Load the XML content from the target file
                            XmlDocument targetXmlDoc = new XmlDocument();
                            targetXmlDoc.Load(targetFilePath);

                            // Get the <children> element from the target XML
                            XmlNode targetChildrenNode = targetXmlDoc.SelectSingleNode("//children");

                            if (targetChildrenNode != null)
                            {
                                // Create a new XmlNodeList to hold the cloned nodes
                                XmlNodeList nodesToInsert = targetXmlDoc.ImportNode(sourceChildrenNode, true).ChildNodes;

                                // Append the cloned nodes at the end of the target <children> section
                                foreach (XmlNode node in nodesToInsert)
                                {
                                    targetChildrenNode.AppendChild(targetXmlDoc.ImportNode(node, true));
                                }

                                // Save the modified XML content back to the target file
                                targetXmlDoc.Save(targetFilePath);
                            }
                        }
                    }
                }

                MessageBox.Show("Content added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("These files are required to have your head added in order for visual effects to work such as speak with the dead. Due to the amount of files I made this tool to automate the process a bit more.");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("Search if the folders already exist and if not use the create button. It will add them to a Mods folder where the exe is. You can copy and paste those from there if you have another area you keep your mod folders.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("Add the ID from your assets visualbank here and click update.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("This button generates unique UUIDs where they are needed");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("Locate where your MaterialGroups folder is, so when using Add to your files it knows where to look");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("Use this to save the base files your entries need adding to if you don't already have them");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("Add the new entries we made via updating with the VisualResource and Generate unique UUIDs to the main files in our mod. If you don't have those files please use the Save button first");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string folderPath = @"LSX Files/MaterialGroups_Edited";
            string newText = textBox1.Text.Trim();

            // Check if the folder exists
            if (Directory.Exists(folderPath))
            {
                try
                {
                    string[] xmlFiles = Directory.GetFiles(folderPath, "*.lsx");

                    foreach (string xmlFile in xmlFiles)
                    {
                        // Read the content of the XML file
                        string fileContent = File.ReadAllText(xmlFile);

                        // Use a regular expression to find and replace text within comments with different formats
                        string updatedContent = Regex.Replace(fileContent, @"<!--\s*(.*?)\s*""([^""]*)""\s*-->", match =>
                        {
                            return $"<!-- {match.Groups[1].Value} \"{newText}\" -->";
                        });

                        // Write the updated content back to the XML file
                        File.WriteAllText(xmlFile, updatedContent);
                    }

                    MessageBox.Show("Text within comments updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
