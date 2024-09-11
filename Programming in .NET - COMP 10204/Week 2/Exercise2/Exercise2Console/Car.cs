using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2Console
{
    public class Car
    {
        private string make;
        private string model;
        private double fuel;
        private double mileage;

        public Car(string make, string model, double fuel,double mileage)
        { 
            this.make = make;
            this.model = model; 
            this.fuel = fuel;
            this.mileage = mileage;
        }

        public string getMake() { return make; }
        public string getModel() { return model; }

        public double CalculateFuelEfficiency()
        {
            double fuelEfficiency = Math.Round((fuel / mileage) * 100,2); 
            return fuelEfficiency;
        }

        public override string ToString()
        {
            return $"{make},{model},{fuel},{mileage},{this.CalculateFuelEfficiency():F2}";
        }

    }
}
