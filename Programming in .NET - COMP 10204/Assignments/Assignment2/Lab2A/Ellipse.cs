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
    /// Ellipse Class
    /// </summary>
    internal class Ellipse : TwoDimensionalRound
    {
        /// <summary>
        /// Ellipse Constructor
        /// </summary>
        public Ellipse()
        {
            SetData();
        }

        /// <summary>
        /// Overrided calculate area method
        /// </summary>
        /// <returns>Area of the Ellipse</returns>
        public override double CalculateArea()
        {
            return PI * (Radius1 * Radius2);
        }

        /// <summary>
        /// Overrided setData() Method
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter semi-major axis: ");
            Radius1 = double.Parse(Console.ReadLine());
            Console.Write("Enter semi-minor axis: ");
            Radius2 = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Overrided to string method 
        /// </summary>
        /// <returns>String representation of Ellipse</returns>
        public override string ToString() => $"{"Ellipse",-20}{Math.Round(CalculateArea(),2),-20}{"N/A",-20}R1:{Radius1} R2:{Radius2}";

    }
}
