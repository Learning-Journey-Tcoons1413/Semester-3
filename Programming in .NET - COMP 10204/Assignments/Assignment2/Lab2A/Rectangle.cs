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
    /// Rectangle Class
    /// </summary>
    internal class Rectangle : TwoDimesionalQuadrilateral
    {
        /// <summary>
        /// Rectangle Constructor
        /// </summary>
        public Rectangle()
        {
            SetData();
        }

        /// <summary>
        /// Overrided setData() method
        /// </summary>
        public override void SetData()
        {
            Console.Write("Rectangle Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Rectangle Width: ");
            double width = double.Parse(Console.ReadLine());
            Length = length;
            Width = width;
        }

        /// <summary>
        /// Overrided toString() method
        /// </summary>
        /// <returns>String representaiton of Rectangle</returns>
        public override string ToString()
        {
            return $"{"Rectangle",-20}" + base.ToString();
        }
    }
}
