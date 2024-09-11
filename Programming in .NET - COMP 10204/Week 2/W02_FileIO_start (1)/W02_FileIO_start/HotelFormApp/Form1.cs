using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelFormApp
{
    public partial class Form1 : Form
    {
        List<Guest> guests = new List<Guest>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddGuestButton_Click(object sender, EventArgs e)
        {
            string fName = FirstNameTextBox.Text;
            string lName = LastNameTextBox.Text;
            DateTime checkIn = CheckInDateTimePicker.Value;
            DateTime checkOut = CheckOutDateTimePicker.Value;

            try
            {
                Guest g = new Guest(fName, lName, checkIn, checkOut);
                guests.Add(g);
                GuestListBox.Items.Add(g.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex.Message);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            const string GuestListFile = "Guests.txt";
            try
            {
                StreamWriter writer = new StreamWriter(GuestListFile);
                foreach (Guest g in guests)
                {
                    writer.WriteLine(g.GetFirstName() + " " + g.GetLastName());
                }
                writer.Close();
                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
