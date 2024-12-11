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

            // Adding items to the ComboBox
            comboBox1.Items.Add("Apple");
            comboBox1.Items.Add("Banana");
            comboBox1.Items.Add("Cherry");

            // Setting a default selected item
            comboBox1.SelectedIndex = 0;  // Sets the first item as selected
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string stuff = comboBox1.SelectedItem.ToString();

            label1.Text = stuff;
        }
    }
}
