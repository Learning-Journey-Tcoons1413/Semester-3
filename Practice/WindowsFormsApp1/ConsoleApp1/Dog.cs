using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dog : Animal
    {
        public Dog(int legs) : base(legs)
        {
            
        }


        override public String MakeSound() { return "BARK"; }
    }
}
