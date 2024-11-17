using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10Exercise
{
    internal class Student
    {
        public string FName { get;}
        public string LName { get; }
        public int Grade1 { get; }
        public int Grade2 { get; }
        public double Average {  get; }
        public Student(string fname, string lname, int grade1, int grade2)
        {
            FName = fname;
            LName = lname;  
            Grade1 = grade1;    
            Grade2 = grade2;    
            Average = (double)(grade1 + grade2) / 2;  
        }

        public override string ToString()
        {
            return $"{FName,-15} {LName,-15} {Grade1,-15} {Grade2,-15} {Average,-15}";
        }
    }
}
