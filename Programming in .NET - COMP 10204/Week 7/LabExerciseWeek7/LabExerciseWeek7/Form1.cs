using System;
using System.Windows.Forms;

namespace LabExerciseWeek7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            string outputText = "";
            for (int i = 0; i < 127; i++)
            {
                outputText = String.Format("{0,-8}{1,8}{2,9:X2}{3,12}\r\n", i, (char)i, i,Convert.ToString(i, 2).PadLeft(8, '0'));
                asciiTextBox.Text += outputText; 
            }
        }
    }
}
