using System;


namespace HelloWorld
{
    internal class HelloTom
    {
        private string name = "Tom";

        public HelloTom(string name)
        {
            this.name = name;
        }

        public HelloTom()
        {
           
        }

        public void sayHello()
        {
            Console.WriteLine("Hello " + this.name);
        }

    }
}
