using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Thomas", "Coons");
            Console.WriteLine(person.FirstName + person.LastName);
            person.LastName = "Hello";
            Console.WriteLine(person.FirstName + person.LastName);
        }
    }
}
