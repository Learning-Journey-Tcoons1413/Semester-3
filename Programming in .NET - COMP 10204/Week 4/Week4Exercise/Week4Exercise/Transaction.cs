using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Exercise
{
    public enum TransactionType
    { 
        DEPOSIT = 0, WITHDRAWL = 1
    }
    internal class Transaction
    {
        private TransactionType type;
        private decimal amount;

        public TransactionType Type { get { return type; } }
        public decimal Amount { get { return amount; } }

        public Transaction(TransactionType type, decimal amount)
        {
            this.type = type;
            this.amount = amount;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
