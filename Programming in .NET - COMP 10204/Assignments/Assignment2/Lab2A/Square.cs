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
    /// Square Class
    /// </summary>
    internal class Square : TwoDimesionalQuadrilateral
    {
        /// <summary>
        /// Square Constructor
        /// </summary>
        public Square() 
        {
            SetData();
        }

        /// <summary>
        /// Overrided SetData() method
        /// </summary>
        public override void SetData()
        {
            Console.Write("Size of square: ");
            double size = double.Parse(Console.ReadLine());
            Length = size;
            Width = size;
        }

        /// <summary>
        /// Overrided ToString() method
        /// </summary>
        /// <returns>String representation of a Square</returns>
        public override string ToString()
        {
            return $"{"Square",-20}" + base.ToString();
        }
    }
}
