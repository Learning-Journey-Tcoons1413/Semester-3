using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstraction
{
    internal abstract class Class1 : Interface1
    {
        public void Hello()
        {
            Console.WriteLine("Hello From Class 1");
        }

        public abstract void Hello2();

        public virtual void Hello3()
        {
            Console.WriteLine("Hello From Class 1");
        }
    }
}
