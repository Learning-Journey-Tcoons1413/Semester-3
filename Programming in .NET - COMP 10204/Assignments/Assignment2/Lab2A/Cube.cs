using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    internal class Cube : ThreeDimensionalQuadrilateral
    {
        public Cube()
        {
            SetData();
        }

        public override void SetData()
        {
            Console.Write("Cube Size: ");
            Length = double.Parse(Console.ReadLine());
            Width = Length;
            Height = Length;
        }

        public override string ToString()
        {
            return $"{"Cube",-20}" + base.ToString();
        }
    }
}
