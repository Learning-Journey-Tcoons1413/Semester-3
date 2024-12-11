using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        private decimal monthlySalary; // using backing variables
        public decimal MonthlySalary
        {
            get {return monthlySalary;}
            private set
            {
                if (value >= 0)
                    monthlySalary = value;
            }
        }

        public Employee(string firstName, string lastName, decimal monthlySalary)
        {
            FirstName = firstName;
            LastName = lastName;
            MonthlySalary = monthlySalary;
        }       

        public override string ToString()
        {
            return $"{FirstName,-10} | {LastName,-10} | {MonthlySalary,-10}";
        }
    }
}
