using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Exercise
{
    internal class Person
    {

        public string FirstName { get; private set; }
        public string LastName { get; private set; } 

        public Person(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
        }

        public override string ToString()
        {
            return base.ToString(); 
        }
    }
}
