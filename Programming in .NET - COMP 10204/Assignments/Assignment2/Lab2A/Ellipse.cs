using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    internal class Ellipse : TwoDimensionalRound
    {
        public Ellipse()
        {
            SetData();
        }

        public override double CalculateArea()
        {
            return PI * (Radius1 * Radius2);
        }
        public override void SetData()
        {
            Console.Write("Enter semi-major axis: ");
            Radius1 = double.Parse(Console.ReadLine());
            Console.Write("Enter semi-minor axis: ");
            Radius2 = double.Parse(Console.ReadLine());
        }
        public override string ToString() => $"{"Ellipse",-20}{Math.Round(CalculateArea(),2),-20}{"Not Applicable",-20}R1:{Radius1} R2:{Radius2}";

    }
}
