using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author: Thomas Coons
//Student ID: 000317961
//Date: Sept 15th 2024
//Purpose: Employee Sorting Application

//I, Thomas Coons, 000317961 certify that this material is my original work.
//No other person's work has been used without due acknowledgement.
namespace OutOfSorts
{
    internal class Lab1
    {
        /// <summary>
        /// Main method of the application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                Employee[] employees = Read();
                for (int i = 0; i < employees.Length; i++)
                {
                    Console.WriteLine(employees[i]);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        /// <summary>
        /// Reads in text from employees.txt and returns an array of Employee Objects
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static Employee[] Read()
        {
            StreamReader data = new StreamReader("employees.txt");
            
            Employee employee = null;

            string[] dataList = data.ReadToEnd().Trim().Split('\n');

            if (dataList.Length > 100)
            {
                throw new Exception("File size too large.");
            }
            else
            {
                Employee[] employees = new Employee[dataList.Length];
                string[] employeeList = new string[100];
                int empInfoTracker = 0;

                for (int i = 0; i < dataList.Length; i++)
                {
                    employeeList[i] = (dataList[i]);
                }

                for (int i = 0; i < dataList.Length; i++)
                {
                    while (empInfoTracker < 1)
                    {
                        string name = employeeList[i].Split(',')[0].Trim();
                        int number = int.Parse(employeeList[i].Split(',')[1].Trim());
                        decimal rate = decimal.Parse(employeeList[i].Split(',')[2].Trim());
                        double hours = double.Parse(employeeList[i].Split(',')[3].Trim());
                        employee = new Employee(name, number, rate, hours);
                        employees[i] = employee;
                        empInfoTracker++;
                    }
                    empInfoTracker = 0;
                }

                return employees;
            }
        }

    }
}
