using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    internal abstract class ThreeDimensionalRound : Shape
    {
        protected double Radius { get; set; }

        protected double Height {  get; set; }

        public override string ToString()
        {
            return $"{Math.Round(CalculateArea(), 2),-20}{Math.Round(CalculateVolume(), 2),-20}"+$"R:{Radius}";
        }
    }
}
