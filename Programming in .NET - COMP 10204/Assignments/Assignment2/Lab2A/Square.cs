using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    internal class Square : TwoDimesionalQuadrilateral
    {
        public Square() 
        {
            SetData();
        }
        public override void SetData()
        {
            Console.Write("Size of square: ");
            double size = double.Parse(Console.ReadLine());
            Length = size;
            Width = size;
        }
        public override string ToString()
        {
            return $"{"Square",-20}" + base.ToString();
        }
    }
}
