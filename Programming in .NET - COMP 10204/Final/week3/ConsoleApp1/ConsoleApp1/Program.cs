using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] values = { 99,22,555,432,17,29,33,20,1};
            //var filter =         // always use var 
            //    from x in values // always from first
            //    where x < 20     // some condition, evaluates to true if item exists
            //    orderby x        // OR orderby x descending
            //    select x;        // we grab it, and it appears

            //foreach(var f in filter)
            //{
            //    Console.WriteLine(f);
            //}

            List<Employee> employees = new List<Employee>
            {
                new Employee("John", "Smith", 5000m),
                new Employee("Jane", "Doe", 6000m),
                new Employee("Alex", "Johnson", 7000m),
                new Employee("Michael", "Williams", 5500m),
                new Employee("Sarah", "Brown", 111m),
                new Employee("Sarah", "Smith", 6500m)
            };

            employees.Insert(0, new Employee("Jess", "Pan", 12333)); // insert into list at specific index


            employees.RemoveAt(1); // remove item at specific index

            Employee emp = new Employee("Bob","Joe",123123);
            employees.Add(emp); 
            bool contains = employees.Contains(emp); // check to see if something exists in list



            Console.WriteLine(contains);

            var results =                       // use var, assume list of employees exists
                from e in employees
                where e.MonthlySalary >= 6000   // use can set conditions. Also access object properties
                select e;                       // grab the item. then use a for loop through results

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

            var names =
                from e in employees
                where e.FirstName == "Sarah" && e.LastName == "Brown"
                select new {e.FirstName, e.LastName, e.MonthlySalary }; // select individual stuff

            foreach (var name in names.Distinct())
            {
                Console.WriteLine(name);
            }
        }


    }
}
