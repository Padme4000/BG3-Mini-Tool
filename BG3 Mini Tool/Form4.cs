using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BG3_Mod_Templates
{
    public partial class Tools : Form
    {
        private Dictionary<string, string> uuidReplacementDict = new Dictionary<string, string>();
        private Dictionary<string, string> handleReplacementDict = new Dictionary<string, string>();

        public Tools()
        {
            InitializeComponent();

            numericUpDown4.Tag = numericUpDown4.Value;

            foreach (Control control in Controls)
            {
                if (control is System.Windows.Forms.TextBox)
                {
                    ((System.Windows.Forms.TextBox)control).ReadOnly = false;
                    textBoxVersion.ReadOnly = true;
                }
                else if (control is System.Windows.Forms.Panel)
                {
                    // Enable Buttons for interaction
                    control.Enabled = true;
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

        private void numericUpDown4_ValueChanged_1(object sender, EventArgs e)
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

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
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

        private void Tools_Resize(object sender, EventArgs e)
        {
            // Set the desired size of the form
            this.Size = new Size(600, 315);
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "LSX Files|*.lsx";
            openFileDialog.Title = "Select meta.lsx File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
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

                MessageBox.Show("Version information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing event
            this.Hide(); // Hide the form instead of closing it
        }

        private void textBoxHex_TextChanged(object sender, EventArgs e)
        {
            string hexColor = textBoxHex.Text.TrimStart('#');

            try
            {
                if (hexColor.Length == 6)
                {
                    byte r = byte.Parse(hexColor.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                    byte g = byte.Parse(hexColor.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                    byte b = byte.Parse(hexColor.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

                    float red = r / 255.0f;
                    float green = g / 255.0f;
                    float blue = b / 255.0f;

                    string srgbColor = $"{red:F6} {green:F6} {blue:F6}";
                    srgbColor = srgbColor.Replace(" ", "");

                    textBoxSRGB.Text = srgbColor;

                    // Update the color of panelColorBox
                    panelColorBox.BackColor = Color.FromArgb(r, g, b);
                }
                else if (hexColor.Length == 8)
                {
                    byte r = byte.Parse(hexColor.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                    byte g = byte.Parse(hexColor.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                    byte b = byte.Parse(hexColor.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
                    byte a = byte.Parse(hexColor.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);

                    float red = r / 255.0f;
                    float green = g / 255.0f;
                    float blue = b / 255.0f;
                    float alpha = a / 255.0f;

                    string srgbColor = $"{red:F6} {green:F6} {blue:F6}";
                    srgbColor = srgbColor.Replace(" ", "");

                    textBoxSRGB.Text = srgbColor;

                    // Update the color of panelColorBox
                    panelColorBox.BackColor = Color.FromArgb(r, g, b, a);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Hex Value is not in the correct format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private List<Color> customColors = new List<Color>();

        private void panelColorBox_Click(object sender, EventArgs e)
        {
            // Show the ColorDialog to get the user's color selection
            ColorDialog colorDialog = new ColorDialog();

            // Set custom colors if available
            if (customColors.Count > 0)
            {
                colorDialog.CustomColors = customColors.Select(c => ColorTranslator.ToOle(c)).ToArray();
            }

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Add the selected color to customColors
                customColors.Insert(0, colorDialog.Color);

                // Keep only the last 16 custom colors
                if (customColors.Count > 16)
                {
                    customColors.RemoveAt(customColors.Count - 1);
                }

                // Set the color of the panelColorBox to the selected color
                panelColorBox.BackColor = colorDialog.Color;

                // Convert the color to hex string
                string hexColor = ColorTranslator.ToHtml(colorDialog.Color);
                textBoxHex.Text = hexColor;

                // Convert the color to sRGB values in the range of 0 to 1.0
                float red = colorDialog.Color.R / 255.0f;
                float green = colorDialog.Color.G / 255.0f;
                float blue = colorDialog.Color.B / 255.0f;

                // Update the textBoxSRGB with the new sRGB values
                textBoxSRGB.Text = $"{red} {green} {blue}";
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            string srgbInput = textBoxSRGB.Text.Trim();
            string[] components = srgbInput.Split();

            if (components.Length != 3)
            {
                MessageBox.Show("Invalid SRGB format. Please enter valid values in the format '0.123 0.456 0.789'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                CultureInfo cultureInfo = CultureInfo.InvariantCulture;

                float red = float.Parse(components[0], NumberStyles.Float, cultureInfo);
                float green = float.Parse(components[1], NumberStyles.Float, cultureInfo);
                float blue = float.Parse(components[2], NumberStyles.Float, cultureInfo);

                if (red < 0 || red > 1 || green < 0 || green > 1 || blue < 0 || blue > 1)
                {
                    throw new FormatException();
                }

                byte r = (byte)(red * 255);
                byte g = (byte)(green * 255);
                byte b = (byte)(blue * 255);

                // Update textBoxHex and panelColorBox directly
                string hexColor = $"{r:X2}{g:X2}{b:X2}";
                textBoxHex.Text = hexColor;
                panelColorBox.BackColor = Color.FromArgb(r, g, b);

                // Update textBoxSRGB with formatted values and spaces
                textBoxSRGB.Text = $"{red:F7} {green:F7} {blue:F7}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid SRGB format. Please enter valid values in the format '0.123 0.456 0.789'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Copy the text to the clipboard
            Clipboard.SetText(textBoxSRGB.Text);
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

                // Check if the line contains any of the patterns to ignore
                bool shouldIgnore = patternsToIgnore.Any(patternToIgnore => line.Contains(patternToIgnore));

                // If we're inside an <node id="Object"> block and the line matches a pattern to ignore, skip it
                if (insideObjectNode && shouldIgnore)
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
                string currentHandle = match.Value.Substring(match.Value.IndexOf('"') + 1, 32);

                if (!handleReplacementDict.ContainsKey(currentHandle))
                {
                    // Check if the currentHandle matches any pattern from the ignore list
                    bool shouldIgnore = patternsToIgnore.Any(patternToIgnore => Regex.IsMatch(currentHandle, patternToIgnore));

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

        private void label5_Click(object sender, EventArgs e)
        {

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
    }
}
