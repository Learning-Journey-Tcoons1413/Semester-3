using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6Exercise
{
    public partial class Form1 : Form
    {
        List<AstronautTrip> astronautTrips = new List<AstronautTrip>();
        public Form1()
        {
            InitializeComponent();
        }

        private void bookTripButton_Click(object sender, EventArgs e)
        {
            if (tripListBox.Items.Count == 3)
                return;
            
            DateTime year = monthCalendar1.SelectionStart;
            DateTime month = monthCalendar1.SelectionStart;
            DateTime depart = monthCalendar1.SelectionStart;
            if (!depart.DayOfWeek.Equals(DayOfWeek.Saturday) || depart.Day > 7)
            {
                MessageBox.Show("Departure date must only be on the first Saturday of every month.");
                monthCalendar1.SetDate(GetFirstSaturday(year.Year, month.Month));
                return;
            }
            else 
            { 
                depart = monthCalendar1.SelectionStart;
                AstronautTrip ast = new AstronautTrip(astronautNameTextBox.Text, depart);
                
                foreach (AstronautTrip astro in astronautTrips)
                {
                    if (ast.Name.Equals(astro.Name))
                    {
                        MessageBox.Show("Astronaut already in the list");
                        return;
                    }
                   
                }
                astronautTrips.Add(ast);
                tripListBox.Items.Add(ast);
            }
        }
        private DateTime GetFirstSaturday(int year, int month)
        {
            DateTime firstOfMonth = new DateTime(year, month, 1);
            while (firstOfMonth.DayOfWeek != DayOfWeek.Saturday)
            {
                firstOfMonth = firstOfMonth.AddDays(1);
            }
            return firstOfMonth;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (tripListBox.Items.Count == 3)
                return;
            DateTime year = monthCalendar1.SelectionStart;
            DateTime month = monthCalendar1.SelectionStart;
            DateTime depart = monthCalendar1.SelectionStart;
            if (!depart.DayOfWeek.Equals(DayOfWeek.Saturday) || depart.Day > 7)
            { 
                MessageBox.Show("Departure date must only be on the first Saturday of every month.");
                monthCalendar1.SetDate(GetFirstSaturday(year.Year, month.Month));
            }
        }
    }
}
