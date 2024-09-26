using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETProperties
{
    public enum Gender
    { 
        MALE, FEMALE
    }
    internal class Person
    {
        private string firstName;
        public string FirstName 
        {
            get { return firstName; }
            set
            {
                firstName = value;  
            }
        }  
        public string LastName { get; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
