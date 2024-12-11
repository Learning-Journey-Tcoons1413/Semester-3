using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car
    {
        public string Make { get; private set; } // public get, private set
        public string Model { private get; set; } // private get, public set
        private double Fuel {  get;  set; } // private get, private set
        public double Mileage { get; set; } // public get, public set

        public Car(string make, string model, double fuel, double mileage)
        {
            Make = make;
            Model = model;
            Fuel = fuel;
            Mileage = mileage;
        }       
        public double calculateFuelEfficiency()
        {
            return Fuel / (Mileage * 100);  
        }
        public override string ToString()
        {
            return $"{Make,-10} | {Model,-10} | {Fuel,-10} | {Mileage,-10} | {this.calculateFuelEfficiency(),-10}"; 
        }
    }
}
