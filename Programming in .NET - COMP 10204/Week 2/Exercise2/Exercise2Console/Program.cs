using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2Console
{
     class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[5];

            cars[0] = new Car("Honda","Civic",40,550);
            cars[1] = new Car("Ford","Mustang",45,432);
            cars[2] = new Car("VW","Golf",34,667);
            cars[3] = new Car("Ford","Focus",39,600);
            cars[4] = new Car("Chevrolet","Cruz",40,525);

            Console.WriteLine("CAR APPLICATION");
            string option;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("1 - Display all Cards");
                Console.WriteLine("2 - List car with best Fuel Efficiency");
                Console.WriteLine("3 - List all Cars from Ford");
                Console.WriteLine("4 - Exit Application");
                Console.Write("Enter Option: ");

                option = Console.ReadLine();

                switch (option) 
                {
                    case "1":
                        Console.WriteLine("");
                        for (int i = 0; i < cars.Length; i++)
                        {
                            Console.WriteLine(cars[i].ToString());
                        }
                        break;

                    case "2":
                        Console.WriteLine("");
                        double bestFuel = cars[0].CalculateFuelEfficiency();
                        for (int i = 1; i < cars.Length; i++)
                        {
                             
                            if (cars[i].CalculateFuelEfficiency() < bestFuel)
                            { 
                                bestFuel = cars[i].CalculateFuelEfficiency();
                            }
                        }
                        for (int i = 0; i < cars.Length; i++)
                        {
                            if (cars[i].CalculateFuelEfficiency() == bestFuel)
                            {
                                Console.WriteLine(cars[i]);
                            }
                        }
                        break;

                    case "3":
                        Console.WriteLine();
                        for (int i = 0; i < cars.Length; i++)
                        {
                            if (cars[i].getMake() == "Ford")
                            {
                                Console.WriteLine(cars[i]);
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Not an option");
                        break;
                }
            }
            while (option != "4");
        }
    }
}
