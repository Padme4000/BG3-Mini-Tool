using BG3_Mini_Tool;
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
        private void Tools_Load(object sender, EventArgs e)
        {

        }

        private ColourWheel? colourwheelInstance;
        private void Button4_Click_1(object sender, EventArgs e)
        {
            if (colourwheelInstance == null)
            {
                colourwheelInstance = new ColourWheel();
                colourwheelInstance.Show();
            }
            else
            {
                colourwheelInstance.Show();
                colourwheelInstance.BringToFront();
            }
        }

        private MassReplace? massreplacelInstance;

        private void button6_Click(object sender, EventArgs e)
        {
            if (massreplacelInstance == null)
            {
                massreplacelInstance = new MassReplace();
                massreplacelInstance.Show();
            }
            else
            {
                massreplacelInstance.Show();
                massreplacelInstance.BringToFront();
            }
        }

        private TextureSeams? TextureSeamslInstance;

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextureSeamslInstance == null)
            {
                TextureSeamslInstance = new TextureSeams();
                TextureSeamslInstance.Show();
            }
            else
            {
                TextureSeamslInstance.Show();
                TextureSeamslInstance.BringToFront();
            }
        }
    }
}
