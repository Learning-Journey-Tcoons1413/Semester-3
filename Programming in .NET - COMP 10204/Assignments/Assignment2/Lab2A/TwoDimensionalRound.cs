using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    internal abstract class TwoDimensionalRound : Shape
    {
        protected double Radius1 { get; set; }
        protected double Radius2 { get; set; }

        public override double CalculateArea()
        {
            return PI * (Radius1 * Radius1);
        }

        public override double CalculateVolume()
        {
            return 0;
        }

        public override string ToString() => $"{Math.Round(CalculateArea(),2),-20}{"Not Applicable",-20}";
    }
}
