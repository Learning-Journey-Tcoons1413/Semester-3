using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author: Thomas Coons
//Student ID: 000317961
//Date: Sept 15th 2024
//Purpose: Employee Sorting Application

//I, Thomas Coons, 000317961 certify that this material is my original work.
//No other person's work has been used without due acknowledgement.
namespace OutOfSorts
{
    internal class Employee
    {
        private string name;
        private int number;
        private decimal rate;
        private double hours;

        public Employee(string name, int number, decimal rate, double hours)
        {
            this.name = name;
            this.number = number;
            this.rate = rate;
            this.hours = hours;
        }

        public double GetHours()
        { return hours; }

        public void SetHour(double hours)
        { this.hours = hours; }

        public string GetName()
        { return name; }

        public void SetName(string name)
        { this.name = name; }

        public int GetNumber()
        { return number; }

        public void SetNumber(int number)
        { this.number = number; }

        public decimal GetRate()
        { return rate; }

        public void SetRate(decimal rate)
        { this.rate = rate; }

        public override string ToString()
        {
            return $"{name, -20} {number,-10} {rate,-10} {hours,-10}";
        }
    }
}
