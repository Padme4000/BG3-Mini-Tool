using System.Text.RegularExpressions;
using System.Xml;

namespace BG3_Mini_Tool
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear(); // Clear existing items

            string filePath = "LSX Files\\SlotName.txt";
            List<string> comboBoxItems = new List<string>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                comboBox1.Items.Add(line); // Add each line to the dropdown
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("Path to your mod file including the name of the lsx. This is so when you click \"Add to your mod file\" your new entry is added to your file");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "LSX Files", "CharacterCreationAppearanceVisuals_ForAll.lsx");

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

        private void button9_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "LSX Files", "CharacterCreationAppearanceVisuals_ForAll.lsx");
            string newValue = textBoxVisualResource.Text.Trim();

            try
            {
                // Load the XML document
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);

                // Get all nodes with the attribute "id" equal to "VisualResource"
                XmlNodeList visualResourceNodes = xmlDoc.SelectNodes("//attribute[@id='VisualResource']");

                // Update the "value" attribute for each matching node
                foreach (XmlNode visualResourceNode in visualResourceNodes)
                {
                    XmlAttribute valueAttribute = visualResourceNode.Attributes["value"];
                    if (valueAttribute != null)
                    {
                        // Update the "value" attribute with the new value
                        valueAttribute.Value = newValue;
                    }
                }

                // Save the updated XML document
                xmlDoc.Save(filePath);

                MessageBox.Show("VisualResource values updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "LSX Files", "CharacterCreationAppearanceVisuals_ForAll.lsx");
            string newText = textBox1.Text.Trim();

            try
            {
                string fileContent = File.ReadAllText(filePath);

                // Use a regular expression to find and replace text within comments with different formats
                string updatedContent = Regex.Replace(fileContent, @"<!--\s*(.*?)\s*""([^""]*)""\s*-->", match =>
                {
                    return $"<!-- {match.Groups[1].Value} \"{newText}\" -->";
                });

                File.WriteAllText(filePath, updatedContent);

                MessageBox.Show("Text within comments updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string filePath = "LSX Files\\CharacterCreationAppearanceVisuals_ForAll.lsx";
            string selectedValue = comboBox1.SelectedItem.ToString();

            try
            {
                // Load the XML content from the file
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);

                // Find all specific attribute nodes by their id and type
                XmlNodeList attributeNodes = xmlDoc.SelectNodes("//attribute[@id='SlotName' and @type='FixedString']");

                if (attributeNodes.Count > 0)
                {
                    foreach (XmlElement attributeNode in attributeNodes)
                    {
                        // Update the 'value' attribute with the selected value from comboBox1
                        attributeNode.SetAttribute("value", selectedValue);
                    }

                    // Save the modified XML content back to the file
                    xmlDoc.Save(filePath);

                    MessageBox.Show("Attributes with 'SlotName' and type 'FixedString' updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No matching attributes found in XML.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                MessageBox.Show("Please select a CharacterCreationAppearanceVisuals.lsx");
            }
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            // Get the path of the target file to add lines to
            string targetFilePath = textBoxpath.Text;

            if (string.IsNullOrEmpty(targetFilePath))
            {
                MessageBox.Show("Target file path cannot be empty. Please use the Locate lsx Button.");
                return;
            }

            // Ask for user confirmation before adding the lines
            DialogResult result = MessageBox.Show("Are you sure you want to add the lines from CharacterCreationAppearanceVisuals.lsx to the selected file?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                // Get the path of the source file to get lines from
                string sourceFilePath = "LSX Files\\CharacterCreationAppearanceVisuals_ForAll.lsx";

                // Load the XML content from the target file
                XmlDocument targetXmlDoc = new XmlDocument();
                targetXmlDoc.Load(targetFilePath);

                // Load the XML content from the source file
                XmlDocument sourceXmlDoc = new XmlDocument();
                sourceXmlDoc.Load(sourceFilePath);

                // Get the <children> element from the source XML
                XmlNode sourceChildrenNode = sourceXmlDoc.SelectSingleNode("//children");

                if (sourceChildrenNode != null)
                {
                    // Create a new XmlNodeList to hold the cloned nodes
                    XmlNodeList nodesToInsert = targetXmlDoc.ImportNode(sourceChildrenNode, true).ChildNodes;

                    // Get the <children> element from the target XML
                    XmlNode targetChildrenNode = targetXmlDoc.SelectSingleNode("//children");

                    if (targetChildrenNode != null)
                    {
                        // Append the cloned nodes at the end of the target <children> section
                        foreach (XmlNode node in nodesToInsert)
                        {
                            targetChildrenNode.AppendChild(targetXmlDoc.ImportNode(node, true));
                        }

                        // Save the modified XML content back to the target file
                        targetXmlDoc.Save(targetFilePath);

                        MessageBox.Show("Lines added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No <children> section found in the target file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No <children> section found in the source file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_saveas_Click(object sender, EventArgs e)
        {
            // Get the current directory and the original file path
            string currentDirectory = Directory.GetCurrentDirectory();
            string originalFilePath = Path.Combine(currentDirectory, "LSX Files\\CharacterCreationAppearanceVisuals_ForAll.lsx");

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

        private void button11_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("Make sure this matches the handle you give on the Localization editor. For assets sharing same name you can keep same handle and only are required to have it once in the xml/loca file");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("Just the name you want to use as a comment in the file to better organise the file if adding more to it");

        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("Might need to double click to show all slots. Change to the slot you are making your asset for and then click update.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("You want this to be the same UUID you gave to your asset in the Merged VisualBank section for that asset.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("This button will generate a unique UUID for all the slots at once in this file.");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("Use this if you haven't created a CharacterCreationAppearanceVisuals.lsx yet");

        }

        private void button19_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("If you already have a CharacterCreationAppearanceVisuals.lsx you can use this to save all these new entries to your file");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string filePath = "LSX Files\\CharacterCreationAppearanceVisuals_ForAll.lsx";
            string selectedHandle = textBoxNameHandle.Text.Trim();

            try
            {
                // Load the XML content from the file
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);

                // Find all specific attribute nodes by their id
                XmlNodeList attributeNodes = xmlDoc.SelectNodes("//attribute[@id='DisplayName']");

                if (attributeNodes.Count > 0)
                {
                    foreach (XmlElement attributeNode in attributeNodes)
                    {
                        // Update the 'handle' attribute with the selected handle from textBoxNameHandle
                        attributeNode.SetAttribute("handle", selectedHandle);
                    }

                    // Save the modified XML content back to the file
                    xmlDoc.Save(filePath);

                    MessageBox.Show("Handles for 'DisplayName' attributes updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No matching attributes found in XML.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Form5? Form5Instance;

        private void button5_Click(object sender, EventArgs e)
        {
            if (Form5Instance == null)
            {
                Form5Instance = new Form5();
                Form5Instance.Show();
            }
            else
            {
                Form5Instance.Show();
                Form5Instance.BringToFront();
            }
        }
        private string GenerateUniqueUuid()
        {
            return "h" + Guid.NewGuid().ToString("N");
        }
        private void button12_Click(object sender, EventArgs e)
        {
            string newUuid = GenerateUniqueUuid();
            textBoxNameHandle.Text = newUuid;
        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing event
            this.Hide(); // Hide the form instead of closing it
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
