using System;

namespace Week5InClassExercise
{
    internal class HourlyEmployee : Employee
    {
        private decimal wage;
        private int hours;

        public HourlyEmployee(string firstName, string lastName, int id, decimal wage, int hours) : base(firstName, lastName, id)
        {
            Wage = wage;
            Hours = hours;
        }

        public int Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if (value > 40)
                {
                    throw new ArgumentException("No overtime.");
                }
                hours = value;
            }
        }

        public decimal Wage { get; set; }

        public override decimal Earnings()
        {
            return Hours * Wage;
        }

        public override string GetEmployeeType()
        {
            return "TYPE: Hourly";
        }

        public override string ToString()
        {
            return base.ToString() + $"Hourly: {Earnings()}";
        }
    }
}