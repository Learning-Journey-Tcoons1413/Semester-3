using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public enum TransactionType
    {
        DEPOSIT,
        WITHDRAWAL
    }
    internal class Transaction
    {
        public TransactionType Type{ get; }
        public double Amount {  get; }  

        public Transaction (TransactionType type, double amount)
        {
            Type = type;
            Amount = amount;    
        }

        public override string ToString()
        {
            return Type + " " + Amount; 
        }
    }
}
