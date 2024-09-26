using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Exercise
{
    public enum TransactionType
    { 
        DEPOSIT, WITHDRAWL
    }
    internal class Transaction
    {
        public TransactionType Type { get; }

        public decimal Amount { get; }

        public Transaction(TransactionType type, decimal amount)
        {
            Type = type;
            Amount = amount;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
