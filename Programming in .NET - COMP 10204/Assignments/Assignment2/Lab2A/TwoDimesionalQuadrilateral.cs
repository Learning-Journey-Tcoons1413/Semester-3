using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    internal abstract class TwoDimesionalQuadrilateral : Shape
    {
        protected double Length { get; set; }
        protected double Width { get; set; }

        public override double CalculateArea()
        {
            return Length * Width;
        }

        public override double CalculateVolume()
        {
            return 0;
        }

        public override string ToString() => $"{CalculateArea(),-20}{"Not Applicable",-20}" + $"L:{Length} W:{Width}";
    }
}
