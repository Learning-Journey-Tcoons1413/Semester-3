using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] data = new int[100];

            const int SIZE = 10;

            List<int> data = new List<int>();   
            Random random = new Random();

            for (int i = 0; i < SIZE; i++)
            {
                data.Add(random.Next(1000,4000));
            }
            Sort(data);
            foreach (var number in data)
            {
                Console.WriteLine(number);
            }

            //List <int> subset = new List<int>();

            //foreach (var number in data)
            //{
            //    if (number >= 2000 && number <= 2500)
            //    { 
            //        subset.Add(number);
            //    }
            //}

            //foreach (var x in subset)
            //{
            //    Console.WriteLine($"Values found: {x}" );
            //}


            //var results = from x in data where x >= 2000 && x <= 2500 select x;
            //foreach (var item in results)
            //{
            //    Console.WriteLine("Value found: "+item);
            //}
            
        }

        public static void Sort(List<int> data)
        {
            for (int i = 0; i < data.Count() - 1; i++)
            {
                for (int j = 0; j < data.Count() - 1; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
        }
    }
}
