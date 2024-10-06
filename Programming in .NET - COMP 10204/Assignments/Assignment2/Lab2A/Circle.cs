using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    internal class Circle : TwoDimensionalRound
    {
        public Circle()
        {
            SetData();
        }
        public override void SetData()
        {
            Console.Write("Enter circle radius: ");
            Radius1 = double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"{"Circle",-20}" + base.ToString() + $"R:{Radius1}";
        }
    }
}
