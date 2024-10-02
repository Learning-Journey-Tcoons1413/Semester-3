using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5InClassExercise
{
    internal class SalaryEmployee : Employee
    {
        private decimal weeklySalary;

        public SalaryEmployee(string firstName, string lastName, int id, decimal salary) : base(firstName,lastName,id)
        {
            WeeklySalary = salary;
        }

        public decimal WeeklySalary
        {
            get
            { 
                return weeklySalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salery cannot be less than zero.");
                }
                weeklySalary = value;
            }
        }

        public override decimal Earnings()
        {
            return WeeklySalary;
        }

        public override string GetEmployeeType()
        {
            return "TYPE: Salary";
        }

        public override string ToString()
        {
            return base.ToString() + $" | Salary: {WeeklySalary}";
        }
    }
}
