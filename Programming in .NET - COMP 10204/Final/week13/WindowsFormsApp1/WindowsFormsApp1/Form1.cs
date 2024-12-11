using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection Connection; // globally declare this inside a class, but don't instantiate yet.
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=toms_plumbing;Integrated Security=True;";

        List<Employee> employees = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
            employeeListBox.Items.Add($"{"emp_id",-15} {"first_name",-15} {"last_name",-15} {"department",-15} {"gender",-15} {"salary",-15} {"prov",-15}");
            try
            {
                // INSIDE public Form1() AND wrap inside Try Catch
                Connection = new SqlConnection(); // instantiate connection here
                Connection.ConnectionString = connectionString; // do this
                Connection.Open(); // open connection

                SqlCommand command = new SqlCommand("SELECT * FROM employees", Connection);  // simple query everything
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read()) // access columns with [] and create objects, add to listbox
                    {
                        int ID = int.Parse(reader["employee_id"].ToString());
                        string firstName = reader["first_name"].ToString();
                        string lastName = reader["last_name"].ToString() ;
                        int departmentID = int.Parse(reader["department_id"].ToString());
                        string gender = reader["gender"].ToString ();
                        double salary = double.Parse(reader["salary"].ToString());
                        string prov = reader["province"].ToString();
                        Employee emp = new Employee(ID,firstName,lastName,departmentID,gender,salary,prov);
                        employees.Add(emp);
                        employeeListBox.Items.Add(emp);
                    }
                }

                statusLabel.ForeColor = Color.Green;
                statusLabel.Text += " Success";


            }
            catch (Exception ex) 
            { 
                statusLabel.ForeColor = Color.Red;       
                statusLabel.Text += " Error Connecting to Database"; 
            }
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                string fn = textBox1.Text;
                string ln = textBox2.Text;
                int depID = int.Parse(textBox3.Text);
                string gender = textBox4.Text;
                double salary = double.Parse(textBox5.Text);
                string prov = textBox6.Text;

                // how to execute a command - INSERT
                string query = "INSERT INTO employees (first_name, last_name, department_id, gender, salary, province) VALUES (@fn, @ln, @depID, @gender, @salary, @prov)";
                using (SqlCommand command = new SqlCommand(query, Connection))
                {
                    command.Parameters.AddWithValue("@fn", fn);
                    command.Parameters.AddWithValue("@ln", ln);
                    command.Parameters.AddWithValue("@depID", depID);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@salary", salary);
                    command.Parameters.AddWithValue("@prov", prov);
                    command.ExecuteNonQuery();
                }


                ShowEmployees();
                statusLabel.ForeColor = Color.Green;
                statusLabel.Text = "Status: Inserted Employee";

            }
            catch (Exception ex)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Status: Error Inserting Employee " + ex.Message;
            }
        }

        private void ShowEmployees()
        {
            employeeListBox.Items.Clear();
            employees.Clear();
            employeeListBox.Items.Add($"{"emp_id",-15} {"first_name",-15} {"last_name",-15} {"department",-15} {"gender",-15} {"salary",-15} {"prov",-15}");
            try
            {
                Connection = new SqlConnection(); // instantiate connection here
                Connection.ConnectionString = connectionString; // do this
                Connection.Open(); // open connection

                SqlCommand command = new SqlCommand("SELECT * FROM employees", Connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int ID = int.Parse(reader["employee_id"].ToString());
                        string firstName = reader["first_name"].ToString();
                        string lastName = reader["last_name"].ToString();
                        int departmentID = int.Parse(reader["department_id"].ToString());
                        string gender = reader["gender"].ToString();
                        double salary = double.Parse(reader["salary"].ToString());
                        string prov = reader["province"].ToString();
                        Employee emp = new Employee(ID, firstName, lastName, departmentID, gender, salary, prov);
                        employees.Add(emp);
                        employeeListBox.Items.Add(emp);
                    }
                }

                statusLabel.ForeColor = Color.Green;
                statusLabel.Text += " Success";


            }
            catch (Exception ex)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text += " Error Connecting to Database";
            }
        }

        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            int index = employeeListBox.SelectedIndex;
            int ID = int.Parse(employeeListBox.Items[index].ToString().Split('|')[0]);

            // how to execute a command - DELETE
            string query = $"DELETE FROM employees WHERE employee_id = {ID}";
            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.ExecuteNonQuery();
            }
        }

        private void sortLastNameButton_Click(object sender, EventArgs e)
        {
            // this example uses LINQ and orderby emp.LastName for the employees list. 
            var results = // results is a collection that we can look over based off of what we get       
                from emp in employees
                orderby emp.LastName
                select emp;

            employeeListBox.Items.Clear();
            employeeListBox.Items.Add($"{"emp_id",-15} {"first_name",-15} {"last_name",-15} {"department",-15} {"gender",-15} {"salary",-15} {"prov",-15}");

            foreach (var result in results)
            {
                employeeListBox.Items.Add(result);
            }
        }

        private void sortBySallaryButton_Click(object sender, EventArgs e)
        {
            employees.Sort((e1, e2) => e1.Salary.CompareTo(e2.Salary));

            employeeListBox.Items.Clear();
            employeeListBox.Items.Add($"{"emp_id",-15} {"first_name",-15} {"last_name",-15} {"department",-15} {"gender",-15} {"salary",-15} {"prov",-15}");

            foreach (Employee emp in employees)
            {
                employeeListBox.Items.Add(emp);
            }
        }

        private void sortByIdButton_Click(object sender, EventArgs e)
        {
            employeeListBox.Items.Clear();
            employeeListBox.Items.Add($"{"emp_id",-15} {"first_name",-15} {"last_name",-15} {"department",-15} {"gender",-15} {"salary",-15} {"prov",-15}");



            // we can also query the database directly to order by something
            string query = "SELECT * FROM employees ORDER BY employee_id DESC";
            SqlCommand command = new SqlCommand(query, Connection);
            // NOTE: we only use SqlDataReader when we are trying to get results back from the database. 
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int ID = int.Parse(reader["employee_id"].ToString());
                    string firstName = reader["first_name"].ToString();
                    string lastName = reader["last_name"].ToString();
                    int departmentID = int.Parse(reader["department_id"].ToString());
                    string gender = reader["gender"].ToString();
                    double salary = double.Parse(reader["salary"].ToString());
                    string prov = reader["province"].ToString();
                    employeeListBox.Items.Add($"{ID,-15}|{firstName,-15}|{lastName,-15}|{departmentID,-15}|{gender,-15}|{salary,-15}|{prov,-15}");
                }
            }
        }
    }
}
