using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomExercise
{
    internal class Person
    {
        public string FirstName {  get;  }
        public string LastName { get; }

        private int age;
        public int Age {
            get 
            {
                return age;
            }
            private set 
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Age can not be zero!");
                }
            }
        }
        public Person( string firstName, string lastName, int age ) 
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Age}";
        }
    }
}
