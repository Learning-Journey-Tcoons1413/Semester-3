using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Circle
    {
        private double radius;

        public Circle(double radius) 
        {
            this.radius = radius;
        }

        public double getArea()
        {
            Double area = Math.PI * (this.radius * this.radius);
            return area;
        }
    }
}
