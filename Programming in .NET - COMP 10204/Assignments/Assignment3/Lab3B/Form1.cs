using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3B
{
    public partial class Form1 : Form
    {
        public int clickCount = 0;
        EmployeeServices employeeServices;
        public Form1()
        {
            InitializeComponent();
            List<Employee> employees = new List<Employee>()
            {
                new Employee("Jane", 30),
                new Employee("Pat", 45),
                new Employee("Ron", 40),
                new Employee("Sue", 50),
                new Employee("Laurie", 55),
            };

            List<Service> services = new List<Service>()
            {
                new Service("Cut ", 30),
                new Service("Wash, blow-dry, and style", 20),
                new Service("Colour ", 40),
                new Service("Highlights ", 50),
                new Service("Extension ", 200),
                new Service("Up-do ", 60)
            };

            foreach (Employee e in employees)
            { 
                hairdresserComboBox.Items.Add(e);
            }

            foreach (Service s in services)
            { 
                selectServiceListBox.Items.Add(s);  
            }
            

            hairdresserComboBox.SelectedIndex = 0;
            addButton.Enabled = false;
            calculateButton.Enabled = false;
            priceListBox.RightToLeft = RightToLeft.Yes;

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            calculateButton.Enabled = true;    
            hairdresserComboBox.Enabled = false;

            clickCount++;

            if (clickCount > 1)
            { 
                chargedItemsListBox.Items.Add(selectServiceListBox.SelectedItem);
                int service = employeeServices.AddService((Service)selectServiceListBox.SelectedItem);
                priceListBox.Items.Add(service);
            }
            else
            {
                employeeServices = new EmployeeServices((Employee)hairdresserComboBox.SelectedItem, (Service)selectServiceListBox.SelectedItem);
                chargedItemsListBox.Items.Add(hairdresserComboBox.SelectedItem);
                chargedItemsListBox.Items.Add(selectServiceListBox.SelectedItem);
                priceListBox.Items.Add(employeeServices.Employee.Rate);
                priceListBox.Items.Add(employeeServices.Type.Price);
            }


        }
        private void selectServiceListBox_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;   
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            totalPriceTextBox.Text = $"{employeeServices.CalculateTotal().ToString("C")}";
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            hairdresserComboBox.SelectedIndex = 0;
            hairdresserComboBox.Enabled = true;
            chargedItemsListBox.Items.Clear();
            priceListBox.Items.Clear();
            totalPriceTextBox.Text = "";
            employeeServices = null;
            clickCount = 0;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
