using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    internal class Sphere : ThreeDimensionalRound
    {
        public Sphere()
        {
            SetData();
        }

        public override double CalculateArea()
        {
            return 4 * PI * (Radius * Radius);
        }

        public override double CalculateVolume()
        {
            return( (4.0 / 3.0) * PI) * (Radius * Radius * Radius);
        }

        public override void SetData()
        {
            Console.Write("Enter radius: ");
            Radius = double.Parse(Console.ReadLine());  
        }

        public override string ToString()
        {
            return $"{"Sphere",-20}" + base.ToString();
        }
    }
}
