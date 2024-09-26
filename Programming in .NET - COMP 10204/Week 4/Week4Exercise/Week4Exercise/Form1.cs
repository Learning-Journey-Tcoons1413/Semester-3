using System;
using System.Drawing;
using System.Windows.Forms;

namespace Week4Exercise
{
    public partial class Form1 : Form
    {
        private BankAccount ba; // Reference to the model 
        public Form1()
        {
            InitializeComponent();
        }
        private void createBtn_Click(object sender, EventArgs e)
        {

            if (FirstNameTextbox.Text == "" || LastNameTextbox.Text == "")
            {
                statusLabel.Text = "Status: First name and last name cannot be empty.";
                statusLabel.ForeColor = Color.Red;
                return;
            }
            else
            {
                BankAccountType type = BankAccountType.CHECKING;
                if (savingAccountRadioBtn.Checked)
                {
                    type = BankAccountType.SAVINGS;
                }
                createBtn.Enabled = false;
                clearBtn.Enabled = true;
                ba = new BankAccount(new Person(FirstNameTextbox.Text, LastNameTextbox.Text), type);
                accountNumberTextbox.Text = ba.ToString();
                FirstNameTextbox.Text = "";
                LastNameTextbox.Text = "";
                accountInformationGroupBox.Enabled = true;
                FirstNameTextbox.Enabled = false;
                LastNameTextbox.Enabled = false;
                accountTypeGroupBox.Enabled = false;
                statusLabel.Text = "Status: OK.";
                statusLabel.ForeColor = Color.Green;
            }
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

        private void clearBtn_Click(object sender, EventArgs e)
        {
            transactionsListBox.Items.Clear();
            currentBalanceTextbox.Text = "";
            amountTextbox.Text = "0.00";
            accountNumberTextbox.Text = "";
            accountInformationGroupBox.Enabled = false;
            FirstNameTextbox.Enabled = true;
            LastNameTextbox.Enabled = true;
            createBtn.Enabled = true;
            accountTypeGroupBox.Enabled = true;
        }
    }
}
