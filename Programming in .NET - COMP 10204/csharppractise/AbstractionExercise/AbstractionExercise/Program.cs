using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class3();

            if (c is Class3 asdasdasdasda)
            {
                asdasdasdasda.SayHelloFromClass2 ();   
            }
        }
    }
}
