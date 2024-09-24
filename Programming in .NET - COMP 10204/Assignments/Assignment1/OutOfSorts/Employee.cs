using System;

//Author: Thomas Coons
//Student ID: 000317961
//Date Completed: Sept 24th 2024
//Purpose: Employee Class

//I, Thomas Coons, 000317961 certify that this material is my original work.
//No other person's work has been used without due acknowledgement.
namespace OutOfSorts
{
    /// <summary>
    /// Employee class of the program. 
    /// </summary>
    internal class Employee
    {
        private string name;
        private int number;
        private decimal rate;
        private double hours;

        /// <summary>
        /// Employee constructor.
        /// </summary>
        /// <param name="name">Name of employee</param>
        /// <param name="number">Number of employee</param>
        /// <param name="rate">Rate of employee</param>
        /// <param name="hours">Hours of employee</param>
        public Employee(string name, int number, decimal rate, double hours)
        {
            this.name = name;
            this.number = number;
            this.rate = rate;
            this.hours = hours;
        }

        /// <summary>
        /// Get employee hours
        /// </summary>
        /// <returns>Hours</returns>
        public double GetHours()
        { return hours; }

        /// <summary>
        /// Set employee hours
        /// </summary>
        /// <param name="hours"></param>
        public void SetHour(double hours)
        { this.hours = hours; }

        /// <summary>
        /// Get employee name
        /// </summary>
        /// <returns>Name</returns>
        public string GetName()
        { return name; }

        /// <summary>
        /// Set employee name
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name)
        { this.name = name; }

        /// <summary>
        /// Get employee number
        /// </summary>
        /// <returns>Number</returns>
        public int GetNumber()
        { return number; }

        /// <summary>
        /// Set employee number
        /// </summary>
        /// <param name="number"></param>
        public void SetNumber(int number)
        { this.number = number; }

        /// <summary>
        /// Get employee rate
        /// </summary>
        /// <returns>Rate</returns>
        public decimal GetRate()
        { return rate; }

        /// <summary>
        /// Set employee rate
        /// </summary>
        /// <param name="rate"></param>
        public void SetRate(decimal rate)
        { this.rate = rate; }

        /// <summary>
        /// Calculates gross pay of employee.
        /// </summary>
        /// <returns>Gross Pay</returns>
        public decimal GetGross()
        {
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

        /// <summary>
        /// ToString of employee object
        /// </summary>
        /// <returns>ToString</returns>
        public override string ToString()
        {
            return $"{name, -20} {number,-10} ${rate,-10}{hours,-10} ${Math.Round(this.GetGross(), 2),-10}";
        }
    }
}
