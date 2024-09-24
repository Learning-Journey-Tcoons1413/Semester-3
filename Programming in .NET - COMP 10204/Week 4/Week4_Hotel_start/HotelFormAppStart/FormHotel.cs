using System;
using System.ComponentModel;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

// Notes - Application written by Mark Yendt in September 2018

namespace HotelFormAppStart
{
    public partial class FormHotel : Form
    {
        // Reference to the model 
        List<Guest> guests = new List<Guest>();  // Like ArrayList in Java
        public FormHotel()
        {
            InitializeComponent();

        }

        private void buttonAddGuest_Click(object sender, EventArgs e)
        {
            try { 
            Guest g = new Guest(FirstNameTextBox.Text, LastNameTextBox.Text,
                                CheckInDateTimePicker.Value, CheckOutDateTimePicker.Value,room);
            GuestListBox.Items.Add(g);  // Add to view 
            guests.Add(g);              // Add to model
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error in Input\n " + ex.Message, "Error", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string GuestlistFile = "Guests.txt";
            try
            {
                // File does not have to exist in advance
                StreamWriter writer = new StreamWriter(GuestlistFile);
                foreach (Guest g in guests)
                    writer.WriteLine(g.FirstName + "," + g.LastName + "," +
                                     g.CheckIn + "," + g.CheckOut);
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing file\n" + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
