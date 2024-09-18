using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cities
{
    internal class City
    {
        public String Name { get; }
        public String Province { get; }
        public int Population { get; }

        public City(String name, String province, int population)
        { 
            Name = name;
            Province = province;
            Population = population;
        }

        public override String ToString()
        {
            return $"{Name, -30} {Province, -8} {Population:#,###}";
        }
    }
}
