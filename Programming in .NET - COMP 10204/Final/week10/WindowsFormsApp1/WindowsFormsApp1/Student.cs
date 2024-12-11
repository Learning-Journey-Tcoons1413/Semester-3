using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public double Grade1 { get; private set; }
        public double Grade2 { get; private set; }
        public double Average 
        { 
            get
            {
                return (Grade1 + Grade2) / 2;
            }
        }

        public Student(string firstName, string lastName, double grade1, double grade2)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade1 = grade1;
            Grade2 = grade2;
        }

        public override string ToString()
        {
            return $"{FirstName,-15} {LastName,-15} {Grade1,-15} {Grade2,-15} {Average,-15}";
        }
    }
}
