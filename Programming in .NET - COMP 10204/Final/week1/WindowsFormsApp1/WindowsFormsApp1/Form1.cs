using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resultTextBox.ReadOnly = true;  
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            string t1 = firstTextBox.Text;
            string t2 = secondTextBox.Text;
            // Example Using TryParse and populating a textbox:
            if (double.TryParse(t1, out double d1) && double.TryParse(t2, out double d2))
            {
                double result = d2 - d1;
                resultTextBox.Text = $"{result}";
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values.");
            }
        }

        private void flipButton_Click(object sender, EventArgs e)
        {
            string t1 = firstTextBox.Text;
            string t2 = secondTextBox.Text;

            try // Try Catch and showing MessageBox
            {
                double d1 = double.Parse(t1);
                double d2 = double.Parse(t2);
                firstTextBox.Text = $"{d2}";
                secondTextBox.Text = $"{d1}";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Looping through form control:
            foreach (var control in Controls) 
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
