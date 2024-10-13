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
    /// TwoDimensionalRound Class
    /// </summary>
    internal abstract class TwoDimensionalRound : Shape
    {
        /// <summary>
        /// TwoDimensionalRound Raduis1
        /// </summary>
        protected double Radius1 { get; set; }

        /// <summary>
        /// TwoDimensionalRound Raduis2
        /// </summary>
        protected double Radius2 { get; set; }

        /// <summary>
        /// Overrided CalculateArea() Method
        /// </summary>
        /// <returns>Area of a TwoDimensionalRound Shape</returns>
        public override double CalculateArea()
        {
            return PI * (Radius1 * Radius1);
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
        /// <returns>String Represenation of a TwoDimensionalRound Shape</returns>
        public override string ToString() => $"{Math.Round(CalculateArea(),2),-20}{"N/A",-20}";
    }
}
