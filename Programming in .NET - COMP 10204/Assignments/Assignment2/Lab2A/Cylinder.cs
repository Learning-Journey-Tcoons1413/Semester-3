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
    /// Cylinder Class
    /// </summary>
    internal class Cylinder : ThreeDimensionalRound
    {
        /// <summary>
        /// Cylinder Constructor
        /// </summary>
        public Cylinder()
        {
            SetData();
        }

        /// <summary>
        /// Calculate area method
        /// </summary>
        /// <returns>The surface area of a Cylinder</returns>
        public override double CalculateArea()
        {
            return (2 * PI * Radius * Height) + 2 * PI * (Radius * Radius) ;
        }

        /// <summary>
        /// Calculate volume method
        /// </summary>
        ///  <returns>The volume of a Cylinder</returns>
        public override double CalculateVolume()
        {
            return PI * (Radius * Radius) * Height;
        }

        /// <summary>
        /// Overrided setData method
        /// </summary>
        public override void SetData()
        {
            Console.Write("Enter Cylinder radius: ");
            Radius = double.Parse(Console.ReadLine());
            Console.Write("Enter Cylinder height: ");
            Height = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Overrided to string method
        /// </summary>
        /// <returns>String representaion of a Cylinder</returns>
        public override string ToString()
        {
            return $"{"Cylinder",-20}" + base.ToString()+$" H:{Height}";
        }
    }
}
