using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AddCarForm;

namespace Week11Exercise
{
    public partial class MainForm : Form
    {
        public SqlConnection Connection { get; }

        string connectionString = @"Data Source=.\SQLEXPRESS;Initial " +
 "Catalog=COMP10204ExerciseWeek12;Integrated Security=True";


        public MainForm()
        {
            InitializeComponent();
            try
            {
                Connection = new SqlConnection();
                Connection.ConnectionString = connectionString;
                Connection.Open();
                statusLabel.Text = "Connected to Database Successfully";
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Database Connection failed - check Connection String : " +
                ex.Message;
            }
        }

        private void listCarsButton_Click(object sender, EventArgs e)
        {
            resultsListBox.Items.Clear();
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM cars", Connection);

                // Create new SqlDataReader object and read data from the command.
                SqlDataReader reader = command.ExecuteReader();
                // while there is another record present
                while (reader.Read())
                {
                    string output = "";
                    // write the data on to the screen
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        output += String.Format("{0,-10} | ", reader[i]);
                    }
                    resultsListBox.Items.Add(output);
                }
                statusLabel.Text = "Database Select Success";
                reader.Close();
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Database operation failed: " + ex.Message;
            }

        }

        private void resultsListBox_MouseCaptureChanged(object sender, EventArgs e)
        {
            string id = resultsListBox.SelectedItem.ToString().Split('|')[0].Trim();
            SqlCommand command = new SqlCommand($"SELECT id,make,model FROM cars WHERE id={id}",Connection);
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                string output = "";
                // write the data on to the screen
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    output += String.Format("{0,-10} | ", reader[i]);
                }

                selectedVehicleTextBox.Text = output.Split('|')[1].Trim() + " " + output.Split('|')[2].Trim();
            }
            reader.Close();

            SqlCommand newcommand = new SqlCommand($"SELECT startkm,endkm,gasused FROM mileage WHERE car_id={id}",Connection);
            SqlDataReader newreader = newcommand.ExecuteReader();
            while (newreader.Read())
            {
                string output = "";
                // write the data on to the screen
                for (int i = 0; i < newreader.FieldCount; i++)
                {
                    output += String.Format("{0,-10} | ", newreader[i]);
                }

                double startkm = double.Parse(output.ToString().Split('|')[0].Trim());
                double endkm = double.Parse(output.ToString().Split('|')[1].Trim());
                double gasused = double.Parse(output.ToString().Split('|')[2].Trim());
                double average = gasused / (endkm - startkm);
                averageMileageTextBox.Text = $"{Math.Round(average, 2)}";
            }
            newreader.Close();
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            AddCarForm form = new AddCarForm(this); // Pass Reference to this class for other info
            form.ShowDialog(this);
            // Update the form with any changes to the DB
            listProductsButton_Click(this, null);

        }
    }
}

// mileage = gasused/(endKm – startKm) * 100