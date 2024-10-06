using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2B
{
    public enum EmployeeRate
    {
        Jane = 30,
        Pat = 45,
        Ron = 40,
        Sue = 50,
        Laurie = 55,
    }
    public enum ServiceType
    {
        Cut = 30,
        Color = 40,
        Highlights = 50,
        Extension = 200,
    }

    public enum ClientType
    { 
        StandardAdult = 0,
        Child = 10,
        Student = 5,
        Senior = 15,
    }
    internal class EmployeeServices
    {
        public EmployeeRate EmployeeRate { get; }
        public List<ServiceType> ServiceTypes { get; }
        public ClientType ClientTypeDiscount { get; }
        public int NumOfClientVisits { get; }
        public int FinalPrice { get; }

        public EmployeeServices(EmployeeRate rate, List<ServiceType> serviceTypes, ClientType clientType, int numOfClients)
        {
            EmployeeRate = rate;
            ServiceTypes = serviceTypes;
            ClientTypeDiscount = clientType;
            NumOfClientVisits = numOfClients;
        }

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
