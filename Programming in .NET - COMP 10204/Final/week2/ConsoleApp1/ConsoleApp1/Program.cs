using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();                      


            Car car1 = new Car("Toyota", "Camry", 50, 15);
            Car car2 = new Car("Honda", "Civic", 40, 12);
            Car car3 = new Car("Ford", "Focus", 55, 18);
            Car car4 = new Car("Ford", "Malibu", 60, 14);
            Car car5 = new Car("Nissan", "Altima", 45, 16);

            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            cars.Add(car4);
            cars.Add(car5);

            //while (true)
            //{
            //    Menu();
            //    string input = Console.ReadLine();
            //    if (int.TryParse(input, out int choice))
            //    {
            //        switch (choice)
            //        {

            //            case 1:
            //                Console.Clear();
            //                CarMenu();
            //                foreach (Car c in cars)
            //                {
            //                    Console.WriteLine(c);
            //                }
            //                Console.Write("Any key to return to main menu: ");
            //                Console.ReadKey();
            //                Console.Clear();
            //                break;
            //            case 2:
            //                Console.Clear();
            //                CarMenu();
            //                double best = 0;
            //                best = cars[0].calculateFuelEfficiency();
            //                Car bestCar = null;
            //                foreach (Car c in cars)
            //                {
            //                    if (c.calculateFuelEfficiency() < best)
            //                        best = c.calculateFuelEfficiency();
            //                    bestCar = c;
            //                }

            //                Console.WriteLine(bestCar);
            //                Console.Write("Any key to return to main menu: ");
            //                Console.ReadKey();
            //                Console.Clear();
            //                break;
            //            case 3:
            //                Console.Clear();
            //                CarMenu();
            //                foreach (Car c in cars)
            //                {
            //                    if (c.Make == "Ford")
            //                        Console.WriteLine(c);
            //                    Console.WriteLine(c.Mileage);
            //                }

            //                Console.Write("Any key to return to main menu: ");
            //                Console.ReadKey();
            //                Console.Clear();
            //                break;
            //        }
            //    }
            //    else { if (input.ToUpper() == "E") { return; } }
            //}

            while (true) // simple menu loop with user input and exit condition
            {
                Menu();
                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            CarMenu();
                            Console.Write("Any key to return to main menu: ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:
                            break;
                        default:
                            break;
                    }
                }
                else { if (input.ToUpper() == "E") { return; } }
            }
        }

        static void Menu()
        {
            Console.WriteLine("CAR APPLICATION");
            Console.WriteLine("===============");
            Console.WriteLine("MENU:");
            Console.WriteLine("1. Display all of the cars");
            Console.WriteLine("2. List car with best mileage");
            Console.WriteLine("3. List all cars from Ford");
            Console.WriteLine("4. Exit application");
            Console.Write("Input: ");
        }

        static void CarMenu()
        {
            Console.WriteLine($"{"MAKE",-10} | {"MODEL",-10} | {"FUEL",-10} | {"MILEAGE",-10} | {"FUEL EFFICIENCY",-10}");
            Console.WriteLine("======================================================================");
        }
    }
}
