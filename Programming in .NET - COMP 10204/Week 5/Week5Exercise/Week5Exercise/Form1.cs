using System;
using System.Drawing;
using System.Windows.Forms;

namespace Week5Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            namesListBox.Items.Add("Jerry");
            namesListBox.Items.Add("Bob");
            namesListBox.Items.Add("Todd");
            namesListBox.Items.Add("Goober");
            namesListBox.Items.Add("Burf");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "")
            {
                namesListBox.Items.Add(nameTextBox.Text);
                statusLabel.ForeColor = Color.Green;
                statusLabel.Text = "Name added...OK";
                nameTextBox.Text = "";
            }
            else
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Name field can't be empty";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var selectedItem = namesListBox.SelectedItem;
            if (namesListBox.Items.Count == 0 || selectedItem == null)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "No Items Selected";
            }
            else
            {
                statusLabel.ForeColor = Color.Green;
                statusLabel.Text = "Name deleted...OK";
                namesListBox.Items.Remove(selectedItem);
            }
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = namesListBox.SelectedIndex;
            var selectedItem = namesListBox.SelectedItem;
            if (selectedIndex < namesListBox.Items.Count - 1)
            {
                namesListBox.Items.RemoveAt(selectedIndex);
                namesListBox.Items.Insert(selectedIndex + 1, selectedItem);
                namesListBox.SelectedIndex = selectedIndex + 1;
            }
        }

        private void moveUpButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = namesListBox.SelectedIndex;
            var selectedItem = namesListBox.SelectedItem;
            if (selectedIndex > 0)
            {
                namesListBox.Items.RemoveAt(selectedIndex);
                namesListBox.Items.Insert(selectedIndex - 1, selectedItem);
                namesListBox.SelectedIndex = selectedIndex - 1;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            namesListBox.Items.Clear();
        }
    }
}
