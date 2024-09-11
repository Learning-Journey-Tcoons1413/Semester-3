using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

            string nameFile = @"People.txt";
            string[] fileContents = File.ReadAllLines(nameFile);

            string firstName;
            string lastName;

            for (int i = 0; i < fileContents.Length; i++)
            {
                firstName = (fileContents[i].Split(',')[0]);
                lastName = (fileContents[i].Split(',')[1]);
                people[i] = new Person(firstName, lastName);
                numberOfPeople++;
            }

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
                        Console.Write("Firstname: ");
                        firstName = Console.ReadLine();

                        Console.Write("Lastname: ");
                        lastName = Console.ReadLine();

                        Person person = new Person(firstName,lastName);
                        people[numberOfPeople] = person;
                        numberOfPeople++;
                        break;

                    case "L":
                        for (int i = 0; i < numberOfPeople; i++) 
                        { 
                            Console.WriteLine(people[i]);   
                        }
                        break;
                    case "R":
                        break;
                    case "S":
                        File.AppendAllText(nameFile, $"\n{people[numberOfPeople - 1].ToString()}");
                        break;
                    case "C":
                        File.WriteAllText(nameFile, "");
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

