using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// I, Thomas Coons, 000317961 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
// Date: October 13th 2024

namespace Lab2A
{
    /// <summary>
    /// Circle Class
    /// </summary>
    internal class Circle : TwoDimensionalRound
    {
        /// <summary>
        /// Circle Constructor
        /// </summary>
        public Circle()
        {
            SetData();
        }

        /// <summary>
        /// Overrided setData() Method
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter circle radius: ");
            Radius1 = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Override toString() Method
        /// </summary>
        /// <returns>Returns string representation of Circle</returns>
        public override string ToString()
        {
            return $"{"Circle",-20}" + base.ToString() + $"R:{Radius1}";
        }
    }
}
