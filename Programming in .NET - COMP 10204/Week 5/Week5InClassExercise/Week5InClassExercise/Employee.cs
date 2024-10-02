using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5InClassExercise
{
    internal abstract class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Id { get; }

        public Employee(string firstName, string lastName, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }
        public abstract string GetEmployeeType();
        public abstract decimal Earnings();
        public override string ToString()
            { return $"First: {FirstName} | Last: {LastName} | ID: {Id}"; }
    }
}
