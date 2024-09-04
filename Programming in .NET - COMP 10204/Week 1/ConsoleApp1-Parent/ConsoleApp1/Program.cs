using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a radius: ");
            String input = Console.ReadLine();
            Double radius = Double.Parse(input);
            Circle c = new Circle(radius);
            double area = c.getArea();
            Console.WriteLine(area);
        }
    }
}
