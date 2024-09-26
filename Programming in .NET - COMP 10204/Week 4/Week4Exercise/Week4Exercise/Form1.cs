using System;
using System.Windows.Forms;

namespace Week4Exercise
{
    public partial class Form1 : Form
    {
        private BankAccount ba;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {

            if (FirstNameTextbox.Text == "" || LastNameTextbox.Text == "")
            {
                statusLabel.Text = "Status: First name and last name must be filled in.";
                return;
            }
            else
            {
                if (checkingAccountRadioBtn.Checked)
                {
                    createBtn.Enabled = false;
                    clearBtn.Enabled = true;
                    ba = new BankAccount(new Person(FirstNameTextbox.Text, LastNameTextbox.Text), BankAccountType.CHECKING);
                }
                else
                {
                    createBtn.Enabled = false;
                    clearBtn.Enabled = true;
                    ba = new BankAccount(new Person(FirstNameTextbox.Text, LastNameTextbox.Text), BankAccountType.SAVINGS);
                }
            }
            accountNumberTextbox.Text = ba.Number.ToString();
            FirstNameTextbox.Text = "";
            LastNameTextbox.Text = "";
            accountInformationGroupBox.Enabled = true;
            FirstNameTextbox.Enabled = false;
            LastNameTextbox.Enabled = false;
            accountTypeGroupBox.Enabled = false;

        }

        private void addTransactionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Transaction t;
                if (withdrawRadioBtn.Checked)
                {
                    t = new Transaction(TransactionType.WITHDRAWL, decimal.Parse(amountTextbox.Text));
                }
                else
                {
                    t = new Transaction(TransactionType.DEPOSIT, decimal.Parse(amountTextbox.Text));
                }
                ba.AddTransaction(t);
                transactionsListBox.Items.Add(t.Type + ": $" + t.Amount);
                currentBalanceTextbox.Text = ba.GetCurrentBalance().ToString();
            }
            catch (Exception ex) { statusLabel.Text = "Status: Error!"; }
            amountTextbox.Text = "0.00";
        }
    }
}
