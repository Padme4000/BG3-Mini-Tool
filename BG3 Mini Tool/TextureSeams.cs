using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using static BG3_Mini_Tool.TextureSeams;

namespace BG3_Mini_Tool
{
    public partial class TextureSeams : Form
    {

        public TextureSeams()
        {
            InitializeComponent();
        }

        private void buttonCLEA_Click(object sender, EventArgs e)
        {
            if (ProcessTextures("CLEA"))
            {
                // Processing completed successfully
            }
            else
            {
                // Processing canceled
            }
        }

        private void buttonHMVY_Click(object sender, EventArgs e)
        {
            if (ProcessTextures("HMVY"))
            {
                // Processing completed successfully
            }
            else
            {
                // Processing canceled
            }
        }

        private void buttonNM_Click(object sender, EventArgs e)
        {
            if (ProcessTextures("NM"))
            {
                // Processing completed successfully
            }
            else
            {
                // Processing canceled
            }
        }

        private void buttonMSK_Click(object sender, EventArgs e)
        {
            if (ProcessTextures("MSK"))
            {
                // Processing completed successfully
            }
            else
            {
                // Processing canceled
            }
        }

        private bool ProcessTextures(string textureType)
        {
            // Get the directory of the executable
            string scriptDir = AppDomain.CurrentDomain.BaseDirectory;

            // Ask the user to select the textures and the mask
            string textureAPath = GetFilePath($"Select your main texture, the one you want to have the seam fixed on. ({textureType} texture)", scriptDir);
            if (textureAPath == null) return false;

            string textureBPath = GetFilePath($"Select the texture you want to use to fix your seam. ({textureType} texture)", scriptDir);
            if (textureBPath == null) return false;

            string maskPath = GetFilePath($"Select the Mask texture used to transfer the seam from the second image to your main image. This texture should be black and white. ({textureType} texture)", scriptDir);
            if (maskPath == null) return false;

            // Load the textures and the mask
            Bitmap textureA = new Bitmap(textureAPath);
            Bitmap textureB = new Bitmap(textureBPath);
            Bitmap mask = new Bitmap(maskPath);

            // Ensure all images have the same dimensions
            int width = Math.Min(Math.Min(textureA.Width, textureB.Width), mask.Width);
            int height = Math.Min(Math.Min(textureA.Height, textureB.Height), mask.Height);
            Rectangle rect = new Rectangle(0, 0, width, height);

            // Create a new bitmap for the result
            Bitmap result = new Bitmap(width, height);

            // Apply the mask to textureA
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color maskColor = mask.GetPixel(x, y);
                    Color textureAColor = textureA.GetPixel(x, y);
                    Color textureBColor = textureB.GetPixel(x, y);

                    // Calculate the blending factor based on the intensity of the mask color
                    float blendFactor = maskColor.R / 255f; // Assuming R channel represents intensity

                    // Interpolate between textureAColor and textureBColor manually for each channel including alpha
                    int a = (int)(textureAColor.A * (1 - blendFactor) + textureBColor.A * blendFactor);
                    int r = (int)(textureAColor.R * (1 - blendFactor) + textureBColor.R * blendFactor);
                    int g = (int)(textureAColor.G * (1 - blendFactor) + textureBColor.G * blendFactor);
                    int b = (int)(textureAColor.B * (1 - blendFactor) + textureBColor.B * blendFactor);

                    // Ensure that the RGB values are within the valid range [0, 255]
                    a = Math.Max(0, Math.Min(255, a));
                    r = Math.Max(0, Math.Min(255, r));
                    g = Math.Max(0, Math.Min(255, g));
                    b = Math.Max(0, Math.Min(255, b));

                    // Create the final color
                    Color finalColor = Color.FromArgb(a, r, g, b);

                    result.SetPixel(x, y, finalColor);
                }
            }

            // Ask the user to select the output file path
            string outputPath = GetSaveFilePath("Save Combined Image As", "combined_image.png", scriptDir);
            if (outputPath == null) return false;

            // Save the result
            result.Save(outputPath);

            return true;
        }

        private string GetFilePath(string title, string initialDir)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = title,
                InitialDirectory = initialDir,
                Filter = "Image files (*.png;*.jpg;*.jpeg;)|*.png;*.jpg;*.jpeg;|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            else
            {
                return null;
            }
        }

        private string GetSaveFilePath(string title, string defaultFileName, string initialDir)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = title,
                InitialDirectory = initialDir,
                FileName = defaultFileName,
                Filter = "PNG files (*.png)|*.png|JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }
            else
            {
                return null;
            }
        }


        private void lazy_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // Get the URL from the link label
            string url = "https://www.github.com/PerplexedPeach/bg3-lewd-mods/blob/master/merge_tga.py";

            // Display a message box asking the user if they want to go to the link
            DialogResult result = MessageBox.Show("Do you want to open this link? It leads to LazyIcacrus's Python script for batch converting textures with seams.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks Yes, open the link
            if (result == DialogResult.Yes)

            // Open the URL in the default web browser
            System.Diagnostics.Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
    }
}