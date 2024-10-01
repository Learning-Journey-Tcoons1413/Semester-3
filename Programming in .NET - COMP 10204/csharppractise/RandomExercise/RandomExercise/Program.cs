using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = null;
            try
            {
                person = new Male("Thomas", "Coons", 30, "Male");
                if (person is Male male)
                    male.Gender = "Female";
                Console.WriteLine(person);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
