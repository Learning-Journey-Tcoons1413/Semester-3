using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// I, Thomas Coons, 000317961 certify that this material is my original work.  No other person's work has been used without due acknowledgement.
// Date: October 13th 2024

namespace Lab2B
{
    /// <summary>
    /// EmployeeRates
    /// </summary>
    public enum EmployeeRate
    {
        Jane = 30,
        Pat = 45,
        Ron = 40,
        Sue = 50,
        Laurie = 55,
    }

    /// <summary>
    /// ServiceType
    /// </summary>
    public enum ServiceType
    {
        Cut = 30,
        Color = 40,
        Highlights = 50,
        Extension = 200,
    }

    /// <summary>
    /// ClientType
    /// </summary>
    public enum ClientType
    { 
        StandardAdult = 0,
        Child = 10,
        Student = 5,
        Senior = 15,
    }
    /// <summary>
    /// EmployeeServices Class
    /// </summary>
    internal class EmployeeServices
    {

        public EmployeeRate EmployeeRate { get; }
        public List<ServiceType> ServiceTypes { get; }
        public ClientType ClientTypeDiscount { get; }
        public int NumOfClientVisits { get; }
        public int FinalPrice { get; }

        /// <summary>
        /// EmployeeServices Constructor
        /// </summary>
        /// <param name="rate">Rate of Employee</param>
        /// <param name="serviceTypes">Service Type Selection</param>
        /// <param name="clientType">Type of client</param>
        /// <param name="numOfClients">Number of clients</param>
        public EmployeeServices(EmployeeRate rate, List<ServiceType> serviceTypes, ClientType clientType, int numOfClients)
        {
            EmployeeRate = rate;
            ServiceTypes = serviceTypes;
            ClientTypeDiscount = clientType;
            NumOfClientVisits = numOfClients;
        }

        /// <summary>
        /// Calculate total amount of money owed by a customer
        /// </summary>
        /// <returns>total amount as a dollar figure</returns>
        public double CalculateTotal()
        { 
            double total = 0;
            double clientTypeDiscount = 0;
            double numOfClientDiscount = 0;


            if (NumOfClientVisits < 4)
                numOfClientDiscount = 0;
            else if (NumOfClientVisits >= 4 && NumOfClientVisits <= 8)
                numOfClientDiscount = (double) 5.0 / 100.0;
            else if (NumOfClientVisits >= 9 && NumOfClientVisits <= 13)
                numOfClientDiscount = (double) 10.0 / 100.0;
            else
            {
                numOfClientDiscount = (double) 15.0 / 100.0;
            }

            total += (double) EmployeeRate;

            foreach (ServiceType serviceType in ServiceTypes)
            {
                total += (double)serviceType;
            }
            numOfClientDiscount = total * numOfClientDiscount;
            clientTypeDiscount = total * (double)ClientTypeDiscount / 100.0;
            total -= clientTypeDiscount + numOfClientDiscount;
            
            return total;
        }
    }
}
