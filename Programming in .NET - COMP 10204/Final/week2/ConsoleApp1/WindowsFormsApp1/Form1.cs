using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Car[] cars;
        public Form1()
        {
            InitializeComponent();
            cars = new Car[5];

            Car car1 = new Car("Toyota", "Camry", 50, 15);
            Car car2 = new Car("Honda", "Civic", 40, 12);
            Car car3 = new Car("Ford", "Focus", 55, 18);
            Car car4 = new Car("Ford", "Malibu", 60, 14);
            Car car5 = new Car("Nissan", "Altima", 45, 16);

            cars[0] = car1;
            cars[1] = car2;
            cars[2] = car3;
            cars[3] = car4;
            cars[4] = car5;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (Car car in cars)
            {
                textBox1.Text += car + "\r\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();   
            double best = 0;
            best = cars[0].calculateFuelEfficiency();
            Car bestCar = null;
            foreach (Car c in cars)
            {
                if (c.calculateFuelEfficiency() < best)
                    best = c.calculateFuelEfficiency();
                bestCar = c;
            }
            textBox1.Text = $"{bestCar}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (Car c in cars)
            {
                if (c.Make == "Ford")
                    textBox1.Text += c + "\r\n";
                
            }
        }
    }
}
