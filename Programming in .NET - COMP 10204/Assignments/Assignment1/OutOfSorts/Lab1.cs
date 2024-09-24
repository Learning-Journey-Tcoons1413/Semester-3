using System;
using System.IO;

//Author: Thomas Coons
//Student ID: 000317961
//Date Completed: Sept 24th 2024 
//Purpose: Employee Sorting Application

//I, Thomas Coons, 000317961 certify that this material is my original work.
//No other person's work has been used without due acknowledgement.
namespace OutOfSorts
{
    /// <summary>
    /// Lab1 is the main class of the program. 
    /// </summary>
    internal class Lab1
    {
        /// <summary>
        /// Constant variable representing the data found in employees.txt
        /// </summary>
        const string DATA = "employees.txt";

        /// <summary>
        /// The main method of Lab1 Class. Handles user input and output. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            Employee[] employees = null;
            string choice = "";
            try
            {
                employees = Read();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any key to close the program...");
                Console.ReadKey();
                return;
            }
           

            while (!choice.Equals("6"))
            {
                try 
                {
                    PrintMenu();
                    Console.Write("Enter Choice: ");
                    choice = Console.ReadLine();
                    Console.Write("\x1b[2J"); //Site This
                    Console.Write("\x1b[3J"); //Site This
                    Console.Clear();
                    PrintData(choice, employees);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }

        /// <summary>
        /// Reads the text from employees.txt and creates an array of Employee Objects.
        /// </summary>
        /// <returns>Array of Employees</returns>
        /// <exception cref="Exception">Throws when employees.txt exceeds 100 employees or is empty.</exception>
        public static Employee[] Read()
        {

            StreamReader data = new StreamReader(DATA);
            if (data.Peek() == -1)
            {
                throw new Exception("Insufficient File Size");
            }
            string[] dataList = data.ReadToEnd().Trim().Split('\n');
            if (dataList.Length > 100)
            {
                throw new Exception("Insufficient File Size");
            }
            Employee[] arr = new Employee[dataList.Length];
            for (int i = 0; i < dataList.Length; i++)
            {
                string[] empList = dataList[i].Trim().Split(',');
                arr[i] = new Employee(empList[0], int.Parse(empList[1]), decimal.Parse(empList[2]), double.Parse(empList[3]));
            }
            return arr;
        }

        /// <summary>
        /// Sorting method using the 'Quick Sort' Algorithm. 
        /// Sources for Algorithm: https://www.youtube.com/watch?v=Vtckgz38QHs&t=68s | https://www.geeksforgeeks.org/quick-sort-algorithm/#how-does-quicksort-work
        /// </summary>
        /// <param name="arr">Employee array</param>
        /// <param name="start">Starting index of employee array</param>
        /// <param name="end">Ending index of employee array</param>
        /// <param name="choice">User choice represented as in integer</param>
        /// <exception cref="Exception">Throws when user choice is out of specified range</exception>
        public static void Sort(Employee[] arr, int start, int end, int choice)
        {
            if (end <= start)
            {
                return;
            }
            if (choice < 1 || choice > 6)
            {
                throw new Exception("Numbers out of range!");
            }
            int pivot = Partition(arr, start, end, choice);
            Sort(arr, start, pivot - 1, choice);
            Sort(arr, pivot + 1, end, choice);
        }

        /// <summary>
        /// Partitions the array into two sub arrays. 
        /// </summary>
        /// <param name="arr">Employee array</param>
        /// <param name="start">Starting index of partition</param>
        /// <param name="end">Ending index of partition</param>
        /// <param name="choice">User choice represented as in integer</param>
        /// <returns>The index of the pivot</returns>
        public static int Partition(Employee[] arr, int start, int end, int choice)
        {
            Employee temp;
            Employee pivot = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                switch (choice)
                {
                    case 1:
                        if (arr[j].GetName().CompareTo(pivot.GetName()) == -1)
                        {
                            i++;
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                        break;
                    case 2:
                        if (arr[j].GetNumber() < pivot.GetNumber())
                        {
                            i++;
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                        break;
                    case 3:
                        if (arr[j].GetRate() > pivot.GetRate())
                        {
                            i++;
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                        break;
                    case 4:
                        if (arr[j].GetHours() > pivot.GetHours())
                        {
                            i++;
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                        break;
                    case 5:
                        if (arr[j].GetGross() > pivot.GetGross())
                        {
                            i++;
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                        break;
                    default:
                        break;
                }
            }
            i++;
            temp = arr[i];
            arr[i] = arr[end];
            arr[end] = temp;
            return i;
        }

        /// <summary>
        /// Prints the menu to the console.
        /// </summary>
        public static void PrintMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("1. Sort by Employee Name");
            Console.WriteLine("2. Sort by Employee Number");
            Console.WriteLine("3. Sort by Employee Pay Rate");
            Console.WriteLine("4. Sort by Employee Hours");
            Console.WriteLine("5. Sort by Employee Gross Pay");
            Console.WriteLine("6. Exit");
            Console.WriteLine("");
            
        }

        /// <summary>
        /// Prints the sorted data from the Employee array.
        /// </summary>
        /// <param name="choice">User choice represented as a string</param>
        /// <param name="arr">Employee array</param>
        /// <exception cref="Exception">Throws when choice is not a valid integer.</exception>
        public static void PrintData(string choice, Employee[] arr)
        {
            Console.WriteLine($"{"NAME",-20} {"NUMBER",-10} {"RATE",-10} {"HOURS",-10} {"GROSSPAY",-10}");
            Console.WriteLine("");
            bool isValidInt = int.TryParse(choice, out int value);
            if (!isValidInt)
            { 
                throw new Exception("Input must be integer only.");
            }
            int numChoice = int.Parse(choice);
            Sort(arr, 0, arr.Length - 1, numChoice);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
