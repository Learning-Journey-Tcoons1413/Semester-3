using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public enum BankAccountType
    {
        CHECKINGS,
        SAVINGS
    }
    internal class BankAccount
    {
        private static int nextBankAccountNumber = 10000;
        public double Balance { get; private set; }
        public BankAccountType Type { get; }
        public int Number { get; }
        public Person Owner { get; }
        public List<Transaction> Transactions { get; }

        public BankAccount(BankAccountType type, Person owner)
        {
            Balance = 0;
            Type = type;
            Owner = owner;
            Transactions = new List<Transaction>();
            Number = nextBankAccountNumber;
            nextBankAccountNumber++;
        }       

        public double GetCurrentBalance()
        {
            Balance = 0;
            foreach (Transaction t in Transactions)
            {
                if (t.Type == TransactionType.DEPOSIT)
                {
                    Balance += t.Amount;
                }
                else if (t.Type == TransactionType.WITHDRAWAL)
                {
                    Balance -= t.Amount;    
                }
            }
            return Balance;
        }

        public void AddTransaction(Transaction t)
        {
            if (t.Type == TransactionType.WITHDRAWAL)
            {
                // Check if there are sufficient funds for the withdrawal
                if ((Balance - t.Amount) < 0)
                {
                    throw new ArgumentException("Insufficient funds for withdrawal.");
                }
                else
                {
                    Transactions.Add(t);
                }
            }
            else
            {
                Transactions.Add(t);
            }
        }


        public override string ToString()
        {
            return base.ToString(); 
        }
    }
}
