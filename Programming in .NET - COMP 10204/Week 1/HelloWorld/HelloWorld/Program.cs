using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            HelloTom name = new HelloTom();
            name.sayHello();

            Console.WriteLine("{0} | {1}",byte.MinValue,byte.MaxValue);
        }
    }
}
