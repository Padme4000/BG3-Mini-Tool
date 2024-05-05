using BG3_Mini_Tool;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

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

        private void Form6_Load(object sender, EventArgs e)
        {
        }

        private Form2? Form2Instance;

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Form2Instance == null)
            {
                Form2Instance = new Form2();
                Form2Instance.Show();
            }
            else
            {
                Form2Instance.Show();
                Form2Instance.BringToFront();
            }
        }

        private Form9? form9Instance;

        private void Button3_Click(object sender, EventArgs e)
        {
            if (form9Instance == null)
            {
                form9Instance = new Form9();
                form9Instance.Show();
            }
            else
            {
                form9Instance.Show();
                form9Instance.BringToFront();
            }
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing event
            this.Hide(); // Hide the form instead of closing it
        }

        private void Form6_Resize(object sender, EventArgs e)
        {
            // Set the desired size of the form
            this.Size = new Size(730, 620);
        }
    }
}
