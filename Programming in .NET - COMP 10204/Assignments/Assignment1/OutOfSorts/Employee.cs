using System;

//Author: Thomas Coons
//Student ID: 000317961
//Date Completed: Sept 15th 2024
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

        public decimal GetGross()
        {
            //Rate of pay * hours worked and after 40 hours overtime is at time and a half
            if (hours <= 40)
            {
                decimal gross = (decimal)hours * rate;
                return gross;
            }
            else 
            {
                decimal overtimePay = (decimal)((hours - 40) * ((double)rate * 1.5));
                decimal regularPay = (decimal)(40 * rate);
                return overtimePay + regularPay;
            }
        }
        public override string ToString()
        {
            return $"{name, -20} {number,-10} ${rate,-10} {hours,-10} ${Math.Round(this.GetGross(), 2),-10}";
        }
    }
}
