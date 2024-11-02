using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// I, Thomas Coons, 000317961 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
// Date: November 2nd 2024
namespace Lab3B
{
    /// <summary>
    /// Employee Services Class
    /// </summary>
    public class EmployeeServices
    {
        public int Total { get; private set; }
        public Employee Employee { get; }
        public Service Type { get; }

        /// <summary>
        /// Employee Services Constructor
        /// </summary>
        /// <param name="employee">Employee</param>
        /// <param name="service">Service</param>
        public EmployeeServices(Employee employee, Service service)
        { 
            Employee = employee;
            Type = service;
            Total += Type.Price;
            Total += Employee.Rate;
        }

        /// <summary>
        /// Adds a service and adds to total price
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public int AddService(Service type)
        {
            Total += type.Price;
            return type.Price;
        }

        /// <summary>
        /// Calucaltes total services cost
        /// </summary>
        /// <returns></returns>
        public int CalculateTotal()
        { 
            return Total;
        }

    }
}
