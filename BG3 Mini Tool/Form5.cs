using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BG3_Mini_Tool
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            FolderLocalization.Enabled = false;
            FolderEnglish.Enabled = false;

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
                if (control is System.Windows.Forms.ComboBox)
                {
                    control.Enabled = true;
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSelectFolder_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = dialog.SelectedPath;

                    string LocalizationPath = Path.Combine(selectedPath, "Localization");
                    if (Directory.Exists(LocalizationPath))
                    {
                        string parentFolder = Directory.GetParent(LocalizationPath).FullName;
                        FolderModName.Text = Path.GetFileName(parentFolder);

                        string[] subfolders = Directory.GetDirectories(LocalizationPath);
                        if (subfolders.Length > 0)
                        {
                            string EnglishFolderPath = Path.Combine(LocalizationPath, "English");
                            if (!Directory.Exists(EnglishFolderPath))
                            {
                                MessageBox.Show("The selected folder does not contain a 'English' subfolder.", "Missing Subfolder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("The selected folder does not contain a subfolder in 'Localization'.", "Missing Subfolder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The selected folder does not contain a 'Localization' subfolder.", "Missing Subfolder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string LocalizationPath = Path.Combine(modsFolderPath, folderModName, "Localization");
            string EnglishFolderPath = Path.Combine(LocalizationPath, "English");

            // Check if the folders already exist, and create them if they don't
            if (!Directory.Exists(folderModName))
            {
                Directory.CreateDirectory(folderModName);
            }

            if (!Directory.Exists(LocalizationPath))
            {
                Directory.CreateDirectory(LocalizationPath);
            }

            if (!Directory.Exists(EnglishFolderPath))
            {
                Directory.CreateDirectory(EnglishFolderPath);
            }

            MessageBox.Show("Folders created successfully!");

        }
    }
}
