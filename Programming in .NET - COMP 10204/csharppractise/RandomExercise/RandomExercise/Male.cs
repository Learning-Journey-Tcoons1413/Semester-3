using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomExercise
{
    internal class Male : Person
    {

        public string Gender { get; set; }
        public Male(string firstName, string lastName, int age, string gender) : base(firstName, lastName, age)
        {
            Gender = gender;
        }

        public override string ToString()
        { 
            return base.ToString() + $" {Gender}";
        }

    }
}
