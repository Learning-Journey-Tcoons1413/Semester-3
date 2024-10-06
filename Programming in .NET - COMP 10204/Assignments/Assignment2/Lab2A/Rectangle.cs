using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    internal class Rectangle : TwoDimesionalQuadrilateral
    {

        public Rectangle()
        {
            SetData();
        }
        public override void SetData()
        {
            Console.Write("Rectangle Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Rectangle Width: ");
            double width = double.Parse(Console.ReadLine());
            Length = length;
            Width = width;
        }

        public override string ToString()
        {
            return $"{"Rectangle",-20}" + base.ToString();
        }
    }
}
