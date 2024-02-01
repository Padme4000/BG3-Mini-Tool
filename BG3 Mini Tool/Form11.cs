using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BG3_Mini_Tool
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
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

        private Form10? Form10Instance;

        private void button3_Click(object sender, EventArgs e)
        {
            if (Form10Instance == null)
            {
                Form10Instance = new Form10();
                Form10Instance.Show();
            }
            else
            {
                Form10Instance.Show();
                Form10Instance.BringToFront();
            }
        }

        private Form8 Form8Instance;

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form8Instance == null || Form8Instance.IsDisposed)
            {
                Form8Instance = new Form8();
            }

            Form8Instance.Show();
            Form8Instance.BringToFront();
        }

        private void Form11_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing event
            this.Hide(); // Hide the form instead of closing it
        }

        private Form12 Form12Instance;

        private void button4_Click(object sender, EventArgs e)
        {
            if (Form12Instance == null || Form12Instance.IsDisposed)
            {
                Form12Instance = new Form12();
            }

            Form12Instance.Show();
            Form12Instance.BringToFront();

        }
    }
}
