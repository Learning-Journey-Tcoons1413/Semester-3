using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("Winston",4,"Bark!",5);
            Console.WriteLine(dog);
            Console.WriteLine(dog.Move());
            Console.WriteLine(dog.WhatAmI());
        }
    }
}
