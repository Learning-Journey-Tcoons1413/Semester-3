using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    internal class Box : ThreeDimensionalQuadrilateral
    {
        public Box()
        {
            SetData();
        }

        public override void SetData()
        {
            Console.Write("Box Length: ");
            Length = double.Parse(Console.ReadLine());
            Console.Write("Box Height: ");
            Height = double.Parse(Console.ReadLine());
            Console.Write("Box Width: ");
            Width = double.Parse(Console.ReadLine());

        }

        public override string ToString()
        {
            return $"{"Box",-20}" + base.ToString();
        }
    }
}
