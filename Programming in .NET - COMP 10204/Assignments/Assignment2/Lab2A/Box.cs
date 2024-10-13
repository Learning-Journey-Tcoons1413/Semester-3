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
    /// Box Class 
    /// </summary>
    internal class Box : ThreeDimensionalQuadrilateral
    {
        /// <summary>
        /// Box Constructor
        /// </summary>
        public Box()
        {
            SetData();
        }

        /// <summary>
        /// Overrided setData() Method
        /// </summary>
        public override void SetData()
        {
            Console.Write("Box Length: ");
            Length = double.Parse(Console.ReadLine());
            Console.Write("Box Height: ");
            Height = double.Parse(Console.ReadLine());
            Console.Write("Box Width: ");
            Width = double.Parse(Console.ReadLine());

        }

        /// <summary>
        /// Override toString() Method
        /// </summary>
        /// <returns>Returns string representation of Box</returns>
        public override string ToString()
        {
            return $"{"Box",-20}" + base.ToString();
        }
    }
}
