using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Animal
    {
        private int legs;

        public Animal(int legs)
        { 
            this.legs = legs; 
        }

        public abstract String MakeSound();
    }
}
