using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExercise
{
    internal class Class4 : Class2
    {
        public  void SayHelloFromClass2()
        {
            Class2Hello = "BERRY";
            Console.WriteLine(Class2Hello);
        }
    }
}
