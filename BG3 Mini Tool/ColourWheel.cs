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

namespace BG3_Mini_Tool
{
    public partial class ColourWheel : Form
    {
        public ColourWheel()
        {
            InitializeComponent();
        }

        private void textBoxHex_TextChanged(object sender, EventArgs e)
        {
            string hexColor = textBoxHex.Text.TrimStart('#');

            try
            {
                if (hexColor.Length == 6 || hexColor.Length == 8)
                {
                    byte r = byte.Parse(hexColor.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                    byte g = byte.Parse(hexColor.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                    byte b = byte.Parse(hexColor.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

                    float red = r / 255.0f;
                    float green = g / 255.0f;
                    float blue = b / 255.0f;

                    string srgbColor = $"{red} {green} {blue}";
                    textBoxSRGB.Text = srgbColor;

                    // Update the color of panelColorBox
                    if (hexColor.Length == 8)
                    {
                        byte a = byte.Parse(hexColor.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
                        float alpha = a / 255.0f;
                        srgbColor = $"{red} {green} {blue} {alpha}";
                        panelColorBox.BackColor = Color.FromArgb(a, r, g, b);
                    }
                    else
                    {
                        panelColorBox.BackColor = Color.FromArgb(r, g, b);
                    }
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                // If the user didn't enter '#', prepend it and try again
                if (!textBoxHex.Text.StartsWith("#") && textBoxHex.Text.Length > 0)
                {
                    textBoxHex.Text = "#" + textBoxHex.Text;
                }
                else
                {
                    MessageBox.Show("Hex Value is not in the correct format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Copy the text to the clipboard
            Clipboard.SetText(textBoxHex.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Copy the text to the clipboard
            Clipboard.SetText(textBoxSRGB.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Display a pop-up message box with text
            MessageBox.Show("Press the Colour box to open the Colour Wheel");
        }

        private void ColourWheel_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing event
            this.Hide(); // Hide the form instead of closing it
        }

        private List<Color> customColors = new List<Color>();

        private void panelColorBox_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            // Set custom colors if available
            if (customColors.Count > 0)
            {
                colorDialog.CustomColors = customColors.Select(c => ColorTranslator.ToOle(c)).ToArray();
            }

            // Attempt to parse the color from textBoxDirectHex
            if (TryParseHexColor(textBoxHex.Text, out Color directHexColor))
            {
                colorDialog.Color = directHexColor;
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
        private bool TryParseHexColor(string hexColor, out Color color)
        {
            color = Color.Empty;

            hexColor = hexColor.TrimStart('#');

            try
            {
                if (hexColor.Length == 6 || hexColor.Length == 8)
                {
                    byte r = byte.Parse(hexColor.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
                    byte g = byte.Parse(hexColor.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                    byte b = byte.Parse(hexColor.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

                    if (hexColor.Length == 8)
                    {
                        byte a = byte.Parse(hexColor.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
                        color = Color.FromArgb(a, r, g, b);
                    }
                    else
                    {
                        color = Color.FromArgb(r, g, b);
                    }

                    return true;
                }

                return false;
            }
            catch (FormatException)
            {
                return false;
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

                // Update textBoxSRGB with entered values and spaces
                textBoxSRGB.Text = $"{red} {green} {blue}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid SRGB format. Please enter valid values in the format '0.123 0.456 0.789'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
