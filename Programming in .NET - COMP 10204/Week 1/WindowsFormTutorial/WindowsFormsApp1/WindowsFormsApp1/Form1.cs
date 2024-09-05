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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            try
            {
                double value1 = Convert.ToDouble(FirstTextBox.Text);
                double value2 = Convert.ToDouble(SecondTextBox.Text);
                double result = value2 - value1;
                ResultTextBox.Text = result.ToString();
            }
            catch (Exception ex) 
            { 
                ResultTextBox.Text = "Bad!";
            }
        }
    }
}
