using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.Text = "Status: Error - Name must not be empty";
                label1.ForeColor = Color.Red;
                return;
            }
            string name = textBox1.Text;
            listBox1.Items.Add(name);
            textBox1.Clear();
            label1.ForeColor = Color.Green;
            label1.Text = "Status: Successfully Added";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
            label1.ForeColor = Color.Green;
            label1.Text = "Status: Items Cleared";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)   // check if not item is selected
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Status: No Item Selected";
                return;
            }
            int index = listBox1.SelectedIndex; // get item at selected index for listbox
            listBox1.Items.RemoveAt(index);     // remove item at selected index for listbox
            label1.ForeColor = Color.Green;
            label1.Text = "Status: Item Removed";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)   // check if not item is selected
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Status: No Item Selected";
                return;
            }
            int index = listBox1.SelectedIndex; // get item at selected index for listbox
            string item = listBox1.Items[index].ToString(); // get content of listbox item at specific index (string)
            listBox1.Items.RemoveAt(index); // remove item at selected index (int) for listbox
            if ((index - 1) >= 0)
            {
                index--;    
            }
            listBox1.Items.Insert(index, item); // insert into listbox at index pos, then supply content (string)
            listBox1.SelectedIndex = index; // reselect index
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)               // check if no item is selected
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Status: No Item Selected";
                return;
            }
            int index = listBox1.SelectedIndex;             // get item at selected index for listbox
            string item = listBox1.Items[index].ToString(); // get content of listbox item at specific index (string)
            listBox1.Items.RemoveAt(index);                 // remove item at selected index (int) for listbox
            if ((index + 1) <= listBox1.Items.Count)
            {
                index++;
            }
            listBox1.Items.Insert(index, item);             // insert into listbox at index pos, then supply content (string)
            listBox1.SelectedIndex = index;                 // reselect index
        }
    }
}
