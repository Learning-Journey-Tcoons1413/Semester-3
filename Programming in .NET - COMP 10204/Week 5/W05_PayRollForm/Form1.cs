using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

/// <summary>
/// Application to simulate A Payroll system in a company with different types of Employees 
/// Uses a model view architecture where the model is represented by a List of Employees
/// 
/// Topics covered:
/// o  Polymorphic behavior in the model
/// o  Model - View 
/// o  Use of customized set/get - see subclasses of Employee
/// o  Persistance of the model to a text file 
/// o  Re-creation of the model from a text file 
/// o  Use of standard File Dialogs for the selection of the text file source
/// 
/// </summary>


namespace PayRollForm
{
    public partial class FormPayrollSystem : Form
    {
        List<Employee> employees;

        public FormPayrollSystem()
        {
            InitializeComponent();

            groupBoxCommission.Enabled = false;
            groupBoxHourly.Enabled = false;
            groupBoxSalary.Enabled = true;

            employees = new List<Employee>();
        }

        private void radioButtonSalary_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCommission.Enabled = false;
            groupBoxHourly.Enabled = false;
            groupBoxSalary.Enabled = true;
        }

        private void radioButtonHourly_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCommission.Enabled = false;
            groupBoxHourly.Enabled = true;
            groupBoxSalary.Enabled = false;

        }

        private void radioButtonCommission_CheckedChanged(object sender, EventArgs e)
        {

            groupBoxCommission.Enabled = true;
            groupBoxHourly.Enabled = false;
            groupBoxSalary.Enabled = false;
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            Employee newEmployee = null;

            try
            {

                if (radioButtonSalary.Checked)
                    newEmployee = new SalariedEmployee(textBoxFirstName.Text, textBoxLastName.Text, textBoxID.Text, decimal.Parse(textBoxSalary.Text));
                else if (radioButtonCommission.Checked)
                    newEmployee = new CommissionEmployee(textBoxFirstName.Text, textBoxLastName.Text, textBoxID.Text, decimal.Parse(textBoxTotalSales.Text), decimal.Parse(textBoxCommisionRate.Text)/100);
                else if (radioButtonHourly.Checked)
                    newEmployee = new HourlyEmployee(textBoxFirstName.Text, textBoxLastName.Text, textBoxID.Text, decimal.Parse(textBoxHourlyRate.Text), decimal.Parse(textBoxHoursWorked.Text));

                employees.Add(newEmployee);
                listBoxEmployee.Items.Add(newEmployee);

                decimal totalSalary = 0;
                foreach (Employee emp in employees)
                    totalSalary += emp.Earnings();

                textBoxTotalPayroll.Text = $"{totalSalary:C}";

            } catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Set up appropriate defaults - Filter can be set in the properties dialog as well
                // but in general I like to do this in code 
                labelError.Text = "";
                saveEmployeeFileDialog.Filter = "csv files(*.csv)|*.csv|All files(*.*)|*.*";
                saveEmployeeFileDialog.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory;

                if (saveEmployeeFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveEmployeeFileDialog.FileName;
                    StreamWriter writer = new StreamWriter(fileName);

                    // Write out all the data using the polymorphic behavior of the employee class
                    foreach (Employee employee in employees)
                    {
                        writer.WriteLine(employee.ToCsv());
                    }
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                labelError.Text = "File Writing failed - Reason: " + ex.Message;
            }

        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            try
            {
                labelError.Text = "";
                openEmployeeFileDialog.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
                openEmployeeFileDialog.Filter = "csv files(*.csv)|*.csv|All files(*.*)|*.*";
                if (openEmployeeFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openEmployeeFileDialog.FileName;
                    StreamReader reader = new StreamReader(fileName);

                    // Create a new empty list of employees
                    employees = new List<Employee>();
                    while (!reader.EndOfStream)
                    {
                        // A little more complicated to build the model 
                        // Need to use the Employee type that was saved in the file to help us rebuild the 
                        // individual classes - Each subclass needs it's own call to the appropriate sub-class 
                        // constructor.
                        string line = reader.ReadLine();
                        string[] fields = line.Split(',');
                        if (fields[0] == "HOURLY")
                            employees.Add(new HourlyEmployee(fields[1], fields[2], fields[3], decimal.Parse(fields[4]), decimal.Parse(fields[5])));
                        else if (fields[0] == "SALARIED")
                            employees.Add(new SalariedEmployee(fields[1], fields[2], fields[3], decimal.Parse(fields[4])));
                        else if (fields[0] == "COMMISSION")
                            employees.Add(new CommissionEmployee(fields[1], fields[2], fields[3], decimal.Parse(fields[4]), decimal.Parse(fields[5])));
                    }
                    reader.Close();

                    // Update the list

                    foreach (Employee employee in employees)
                        listBoxEmployee.Items.Add(employee);

                    decimal totalSalary = 0;
                    foreach (Employee emp in employees)
                        totalSalary += emp.Earnings();

                    textBoxTotalPayroll.Text = $"{totalSalary:C}";
                }
            }

            catch (Exception ex)
            {
                // Typically the things that go wrong during reading could be many 
                // no file found, bad data in the file (does not match expected) - It is a text file 
                // that could have been edited outside the application 
                // Use error label to display the issue.
                labelError.Text = "File Reading failed - Reason: " + ex.Message;
            }

        }
    }
}
