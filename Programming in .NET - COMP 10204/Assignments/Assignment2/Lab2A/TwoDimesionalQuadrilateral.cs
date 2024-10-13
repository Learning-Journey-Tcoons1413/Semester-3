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
    /// TwoDimesionalQuadrilateral Class
    /// </summary>
    internal abstract class TwoDimesionalQuadrilateral : Shape
    {
        /// <summary>
        /// Length of a TwoDimesionalQuadrilateral Shape
        /// </summary>
        protected double Length { get; set; }

        /// <summary>
        /// Width of a TwoDimesionalQuadrilateral Shape
        /// </summary>
        protected double Width { get; set; }

        /// <summary>
        /// Overrided CalculateArea() Method
        /// </summary>
        /// <returns>Area of a TwoDimesionalQuadrilateral Shape</returns>
        public override double CalculateArea()
        {
            return Length * Width;
        }

        /// <summary>
        /// Overrided CalculateVolume() Method
        /// </summary>
        /// <returns>0</returns>
        public override double CalculateVolume()
        {
            return 0;
        }

        /// <summary>
        /// Overrided ToString() Method
        /// </summary>
        /// <returns>String representation of a TwoDimesionalQuadrilateral Shape</returns>
        public override string ToString() => $"{CalculateArea(),-20}{"N/A",-20}" + $"L:{Length} W:{Width}";
    }
}
