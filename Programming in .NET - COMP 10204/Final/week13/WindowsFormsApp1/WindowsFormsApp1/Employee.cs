using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Employee
    {
        public int ID {  get; }
        public string FirstName { get;}
        public string LastName { get;}  
        public int Department { get; }   
        public string Gender { get; }
        public double Salary { get; }
        public string Prov {  get; }

        public Employee(int iD, string firstName, string lastName, int department, string gender, double salary, string prov)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            Gender = gender;
            Salary = salary;
            Prov = prov;
        }

        public override string ToString()
        {
            return $"{ID,-15}|{FirstName,-15}|{LastName,-15}|{Department,-15}|{Gender,-15}|{Salary,-15}|{Prov,-15}";
        }
    }
}
