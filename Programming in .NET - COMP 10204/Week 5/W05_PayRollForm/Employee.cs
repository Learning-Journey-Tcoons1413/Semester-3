// Fig. 12.4: Employee.cs
// Employee abstract base class.
using System;

namespace PayRollForm
{
    public abstract class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string ID { get; }

        // three-parameter constructor
        
            public Employee(string firstName, string lastName, string id)
            {
                if (firstName == "" || lastName == "" || id == "")
                    throw new ArgumentOutOfRangeException("Must Specify First Name, Last Name and ID");
                FirstName = firstName;
                LastName = lastName;
                ID = id;
            }
        
        // Virtual means there is default behavior that can be overridden in a derived or sub-class
        public virtual string ToCsv()
        {
            return $"{GetEmployeeType()},{FirstName},{LastName},{ID}";
        }

        // return string representation of Employee object, using properties
        // override is used to change existing or implement new behavior 
        public override string ToString()
        {
            return $"{GetEmployeeType()}: {FirstName} {LastName} ID: {ID} ";
        }

        // abstract method must be overridden by derived classes or/
        // the derived class will still be abstract 
        public abstract decimal Earnings(); // no implementation here

        public abstract string GetEmployeeType();

    }
}


/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 **************************************************************************/
