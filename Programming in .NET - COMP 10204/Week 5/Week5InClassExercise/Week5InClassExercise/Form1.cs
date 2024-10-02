using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Week5InClassExercise
{
    public partial class Form1 : Form
    {
        private List<Employee> employees = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
            salaryRadioButton.Checked = true;
        }

        private void salaryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            salaryGroupBox.Enabled = true;
            commisionGroupBox.Enabled = false;
            hourlyGroupBox.Enabled = false;
        }

        private void hourylRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            salaryGroupBox.Enabled = false;
            commisionGroupBox.Enabled = false;
            hourlyGroupBox.Enabled = true;
        }

        private void commisionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            salaryGroupBox.Enabled = false;
            commisionGroupBox.Enabled = true;
            hourlyGroupBox.Enabled = false;
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = null;
                if (salaryRadioButton.Checked)
                {
                    employee = new SalaryEmployee(firstNameTextBox.Text, lastNameTextBox.Text, int.Parse(idTextBox.Text), decimal.Parse(weeklySalaryTextBox.Text));
                }
                else if (hourylRadioButton.Checked)
                {
                    employee = new HourlyEmployee(firstNameTextBox.Text, lastNameTextBox.Text, int.Parse(idTextBox.Text), decimal.Parse(hourlyRateTextBox.Text), int.Parse(weeklyHoursTextBox.Text));
                }
                employees.Add(employee);
                listBox1.Items.Add(employee);

                foreach (Control control in employeeInfoGroupBox.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        textBox.Clear();
                    }
                }
                foreach (Control control in salaryGroupBox.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        textBox.Clear();
                    }
                }
                foreach (Control control in hourlyGroupBox.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        textBox.Clear();
                    }
                }
                decimal totalSalary = 0;

                foreach (Employee emp in employees)
                {
                    totalSalary += emp.Earnings();
                }
                totalSalaryTextBox.Text = $"{totalSalary}";
            }
            catch (Exception ex) { MessageBox.Show("Fields must be not empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
