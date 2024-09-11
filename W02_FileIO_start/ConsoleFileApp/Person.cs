using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFileApp
{
    /// <summary>
    /// Person class is used as a starting class to model people in an application 
    /// </summary>
    public class Person
    {
        private string firstName;  // Note if you leave private off memebers are Private
                                   // in general better to be explicit 
        public string GetFirstName() { return firstName; }
        private string lastName;
        public string GetLastName() { return lastName; }

        /// <summary>
        /// The Person class will be used as the model for the appklication 
        /// </summary>
        /// <param name="firstName">Given Name </param>
        /// <param name="lastName">Surname </param>
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string ToString()
        {
            return $"{this.firstName},{this.lastName}";
        }

    }
}
