using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int number1;
            string input;
            System.Console.SetWindowSize(300, 300);
            System.Console.Write("Enter a number and hit enter, press q to quit: ");
            input = Console.ReadLine();

            while (int.TryParse(input, out number1))
            {
                total += number1;
                System.Console.WriteLine("total: " + total);
                System.Console.Write("more : ");
                input = Console.ReadLine();
            }
        }
    }
}
