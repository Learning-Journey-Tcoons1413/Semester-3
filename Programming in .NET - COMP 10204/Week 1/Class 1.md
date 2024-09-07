*Date: September 4th 2024*

**Circle and Area Example:**

```cs
//MAIN
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
            double radius = double.Parse(input);
            Circle c = new Circle(radius);
            double area = c.getArea();
            Console.WriteLine(area);
        }
    }
}
```

```cs
//CIRCLE
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
```

[[Programming in .NET - COMP 10204/To Do|To Do]]


