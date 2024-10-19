using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3B
{
    internal class Service
    {
        public string Name { get; }
        public int Price { get; }
        public Service(string name, int type)
        { 
            Name = name;
            Price = type;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
