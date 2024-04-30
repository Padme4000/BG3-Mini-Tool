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
    public partial class MassReplace : Form
    {
        private Dictionary<string, string> uuidReplacementDict = new Dictionary<string, string>();
        private Dictionary<string, string> handleReplacementDict = new Dictionary<string, string>();

        public MassReplace()
        {
            InitializeComponent();
        }

        private void MassReplace_Load(object sender, EventArgs e)
        {

        }

        private void replace_handles_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                ProcessHandles(selectedPath);
            }
        }
        private void ProcessHandles(string directory)
        {
            string[] lsxFiles = Directory.GetFiles(directory, "*.lsx", SearchOption.AllDirectories);
            string[] xmlFiles = Directory.GetFiles(directory, "*.xml", SearchOption.AllDirectories);

            foreach (string filePath in lsxFiles.Concat(xmlFiles))
            {
                string content = File.ReadAllText(filePath);
                string updatedContent = ProcessHandlesInContent(content);

                File.WriteAllText(filePath, updatedContent);
            }

            MessageBox.Show("Handle replacement has finished processing.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string[] patternsToIgnore;

        private string[] GetIgnoreList()
        {
            string exeDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string ignoreListPath = Path.Combine(exeDirectory, "LSX Files", "IgnoreList.txt");

            if (File.Exists(ignoreListPath))
            {
                return File.ReadAllLines(ignoreListPath);
            }

            return new string[0]; // Return an empty array if the file doesn't exist
        }

        private void replace_uuid_Click(object sender, EventArgs e)
        {
            patternsToIgnore = GetIgnoreList();

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                ProcessUUIDs(selectedPath);
            }
        }

        private void ProcessUUIDs(string directory)
        {
            string[] lsxFiles = Directory.GetFiles(directory, "*.lsx", SearchOption.AllDirectories);
            string[] txtFiles = Directory.GetFiles(directory, "*.txt", SearchOption.AllDirectories);

            foreach (string filePath in lsxFiles.Concat(txtFiles))
            {
                string content = File.ReadAllText(filePath);
                string updatedContent = ProcessUUIDsInContent(content);

                File.WriteAllText(filePath, updatedContent);
            }

            MessageBox.Show("UUID replacement has finished processing.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string ProcessUUIDsInContent(string content)
        {
            string updatedContent = content;
            string uuidPattern = @"[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}";

            // Split the content into lines
            string[] lines = updatedContent.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            bool insideObjectNode = false; // Flag to track if inside <node id="Object"> block

            // Process each line individually
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                if (line.Contains("<node id=\"Object\">"))
                {
                    insideObjectNode = true;
                }
                else if (line.Contains("</node>"))
                {
                    insideObjectNode = false;
                }

                // If we're inside an <node id="Object"> block, skip further processing
                if (insideObjectNode)
                {
                    continue;
                }

                // Replace UUIDs in the line
                lines[i] = Regex.Replace(line, uuidPattern, match =>
                {
                    string currentUUID = match.Value;

                    if (!uuidReplacementDict.ContainsKey(currentUUID))
                    {
                        uuidReplacementDict[currentUUID] = Guid.NewGuid().ToString();
                    }

                    return uuidReplacementDict[currentUUID];
                });

                // Ignore List
                bool shouldIgnore = patternsToIgnore.Any(patternToIgnore =>
                {
                    string pattern = patternToIgnore.Trim();

                    // Check if the line contains the attribute name (enclosed in double quotes) or the attribute name alone
                    if (line.Contains($"\"{pattern}\"") || line.Contains(pattern))
                    {
                        return true; // Ignore the line if it matches an attribute name
                    }

                    return false;
                });

                // If the line should be ignored, revert UUID replacement
                if (shouldIgnore)
                {
                    lines[i] = line; // Revert the line to its original state
                    continue;
                }
            }

            // Reconstruct the updated content from the modified lines
            updatedContent = string.Join(Environment.NewLine, lines);

            return updatedContent;
        }


        private string ProcessHandlesInContent(string content)
        {
            string updatedContent = content;
            string handlePattern = @"(handle\s*=\s*"")[^""]*""|contentuid\s*=\s*""[^""]*""";

            // Process Handles
            updatedContent = Regex.Replace(updatedContent, handlePattern, match =>
            {
                int indexOfQuote = match.Value.IndexOf('"');
                string currentHandle = !string.IsNullOrEmpty(match.Value) && indexOfQuote >= 0
                ? match.Value.Substring(indexOfQuote + 1, 32)
                : string.Empty;

                if (!handleReplacementDict.ContainsKey(currentHandle))
                {
                    // Check if the currentHandle matches any pattern from the ignore list
                    bool shouldIgnore = patternsToIgnore != null && patternsToIgnore.Any(patternToIgnore => Regex.IsMatch(currentHandle, patternToIgnore));


                    if (!shouldIgnore)
                    {
                        handleReplacementDict[currentHandle] = GenerateUniqueHandle();
                    }
                }

                return handleReplacementDict.ContainsKey(currentHandle) ? $"{match.Value.Substring(0, match.Value.IndexOf('=') + 2)}{handleReplacementDict[currentHandle]}\"" : match.Value;
            });

            return updatedContent;
        }

        private string GenerateUniqueHandle()
        {
            return "h" + Guid.NewGuid().ToString("N");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("Add lines that has UUIDs you don't want to change as well as specific UUIDS to the LSX Files/IgnoreList.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("Add the AnimationSetBank ID to the LSX Files/IgnoreList.txt and SkeletonBank ID if using vanilla assets for those sections");
        }

        private void MassReplace_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void MassReplace_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing event
            this.Hide(); // Hide the form instead of closing it
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the OpenFileDialog class
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the initial directory and filter for the file dialog
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "LSX Files (*.lsx)|*.lsx|All files (*.*)|*.*";

            // Show the file dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    // Load the XML document
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(filePath);

                    // Get all nodes with the attribute "id" equal to "UUID"
                    XmlNodeList uuidNodes = xmlDoc.SelectNodes("//attribute[@id='UUID']");

                    // Generate and replace UUIDs for each node
                    foreach (XmlNode uuidNode in uuidNodes)
                    {
                        // Generate a new UUID
                        Guid newUuid = Guid.NewGuid();

                        // Update the "value" attribute with the new UUID
                        XmlAttribute valueAttribute = uuidNode.Attributes["value"];
                        if (valueAttribute != null)
                        {
                            valueAttribute.Value = newUuid.ToString();
                        }
                    }

                    // Save the updated XML document
                    xmlDoc.Save(filePath);

                    MessageBox.Show("UUIDs updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("Use this if all you want to do is generate a unique UUID for the UUID lines in a selected LSX file");
        }
    }
}
