using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Practise
{
    internal abstract class Animal
    {
        public string Name { get;}
        public int Leg {  get;}
        public string Sound {  get;}

        public virtual int Age { get; set; }

        public Animal(string name, int leg, string sound, int age)
        {
            Name = name;
            Leg = leg;
            Sound = sound;
            Age = age;
        }

        public abstract string Move();

        public virtual string WhatAmI()
        {
            return "I am an animal!";
        }
        public override string ToString()
        { return $"{Name} has {Leg} legs. {Name} makes a {Sound} sound! {Name} is {Age} years old."; }
    }
}
