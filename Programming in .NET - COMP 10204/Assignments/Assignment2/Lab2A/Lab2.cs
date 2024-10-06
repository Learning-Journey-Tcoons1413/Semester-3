using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    internal class Lab2
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            string userInput = "";
            bool running = true;
            while (running)
            {
                
                PrintMenu();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter choice: ");
                userInput =  Console.ReadLine().ToUpper();
                
                Console.Clear();
                switch (userInput)
                {
                    case "1":
                        PrintMenu();
                        Shape triangle = new Triangle();
                        shapes.Add(triangle);
                        break;
                    case "2":
                        PrintMenu();
                        Shape square = new Square();
                        shapes.Add(square);
                        break;
                    case "3":
                        PrintMenu();
                        Shape rectangle = new Rectangle();
                        shapes.Add(rectangle);
                        break;
                    case "4":
                        PrintMenu();
                        Shape circle = new Circle();
                        shapes.Add(circle);
                        break;
                    case "5":
                        PrintMenu();
                        Shape eclipse = new Ellipse();
                        shapes.Add(eclipse);
                        break;
                    case "6":
                        PrintMenu();
                        Shape box = new Box();
                        shapes.Add(box);
                        break;
                    case "7":
                        PrintMenu();
                        Shape cube = new Cube();
                        shapes.Add(cube);
                        break;
                    case "8":
                        PrintMenu();
                        Shape sphere = new Sphere();
                        shapes.Add(sphere);
                        break;
                    case "9":
                        PrintMenu();
                        Shape cylinder = new Cylinder();
                        shapes.Add(cylinder);
                        break;
                    case "10":
                        PrintMenu();
                        Shape tetrahedron = new Tetrahedron();
                        shapes.Add(tetrahedron);
                        break;
                    case "E":
                        running = false;
                        break;
                    default:
                        PrintMenu();
                        Console.Write("Invalid Choice.");
                        break;

                }
                Console.Clear();
                
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{"SHAPE",-20}{"AREA",-20}{"VOLUME",-20}{"DETAILS",-20}");
            Console.WriteLine($"{"=====",-20}{"====",-20}{"======",-20}{"=======",-20}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Total Shape Count: " + Shape.GetCount());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void PrintMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Author: Thomas Coons | Student ID: 000317961");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine($"{"1.Triangle",-15}{"2. Square",-15}{"3. Rectangle",-15}");
            Console.WriteLine($"{"4.Circle",-15}{"5. Ellipse",-15}{"6. Box",-15}");
            Console.WriteLine($"{"7.Cube",-15}{"8. Sphere",-15}{"9. Cylinder",-15}");
            Console.WriteLine($"{"10.Tetrahedron",-15}{"E. Exit and Display Shapes",-15}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Current Shape Count: " + Shape.GetCount());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
