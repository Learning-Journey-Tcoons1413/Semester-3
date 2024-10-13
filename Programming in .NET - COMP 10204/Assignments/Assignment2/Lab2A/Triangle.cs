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
    /// Triangle Class
    /// </summary>
    internal class Triangle : Shape
    {
        /// <summary>
        /// Base of a Triangle
        /// </summary>
        private double Base {  get; set; }

        /// <summary>
        /// Height of a Triangle
        /// </summary>
        private double Height { get; set; }

        /// <summary>
        /// Triangle Constructor
        /// </summary>
        public Triangle() 
        {
            SetData();
        }

        /// <summary>
        /// Overrided CalculateArea() Method
        /// </summary>
        /// <returns>Area of a Triangle</returns>
        public override double CalculateArea()
        {
            return (Base * Height) / 2;
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
        /// Overrided SetData() Method
        /// </summary>
        public override void SetData()
        {
            Console.Write("Triangle Base: ");
            Base = double.Parse(Console.ReadLine());
            Console.Write("Triangle Height: ");
            Height = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Overrided ToString() Method
        /// </summary>
        /// <returns>String representation of a Triangle</returns>
        public override string ToString() => $"{"Triangle",-20}{CalculateArea(),-20}{"N/A",-20}B:{Base} H:{Height}";
    }
}
