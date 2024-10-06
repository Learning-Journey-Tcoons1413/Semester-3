using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    internal abstract class ThreeDimensionalQuadrilateral : Shape
    {
        protected double Length { get; set; }
        protected double Width { get; set; }
        protected double Height { get; set; }

        public override double CalculateArea()
        {
            return 2 * (Length * Width + Length * Height + Width * Height);
        }
        public override double CalculateVolume()
        {
            return Length * Width * Height;
        }

        public override string ToString()
        {
            return $"{CalculateArea(),-20}{CalculateVolume(),-20}L:{Length} W:{Width} H:{Height}"; 
        }
    }


}
