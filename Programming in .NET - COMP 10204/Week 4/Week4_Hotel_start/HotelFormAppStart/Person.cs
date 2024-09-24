using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFormAppStart
{
    class Person
    {
        public string FirstName { get; }  // Note if you leave private off memebers are Private
                                          // in general better to be explicit 
        public string LastName { get; }

        /// <summary>
        /// The Person class will be used as the model for the appklication 
        /// </summary>
        /// <param name="firstName">Given Name </param>
        /// <param name="lastName">Surname </param>
        public Person(string firstName, string lastName)
        {
            if (firstName == "" || LastName == "")
            {
                throw new ArgumentException("Cant be empty");
            }
            FirstName = firstName;
            LastName = lastName;
        }
        /// <summary>
        /// Override the default tostring method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        /// <summary>
        /// Person name match will yield a match for the class 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Person p)
                return FirstName == p.FirstName && LastName == p.LastName;
            return false;
        }

        /// <summary>
        /// Not used here - needed to supply when we override equals
        /// To work in the Collection framework, same fields exist in equals method.
        /// </summary>
        /// <returns>
        /// integer hashcode of the two strings</returns>
        public override int GetHashCode()
        {
            return (FirstName + LastName).GetHashCode();
        }
    }
}
