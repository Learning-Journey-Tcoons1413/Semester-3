using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Practise
{
    internal class Dog : Animal
    {
        private int _age;
        public Dog(string name, int leg, string sound, int age) : base(name, leg, sound, age)
        {
            _age = age;
        }

        public override int Age
        { 
            get
            { 
                return base.Age; 
            }
            set
            {
                base.Age = value * 7;
            }
        }
        public override string WhatAmI()
        {
            return base.WhatAmI() + $". More specifically, I am a {Name}";
        }
        public override string Move()
        {
            return $"{Name} likes to walk on the ground!";
        }

    }
}
