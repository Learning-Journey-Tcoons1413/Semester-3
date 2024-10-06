using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    internal class Triangle : Shape
    {
        private double Base {  get; set; }
        private double Height { get; set; }

        public Triangle() 
        {
            SetData();
        }
        public override double CalculateArea()
        {
            return (Base * Height) / 2;
        }
        public override double CalculateVolume()
        {
            return 0;
        }
        public override void SetData()
        {
            Console.Write("Triangle Base: ");
            Base = double.Parse(Console.ReadLine());
            Console.Write("Triangle Height: ");
            Height = double.Parse(Console.ReadLine());
        }
        public override string ToString() => $"{"Triangle",-20}{CalculateArea(),-20}{"Not Applicable",-20}B:{Base} H:{Height}";
    }
}
