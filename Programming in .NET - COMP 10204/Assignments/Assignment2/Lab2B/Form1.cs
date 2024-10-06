using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2B
{
    
    public partial class Form1 : Form
    {
        EmployeeServices empServices = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            string numOfClientsString = numOfClientVisitsTextBox.Text;
            int numOfClientsInt;
            try
            {
                numOfClientsInt = int.Parse(numOfClientsString);
                if (numOfClientsInt < 1)
                    MessageBox.Show("Number of clients cannot be less than 1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                List<ServiceType> serviceTypes = new List<ServiceType>();
                if (cutCheckBox.Checked)
                    serviceTypes.Add(ServiceType.Cut);
                if (colourCheckBox.Checked)
                    serviceTypes.Add(ServiceType.Color);
                if (highlightsCheckBox.Checked)
                    serviceTypes.Add(ServiceType.Highlights);
                if (extensionsCheckBox.Checked)
                    serviceTypes.Add(ServiceType.Extension);

                if (!cutCheckBox.Checked && !colourCheckBox.Checked && !highlightsCheckBox.Checked && !extensionsCheckBox.Checked)
                {
                    MessageBox.Show("Select at least one service type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    ClientType discount;
                    if (standardAdultRadioBtn.Checked)
                        discount = ClientType.StandardAdult;
                    else if (childRadioBtn.Checked)
                        discount = ClientType.Child;
                    else if (studentRadioBtn.Checked)
                        discount = ClientType.Student;
                    else
                        discount = ClientType.Senior;


                    if (janeSamleyRadioBtn.Checked)
                    {
                        empServices = new EmployeeServices(EmployeeRate.Jane, serviceTypes, discount, numOfClientsInt);
                    }
                    else if (patJohnsonRadioBtn.Checked)
                    {
                        empServices = new EmployeeServices(EmployeeRate.Pat, serviceTypes, discount, numOfClientsInt);
                    }
                    else if (ronChambersRadioBtn.Checked)
                    {
                        empServices = new EmployeeServices(EmployeeRate.Ron, serviceTypes, discount, numOfClientsInt);
                    }
                    else if (suePallonRadioBtn.Checked)
                    {
                        empServices = new EmployeeServices(EmployeeRate.Sue, serviceTypes, discount, numOfClientsInt);
                    }
                    else { empServices = new EmployeeServices(EmployeeRate.Laurie, serviceTypes, discount, numOfClientsInt); }

                    totalPriceValueLabel.Text = empServices.CalculateTotal().ToString("C");
                }
            }
            catch (Exception ex) { MessageBox.Show("Invalid number of clients provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
 
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            cutCheckBox.Checked = false;
            colourCheckBox.Checked = false; 
            highlightsCheckBox.Checked = false; 
            extensionsCheckBox.Checked = false; 
            standardAdultRadioBtn.Checked = true;
            janeSamleyRadioBtn.Checked = true;
            numOfClientVisitsTextBox.Text = "";
            totalPriceValueLabel.Text = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
