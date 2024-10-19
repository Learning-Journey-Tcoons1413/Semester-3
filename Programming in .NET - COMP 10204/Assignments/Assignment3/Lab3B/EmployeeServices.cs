using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3B
{
    internal class EmployeeServices
    {
        public int Total { get; private set; }
        public Employee Employee { get; }
        public Service Type { get; }
        public EmployeeServices(Employee employee, Service service)
        { 
            Employee = employee;
            Type = service;
            Total += Type.Price;
            Total += Employee.Rate;
        }
        public int AddService(Service type)
        {
            Total += type.Price;
            return type.Price;
        }
        public int CalculateTotal()
        { 
            return Total;
        }

    }
}
