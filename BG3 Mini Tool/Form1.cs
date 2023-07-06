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
    }
}
