using BG3_Mod_Templates;
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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private Form3? form3Instance;
        private void Button16_Click(object sender, EventArgs e)
        {
            if (form3Instance == null)
            {
                form3Instance = new Form3();
                form3Instance.Show();
            }
            else
            {
                form3Instance.Show();
                form3Instance.BringToFront();
            }
        }

        private Form11? Form11Instance;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (Form11Instance == null)
            {
                Form11Instance = new Form11();
                Form11Instance.Show();
            }
            else
            {
                Form11Instance.Show();
                Form11Instance.BringToFront();
            }
        }

        private Tools? form4Instance;
        private void Button4_Click(object sender, EventArgs e)
        {
            if (form4Instance == null)
            {
                form4Instance = new Tools();
                form4Instance.Show();
            }
            else
            {
                form4Instance.Show();
                form4Instance.BringToFront();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private Form7? Form7Instance;

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form7Instance == null)
            {
                Form7Instance = new Form7();
                Form7Instance.Show();
            }
            else
            {
                Form7Instance.Show();
                Form7Instance.BringToFront();
            }
        }
    }
}
