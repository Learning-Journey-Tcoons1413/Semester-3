using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// I, Thomas Coons, 000317961 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
// Date: November 2nd 2024
namespace Lab3B
{
    /// <summary>
    /// Employee Class
    /// </summary>
    public class Employee
    {
        public string Name { get; }
        public int Rate { get; }

        /// <summary>
        /// Employee Constructor
        /// </summary>
        /// <param name="name">Employee Name</param>
        /// <param name="rate">Employee Rate</param>
        public Employee(string name, int rate)
        {
            Name = name;
            Rate = rate;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
