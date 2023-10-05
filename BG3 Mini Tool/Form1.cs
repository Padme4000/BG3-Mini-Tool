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
        private Form3? form3Instance;
        public Form1()
        {
            InitializeComponent();
        }
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
        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
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

        private Form7? Form7Instance;

        private void Button2_Click_1(object sender, EventArgs e)
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

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Set the desired size of the form
            this.Size = new Size(302, 460);
        }

        private Form8? Form8Instance;

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (Form8Instance == null)
            {
                Form8Instance = new Form8();
                Form8Instance.Show();
            }
            else
            {
                Form8Instance.Show();
                Form8Instance.BringToFront();
            }
        }

        private Form10? Form10Instance;

        private void button3_Click_1(object sender, EventArgs e)
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
    }
}
