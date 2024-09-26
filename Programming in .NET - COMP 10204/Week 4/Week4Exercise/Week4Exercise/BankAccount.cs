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
        private static int nextBankAccountNUmber = 10000; 

        public decimal Balance { get; private set; }

        public BankAccountType Type { get; }

        public int Number {  get; }

        public Person Owner { get; }

        public List<Transaction> Transactions { get; }

        public BankAccount(Person owner, BankAccountType type)
        {
            Owner = owner;
            Type = type;
            Balance = 0;
            Number = nextBankAccountNUmber;
            nextBankAccountNUmber++;
            Transactions = new List<Transaction>();
        }

        public decimal GetCurrentBalance()
        {
            Balance = 0;
            foreach (var t in Transactions)
            {
                if (t.Type == TransactionType.DEPOSIT)
                {
                    Balance += t.Amount;
                }
                else { Balance -= t.Amount; }
            }
            return Balance;
        }

        public void AddTransaction(Transaction t)
        {
            if (t.Type == TransactionType.WITHDRAWL)
            {
                if (t.Amount <= Balance)
                {
                    Transactions.Add(t);
                }
                else { throw new ArgumentException("ERROR:"); }
            }
            else { Transactions.Add(t); }
        }
        public override string ToString()
        {
            return $"Account#: {Number} | Account Type: {Type} | Owner: {Owner}";
        }

    }
}
