using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    internal class Cylinder : ThreeDimensionalRound
    {
        public Cylinder()
        {
            SetData();
        }
        public override double CalculateArea()
        {
            return (2 * PI * Radius * Height) + 2 * PI * (Radius * Radius) ;
        }

        public override double CalculateVolume()
        {
            return PI * (Radius * Radius) * Height;
        }

        public override void SetData()
        {
            Console.Write("Enter Cylinder radius: ");
            Radius = double.Parse(Console.ReadLine());
            Console.Write("Enter Cylinder height: ");
            Height = double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"{"Cylinder",-20}" + base.ToString()+$" H:{Height}";
        }
    }
}
