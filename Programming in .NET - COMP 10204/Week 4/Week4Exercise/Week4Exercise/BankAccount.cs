using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Week4Exercise
{
    public enum BankAccountType
    {
        CHECKING, SAVINGS
    }
    internal class BankAccount
    {
        static int nextBankAccount = 10000;

        public decimal Balance { get; private set; }
        public BankAccountType Type { get; }
        public int Number { get; }
        public Person Owner { get; }

        public List<Transaction> Transactions = new List<Transaction>();

        public BankAccount(Person owner, BankAccountType type)
        { 
            Owner = owner;
            Type = type;
            nextBankAccount++;
        }

        public decimal GetCurrentBalance()
        {
            decimal balance = 0;
            foreach (Transaction t in Transactions)
            {
                balance += t.Amount;
            }
            return balance;
        }

        public void AddTransaction(Transaction t)
        {
            if (t.Type == 0)
            {
                Transactions.Add(t);
                Balance += t.Amount;
            }
            else
            {
                Transactions.Add(t);
                Balance -= t.Amount;
            }
        }
        public override string ToString()
        {
            return "Account Owner: " + Owner.FirstName + " " + Owner.LastName + "\n"
                +  "Account Type: " + Type;
        }

    }
}
