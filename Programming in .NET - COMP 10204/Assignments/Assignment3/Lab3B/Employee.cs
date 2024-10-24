using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3B
{
    public class Employee
    {
        public string Name { get; }
        public int Rate { get; }
        public Employee(string name, int rate)
        {
            Name = name;
            Rate = rate;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
