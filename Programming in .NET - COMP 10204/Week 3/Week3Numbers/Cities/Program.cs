using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cities
{
    internal class Program
    {
        const String DATA_FILE = "CanadaPop.csv";
        static List<City> cities = new List<City>();

        static void Main(string[] args)
        {
            Read();
            //Sort(cities);
            //foreach (City city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            var results = from city in cities where city.Name == "Boston" select city;
            foreach (City city in results) { Console.WriteLine(city); }

        }
        public static void Read()
        {
            try
            {
                StreamReader sr = new StreamReader(DATA_FILE);
                while (!sr.EndOfStream)
                {
                    String[] items = sr.ReadLine().Split(',');
                    cities.Add(new City(items[0], items[1], int.Parse(items[2])));
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Sort(List<City> data)
        {
            for (int i = 0; i < data.Count() - 1; i++)
            {
                for (int j = 0; j < data.Count() - 1; j++)
                {
                    if (data[j].Name[0] < data[j + 1].Name[0])
                    {
                        City temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
        }
    }
}
