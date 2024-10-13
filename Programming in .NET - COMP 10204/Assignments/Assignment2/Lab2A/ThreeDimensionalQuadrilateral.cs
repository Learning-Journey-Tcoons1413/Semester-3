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
    /// Abstract ThreeDimensionalQuadrilateral Class
    /// </summary>
    internal abstract class ThreeDimensionalQuadrilateral : Shape
    {

        /// <summary>
        /// Length of a ThreeDimensionalQuadrilateral Shape
        /// </summary>
        protected double Length { get; set; }

        /// <summary>
        /// Width of a ThreeDimensionalQuadrilateral Shape
        /// </summary>
        protected double Width { get; set; }

        /// <summary>
        /// Height of a ThreeDimensionalQuadrilateral Shape
        /// </summary>
        protected double Height { get; set; }

        /// <summary>
        /// Overrided CalculateArea() Method
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            return 2 * (Length * Width + Length * Height + Width * Height);
        }

        /// <summary>
        /// Overrided CalculateVolume() Method
        /// </summary>
        /// <returns>Volume of a ThreeDimensionalQuadrilateral Shape</returns>
        public override double CalculateVolume()
        {
            return Length * Width * Height;
        }

        /// <summary>
        /// Overrided toString() Method 
        /// </summary>
        /// <returns>String representation of a ThreeDimensionalQuadrilateral Shape</returns>
        public override string ToString()
        {
            return $"{Math.Round(CalculateArea(),2),-20}{Math.Round(CalculateVolume(),2),-20}L:{Length} W:{Width} H:{Height}"; 
        }
    }


}
