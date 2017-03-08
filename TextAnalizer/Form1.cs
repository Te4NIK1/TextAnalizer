using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAnalizer
{
    public partial class Form1 : Form
    {
        //variables
        public List<string> dictionary;
        public List<string> text;

        //functions
        public static void analize()
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "Text files|*.txt";
            openFileDialog2.Title = "Select a Text File";

            // Show the Dialog.
            // If the user clicked OK in the dialog and file was selected
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                label1.Text = openFileDialog2.FileName;
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog2.FileName);

                string line = null;
                while( (line= sr.ReadLine()) != null)
                {
                    string[] lol = line.Split(' ');
                    //for (int i = 0; i < lol.Count(); i++)
                    //    text.Add(lol[i]);

                    MessageBox.Show(lol[lol.Count()-1]);
                }
                sr.Close();
            }
        }
    }
}
