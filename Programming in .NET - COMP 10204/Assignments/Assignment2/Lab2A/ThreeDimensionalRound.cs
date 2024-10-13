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
    /// Abstract ThreeDimensionalRound Class
    /// </summary>
    internal abstract class ThreeDimensionalRound : Shape
    {
        /// <summary>
        /// Radius of a ThreeDimensionalRound Shape
        /// </summary>
        protected double Radius { get; set; }

        /// <summary>
        /// Height of a ThreeDimensionalRound Shape
        /// </summary>
        protected double Height {  get; set; }

        /// <summary>
        /// Overrided ToString() Method
        /// </summary>
        /// <returns>String representation of a ThreeDimensionalRound Shape</returns>
        public override string ToString()
        {
            return $"{Math.Round(CalculateArea(), 2),-20}{Math.Round(CalculateVolume(), 2),-20}"+$"R:{Radius}";
        }
    }
}
