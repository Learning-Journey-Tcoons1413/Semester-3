using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExercise
{
    internal abstract class Class2 : Class1
    {
        public override void TestOne()
        {
            Console.WriteLine("Abstract Class2 implementing abstract method from Class1");
        }
    }
}
