using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            BankAccount ba;
            if (checkingAccountRadioBtn.Checked)
            {
                 ba = new BankAccount(new Person(FirstNameTextbox.Text, LastNameTextbox.Text), BankAccountType.CHECKING);
            }
            else
            {
                 ba = new BankAccount(new Person(FirstNameTextbox.Text, LastNameTextbox.Text), BankAccountType.SAVINGS);
            }
            MessageBox.Show("Account Created!");
            transactionsListBox.Items.Add(ba);
        }
    }
}
