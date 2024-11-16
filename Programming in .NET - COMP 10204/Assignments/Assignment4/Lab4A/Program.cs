using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//I, Thomas Coons, 000317961 certify that this material is my original work.
//No other person's work has been used without due acknowledgement.

//NOTE: Original Author: Nicholas Corkigian. 
//NOTE: Updated By: Thomas Coons
namespace Lab4A
{
    /// <summary>
    /// Main Class
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main method reads the data file, populates the Employee array and provides a menu of sort options.
        /// </summary>
        /// <param name="args">Command line arguments are not used in this program</param>
        static void Main(string[] args)
        {
            int count;                                      // Keep track of how many employees are instantiated
            bool loop = true;                               // A loop control variable
            string input;                                   // The user's menu option pick as a string
            int choice;                                     // The user's menu option pick as an integer
            List<Employee> employees;                       // The List of Employee objects

            // Read the data file to build the Employee array and find out how many there are
            Read(out employees, out count);

            // Keep the menu loop running so the user can sort several times
            while (loop)
            {
                // Display the menu and retrieve the user's choice
                input = Menu();

                // Based on the user's entry, sort using the appropriate option
                if (Int32.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        // Sort by employee name - ascending
                        case 1:
                            employees.Sort((x, y) => string.Compare(x.Name, y.Name));
                            foreach (Employee emp in employees)
                            {
                                Console.WriteLine(emp);
                            }
                            break;

                        // Sort by employee ID number - ascending
                        case 2:
                            employees.Sort((x, y) => x.Number.CompareTo(y.Number));
                            foreach (Employee emp in employees)
                            {
                                Console.WriteLine(emp);
                            }
                            break;

                        // Sort by hourly rate - descending
                        case 3:
                            employees.Sort((x, y) => y.Rate.CompareTo(x.Rate));
                            foreach (Employee emp in employees)
                            {
                                Console.WriteLine(emp);
                            }
                            break;

                        // Sort by weekly hours - descending
                        case 4:
                            employees.Sort((x, y) => y.Hours.CompareTo(x.Hours));
                            foreach (Employee emp in employees)
                            {
                                Console.WriteLine(emp);
                            }
                            break;

                        // Sort by gross pay - descending
                        case 5:
                            employees.Sort((x, y) => y.Gross.CompareTo(x.Gross));
                            foreach (Employee emp in employees)
                            {
                                Console.WriteLine(emp);
                            }
                            break;

                        // Exit the program
                        case 6:
                            loop = false;
                            break;

                        // Trap invalid selections to try again
                        default:
                            Console.WriteLine("\n*** Invalid Choice - Try Again ***\n");
                            break;
                    }

                    // Display the table when a valid choice is made, otherwise display an error
                    if (choice >= 0 && choice <= 5)
                        DisplayTable(employees, count);
                }
                else
                    Console.WriteLine("\n*** Invalid Choice - Try Again ***\n");
            }
        }

        /// <summary>
        /// This method displays the entire table, including column headers
        /// </summary>
        /// <param name="employees">The array of employees</param>
        /// <param name="count">How many employees are in use</param>
        private static void DisplayTable(List<Employee> employees, int count)
        {
            Console.Clear();
            Console.WriteLine("Employee              Number    Rate  Hours  Gross Pay           Nick's Company");
            Console.WriteLine("====================  ======  ======  =====  =========           --------------");

            // Display each employee in the array
            for (int i = 0; i < count; i++)
                Console.WriteLine(employees[i]);
            Console.WriteLine();
        }

        /// <summary>
        /// This method displays the menu options to the user and returns their selection
        /// </summary>
        /// <returns>The user's menu selection</returns>
        private static string Menu()
        {
            Console.WriteLine("1. Sort by Employee Name");
            Console.WriteLine("2. Sort by Employee Number");
            Console.WriteLine("3. Sort by Employee Pay Rate");
            Console.WriteLine("4. Sort by Employee Hours");
            Console.WriteLine("5. Sort by Employee Gross Pay");
            Console.WriteLine("\n6. Exit");
            Console.Write("\nEnter choice: ");

            return Console.ReadLine();
        }

        /// <summary>
        /// This method reads the data file and stores all of the employee information into a list of Employees
        /// </summary>
        /// <param name="employees">The array of employees</param>
        /// <param name="count">How many employees are in use</param>
        private static void Read(out List<Employee> employees, out int count)
        {
            count = 0;                                    // The current number of employees
            string input;                                 // One line of data read from the file
            employees = new List<Employee>();             // The Employee list

            try
            {
                // Open the file for reading purposes
                FileStream file = new FileStream("employees.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);

                // As long as there is data in the file, keep processing 
                // Each employee record is comma separated, so explode each piece into an array,
                // create a new employee object and increment the count
                while ((input = reader.ReadLine()) != null)
                {
                    string[] exploded = input.Split(',');
                    employees.Add(new Employee(exploded[0], int.Parse(exploded[1]), decimal.Parse(exploded[2]), double.Parse(exploded[3])));
                    count++;
                }

                reader.Close();                             // Always good form to close the file
            }

            // Just in case the file can't be found - graceful exit
            catch (IOException e)
            {
                Console.WriteLine("*** File is empty - Program Aborting ***\n");
                Environment.Exit(1);
            }
        }
    }
}
