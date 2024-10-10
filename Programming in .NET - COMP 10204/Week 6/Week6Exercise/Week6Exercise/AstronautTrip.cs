using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6Exercise
{
    internal class AstronautTrip
    {
        public string Name { get; }
        public DateTime Depart { get; }

        private DateTime arrive;
        public DateTime Arrive { get; } 

        public AstronautTrip(string name, DateTime depart)
        {
            Name = name;
            Depart = depart.AddHours(6).AddMinutes(15);
            Arrive = Depart.AddDays(3).AddHours(8).AddMinutes(30) ;
        }

        public override bool Equals(Object other)
        {
            if (other is AstronautTrip ast)
            {
                if (ast.Depart == this.Depart)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return $"{Name} | {Depart} | {Arrive} ";
        }
    }
}
