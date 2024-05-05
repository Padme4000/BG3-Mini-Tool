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

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "LSX files (*.lsx)|*.lsx|All files (*.*)|*.*";
            openFileDialog.Title = "Select the CharacterCreationSharedVisuals.lsx file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string inputFile = openFileDialog.FileName;
                string outputFile = "Exported Visuals for Races.lsx.txt";

                // Read the contents of the input file
                string[] lines = File.ReadAllLines(inputFile);

                // Perform the conversion and filter
                List<string> convertedLines = new List<string>();
                bool insideNode = false;
                int indentationLevel = 0;
                foreach (string line in lines)
                {
                    if (line.Contains("<attribute id=\"UUID\" type=\"guid\" value="))
                    {
                        // Start of node
                        convertedLines.Add(line.Substring(0, line.IndexOf("<")) + "<node id=\"Visuals\">");
                        convertedLines.Add("\t" + line.Replace("<attribute id=\"UUID\" type=\"guid\" value=", "<attribute id=\"Object\" type=\"guid\" value="));
                        insideNode = true;
                        indentationLevel = GetIndentationLevel(line);
                    }
                    else if (insideNode)
                    {
                        // End of node
                        convertedLines.Add(line.Substring(0, line.IndexOf("<")) + "</node>");
                        insideNode = false;
                    }
                }

                // Write the filtered content to the output file
                File.WriteAllLines(outputFile, convertedLines);

                MessageBox.Show("Conversion complete.");
            }
        }

        private int GetIndentationLevel(string line)
        {
            return (line.Length - line.TrimStart().Length) / 4;
        }
    }
}
