using System;
using System.Windows.Forms;


namespace Lab4B
{
    public partial class Form1 : Form
    {
        public string file = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "HTML files (*.html, *.htm)|*.html;*.htm";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    file = openFileDialog.FileName;

                    MessageBox.Show("You selected the file: " + file);

                }
            }
        }
    }
}