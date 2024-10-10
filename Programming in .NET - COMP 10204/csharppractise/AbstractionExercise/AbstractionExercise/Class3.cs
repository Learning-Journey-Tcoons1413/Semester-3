using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExercise
{
    internal class Class3 : Class2
    {
        public Class3()
        { 
            
        }

        public  void SayHelloFromClass2()
        {
            Class2Hello = "BERRY";
            Console.WriteLine(Class2Hello);
        }

        public void RadnomMethod() 
        {
            Console.WriteLine("Random Method");
        }
    }
}
