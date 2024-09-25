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
        private string _firstName;   
        private string _lastName;

        public string FirstName 
        {
            get { return _firstName; }
            set
            {
                if (value == "GAY")
                    throw new ArgumentException("Cant be gay!");
                _firstName = value;
            }
        }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }       
    }
}
