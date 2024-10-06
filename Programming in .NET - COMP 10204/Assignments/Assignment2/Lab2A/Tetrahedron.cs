using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    internal class Tetrahedron : Shape
    {
        private double Side { get; set; }

        public Tetrahedron()
        {
            SetData();
        }

        public override double CalculateArea()
        {
            return Math.Sqrt(3) * (Side * Side);
        }
        public override double CalculateVolume()
        {
            return (Side * Side * Side) / (6.0 * Math.Sqrt(2));
        }
        public override void SetData()
        {
            Console.Write("Enter side length: ");
            Side =  double.Parse(Console.ReadLine());    

        }
        public override string ToString() => $"{"Tetrahedron",-20}{ Math.Round(CalculateArea(),2),-20}{Math.Round(CalculateVolume(), 2),-20}Side Length:{Side,-20}";   

    }
}
