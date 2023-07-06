using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BG3_Mod_Templates
{
    public partial class Tools : Form
    {
        public Tools()
        {
            InitializeComponent();
        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing event
            this.Hide(); // Hide the form instead of closing it
        }
        private void panelColorBox_Click(object sender, EventArgs e)
        {
            // Show the ColorDialog to get the user's color selection
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the color of the panelColorBox to the selected color
                panelColorBox.BackColor = colorDialog.Color;

                // Convert the color to hex string
                string hexColor = ColorTranslator.ToHtml(colorDialog.Color);
                textBoxHex.Text = hexColor;

                // Convert the color to sRGB values in the range of 0 to 1.0
                float red = colorDialog.Color.R / 255.0f;
                float green = colorDialog.Color.G / 255.0f;
                float blue = colorDialog.Color.B / 255.0f;
                float alpha = colorDialog.Color.A / 255.0f;
                string srgbColor = $"({red:F6}, {green:F6}, {blue:F6}, {alpha:F6})";
                textBoxSRGB.Text = srgbColor;
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

        private void textBoxVersion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
