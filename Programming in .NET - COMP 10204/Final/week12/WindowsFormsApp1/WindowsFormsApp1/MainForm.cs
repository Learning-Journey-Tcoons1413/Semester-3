using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public SqlConnection Connection { get; }

        String connectionString = @"Data Source=.\SQLEXPRESS;Initial " + "Catalog=COMP10204ExerciseWeek12;Integrated Security=True";
        public MainForm()
        {
            InitializeComponent();
            try
            {
                Connection = new SqlConnection();
                Connection.ConnectionString = connectionString;
                Connection.Open();
                label1.Text = "Connected to Database Successfully";
            }
            catch (Exception ex)
            {
                label1.Text = "Database Connection failed - check Connection String : " +
                ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            {
                listBox1.Items.Clear();
                try
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Cars", Connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            string output = $"{reader["id"].ToString(),-10} | {reader["make"].ToString(),-10} | {reader["model"].ToString(),-10} | {reader["modelyear"].ToString(),-10}";
                            listBox1.Items.Add(output);
                        }
                    label1.Text = "Database Select Success";
                }
                catch (Exception ex)
                {
                    label1.Text = "Database operation failed: " + ex.Message;
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            string selectedItem = listBox1.Items[index].ToString();
            string[] itemParts = selectedItem.Split('|');

            int id = int.Parse(itemParts[0].Trim());
            string make = itemParts[1].Trim();

            textBox1.Text = $"ID={id}   MAKE={make}";

            string startkm = "";
            string endkm = "";
            string gasused = "";
            double mileage = 0;

            try
            {

                SqlCommand command = new SqlCommand($"SELECT * FROM mileage WHERE car_id = {id}", Connection);
                using (SqlDataReader reader = command.ExecuteReader())
                    if (reader.Read()) // Check if we get any rows back
                    {
                        startkm = reader["startkm"].ToString();
                        endkm = reader["endkm"].ToString();
                        gasused = reader["gasused"].ToString();
                    }

                mileage = double.Parse(gasused) / (double.Parse(endkm) - double.Parse(startkm)) * 100;

                textBox2.Text = $"{mileage.ToString("F2")}";


            }
            catch (Exception ex)
            {
                label1.Text = "Database operation failed: " + ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCarForm form = new AddCarForm(this); // Pass Reference to this class for other info
            form.ShowDialog(this);
            // Update the form with any changes to the DB
            button1_Click(this, null);
        }
    }

}
