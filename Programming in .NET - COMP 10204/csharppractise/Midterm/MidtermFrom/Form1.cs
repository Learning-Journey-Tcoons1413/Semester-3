using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermFrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            double average = 0;
            if (subjectTextBox.Text.Equals("") || gradeTextBox.Text.Equals("") || (!double.TryParse(gradeTextBox.Text, out double fail)))
            {
                MessageBox.Show("Error");
                return;
            }
            subjectListBox.Items.Add(subjectTextBox.Text);
            gradeListBox.Items.Add(gradeTextBox.Text);
            gradeTextBox.Clear();   
            subjectTextBox.Clear();

            for (int i = 0; i < gradeListBox.Items.Count; i++)
            {
                average += double.Parse(gradeListBox.Items[i].ToString());
            }
            average = average / gradeListBox.Items.Count;

            averageTextBox.Text = average.ToString();
        }
    }
}
