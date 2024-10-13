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
    /// Sphere Class
    /// </summary>
    internal class Sphere : ThreeDimensionalRound
    {
        /// <summary>
        /// Sphere Constructor
        /// </summary>
        public Sphere()
        {
            SetData();
        }

        /// <summary>
        /// Overrided calculateArea method
        /// </summary>
        /// <returns>Calculates the surface area of a Sphere</returns>
        public override double CalculateArea()
        {
            return 4 * PI * (Radius * Radius);
        }

        /// <summary>
        /// Overrided calculateVolume method
        /// </summary>
        /// <returns>Total volume of a Sphere</returns>
        public override double CalculateVolume()
        {
            return( (4.0 / 3.0) * PI) * (Radius * Radius * Radius);
        }

        /// <summary>
        /// Overrided SetData() method
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter radius: ");
            Radius = double.Parse(Console.ReadLine());  
        }

        /// <summary>
        /// Overrided toString() method
        /// </summary>
        /// <returns>String representation of a Sphere.</returns>
        public override string ToString()
        {
            return $"{"Sphere",-20}" + base.ToString();
        }
    }
}
