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
    /// Cube Class
    /// </summary>
    internal class Cube : ThreeDimensionalQuadrilateral
    {
        /// <summary>
        /// Cube Constructor
        /// </summary>
        public Cube()
        {
            SetData();
        }

        /// <summary>
        /// Overrided setData() Method
        /// </summary>
        public override void SetData()
        {
            Console.Write("Cube Size: ");
            Length = double.Parse(Console.ReadLine());
            Width = Length;
            Height = Length;
        }

        /// <summary>
        /// Override toString() Method
        /// </summary>
        /// <returns>Returns string representation of Cube</returns>
        public override string ToString()
        {
            return $"{"Cube",-20}" + base.ToString();
        }
    }
}
