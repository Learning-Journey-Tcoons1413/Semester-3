using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercise2Console;

namespace Exercise2WinForm
{
    public partial class Form1 : Form
    {
        private Car[] cars;

        public Form1()
        {
            InitializeComponent();
            cars = new Car[5];

            cars[0] = new Car("Honda", "Civic", 40, 550);
            cars[1] = new Car("Ford", "Mustang", 45, 432);
            cars[2] = new Car("VW", "Golf", 34, 667);
            cars[3] = new Car("Ford", "Focus", 39, 600);
            cars[4] = new Car("Chevrolet", "Cruz", 40, 525);
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            OutputTextbox.Clear();
            for (int i = 0; i < cars.Length; i++)
            {
                OutputTextbox.Text +=  cars[i].ToString() + "\r\n";
            }
            
        }

        private void BestMilesButton_Click(object sender, EventArgs e)
        {
            OutputTextbox.Clear();
            double bestFuel = cars[0].CalculateFuelEfficiency();
            for (int i = 1; i < cars.Length; i++)
            {

                if (cars[i].CalculateFuelEfficiency() < bestFuel)
                {
                    bestFuel = cars[i].CalculateFuelEfficiency();
                }
            }
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].CalculateFuelEfficiency() == bestFuel)
                {
                    OutputTextbox.Text = (cars[i].ToString());
                }
            }
        }


    }
}
