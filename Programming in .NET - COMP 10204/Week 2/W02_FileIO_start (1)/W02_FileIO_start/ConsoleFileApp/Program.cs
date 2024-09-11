using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// A demonstration of File I/O in C# and the .Net Framework
/// </summary>
/// 
namespace ConsoleFileApp
{
    class Program
    {
        const string DATAFILE = "Person.txt";
        static void Main(string[] args)
        {
            Person[] people = new Person[1000];
            int numberOfPeople = 0;


            bool running = true;
            while (running)
            {
                Console.Clear();                  // Clear the Console  

                Console.Write("M E N U\n=======\n" +
                    "[A] - Add a User \n" +
                    "[L] - List all current Users\n" +
                    "[R] - Read in List of Users\n" +
                    "[S] - Save User List to a File\n" +
                    "[C] - Clear current List\n" +
                    "[X] - Exit Program\n\n" +
                    "Option : ");
                String option = Console.ReadLine();
                switch (option.ToUpper())
                {
                    case "A":
                        break;

                    case "L":
                        break;
                    case "R":
                        break;
                    case "S":
                        break;
                    case "C":
                        break;
                    case "X":
                        running = false;
                        break;
                    default:
                        Console.Error.WriteLine("Invalid option entered");
                        Console.Beep();
                        break;
                }
                Console.Write("\nHit a key to continue ... ");
                Console.ReadKey();   // Will wait for any key to be pressed 
            }
            Console.WriteLine("\nBye...");
        }
    }
}

