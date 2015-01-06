using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerAccountInfoApp
{
    public partial class CustomerAccountUI : Form
    {
        
        public CustomerAccountUI()
        {
            InitializeComponent();
        }

        private Customer aCustomer;
        private void saveButton_Click(object sender, EventArgs e)
        {
            Account newAccount = new Account();
            newAccount.Number = accountNumberEntryTextBox.Text;
            newAccount.OpeningDate = openingDateEntryTextBox.Text;

            aCustomer = new Customer();
            aCustomer.Name = customerNameEntryTextBox.Text;
            aCustomer.Email = emailEntryTextBox.Text;
            aCustomer.AnAccount = newAccount;

            MessageBox.Show("Created");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
           double amount = Convert.ToDouble(amountEntryTextBox.Text);
            aCustomer.AnAccount.Deposit(amount);
            MessageBox.Show("Diposited");
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountEntryTextBox.Text);
            aCustomer.AnAccount.Withdraw(amount);
            MessageBox.Show("Withdrawn");
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            customerNameDisplayTextBox.Text = aCustomer.Name;
            emailDisplayTextBox.Text = aCustomer.Email;
            accontNumberDisplayTextBox.Text = aCustomer.AnAccount.Number;
            openingDateDisplayTextBox.Text = aCustomer.AnAccount.OpeningDate;
            balanceDisplayTextBox.Text = aCustomer.AnAccount.Balance.ToString();
        }
    }
}
