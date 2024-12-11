using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        BankAccount ba;
        public Form1()
        {
            InitializeComponent();
            savingRadioButton.Checked = true;

            groupBox1.Enabled = false;
            groupBox1.Enabled = true;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            BankAccountType accountType;
            if (firstNameTextBox.Text.Length != 0 && lastNameTextBox.Text.Length != 0)
            {
                Person p = new Person(firstNameTextBox.Text, lastNameTextBox.Text);
                if (checkingRadioButton.Checked)
                {
                    accountType = BankAccountType.CHECKINGS;


                }
                else
                {
                    accountType = BankAccountType.SAVINGS;
                }
                ba = new BankAccount(accountType, p);
                accountNumberTextBox.Text = $"{ba.Number}";
                currentBalanceTextBox.Text = ba.Balance.ToString();
                groupBox1.Enabled = true; 
            }

        }

        private void addTransactionButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // clear listbox
            listBox1.Items.Add(t);  // add to listbox

            groupBox1.Enabled = true; // enable groupbox
            groupBox1.Enabled = false; // disable groupbox

            checkingRadioButton.Checked = true; // radiobutton checked
            checkingRadioButton.Checked = false; // radiobutton not checked


            if (double.TryParse(amountTextBox.Text, out double am))
            {
                double amount = am;
                if (withdrawRadioButton.Checked)
                {
                    ba.AddTransaction(new Transaction(TransactionType.WITHDRAWAL,am));
                    
                }
                else if (depositRadioButton.Checked)
                {
                    ba.AddTransaction(new Transaction(
                        
                        
                        TransactionType.DEPOSIT // accessing enumurator
                        
                        
                        , am));
                }
            }
            foreach(Transaction t in ba.Transactions)
            {
                listBox1.Items.Add(t);
            }
            double c = ba.GetCurrentBalance();
            currentBalanceTextBox.Text = $"{c}";
        }
    }
}
