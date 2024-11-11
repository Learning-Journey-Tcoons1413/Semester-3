using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab4A
{
    internal class Employee
    {
        public string Name {  get; set; }             // The employee name
        public int Number { get; set; }               // The employee ID
        public decimal Rate { get; set; }             // The hourly rate
        public double Hours { get; set; }             // The weekly hours
        public decimal Gross                          // The gross pay
        {
            get
            {
                if (Hours < 40)
                {
                    return (decimal)Hours * Rate;
                }
                else
                {
                    return (40.0m * Rate) + (((decimal)Hours - 40.0m) * Rate * 1.5m);
                }
            }
        }                        

        /// <summary>
        /// Default constructor for Employee - used for creating Employee array
        /// </summary>
        public Employee()
        {
        }

        /// <summary>
        /// Four-argument constructor for Employee
        /// </summary>
        /// <param name="name">Employee name</param>
        /// <param name="number">Employee number</param>
        /// <param name="rate">Hourly rate of pay</param>
        /// <param name="hours">Hours worked in a week</param>
        public Employee(string name, int number, decimal rate, double hours)
        {

            Name = name;
            Number = number;
            Rate = rate;
            Hours = hours;
        }

        /// <summary>
        /// Employee display method - in the future, we'll override the ToString method of Object
        /// </summary>
        public override string ToString() => $"{Name,-20}  {Number:D5}  {Rate,6:C}  {Hours:#0.00}  {Gross,9:C}";

    }
}
