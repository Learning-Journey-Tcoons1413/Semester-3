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
    /// Tetrahedron Class
    /// </summary>
    internal class Tetrahedron : Shape
    {
        /// <summary>
        /// Side of the Tetrahedron
        /// </summary>
        private double Side { get; set; }

        /// <summary>
        /// Tetrahedron Constructor
        /// </summary>
        public Tetrahedron()
        {
            SetData();
        }

        /// <summary>
        /// Overrided CalculateArea() Method
        /// </summary>
        /// <returns>Area of the Tetrahedron</returns>
        public override double CalculateArea()
        {
            return Math.Sqrt(3) * (Side * Side);
        }

        /// <summary>
        /// Overrided CalculateVolume() Method
        /// </summary>
        /// <returns>Total volume of a Tetrahedron</returns>
        public override double CalculateVolume()
        {
            return (Side * Side * Side) / (6.0 * Math.Sqrt(2));
        }

        /// <summary>
        /// Overrided SetData() Method
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter side length: ");
            Side =  double.Parse(Console.ReadLine());    

        }

        /// <summary>
        /// Overrided ToString() Method
        /// </summary>
        /// <returns>String representation of a Tetrahedron</returns>
        public override string ToString() => $"{"Tetrahedron",-20}{ Math.Round(CalculateArea(),2),-20}{Math.Round(CalculateVolume(), 2),-20}Side Length:{Side,-20}";   

    }
}
