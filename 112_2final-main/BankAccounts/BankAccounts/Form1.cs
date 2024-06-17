using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccounts
{
    public partial class Form1 : Form
    {
        List<Account> bankAccountsList = new List<Account>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            string id = idTextbox.Text;
            string name = nameTextbox.Text;

            if (decimal.TryParse(balanceTextbox.Text, out decimal balance))
            {

                //**************************
                // Create a new account
                Account newAccount = new Account(id, name, balance);

                // Add account to list
                bankAccountsList.Add(newAccount);

                // Update account listbox display
                accountListbox.Items.Add($"{id} {name}");

            }
            else
                MessageBox.Show("金額格式錯誤");
            
            idTextbox.Text = "";
            nameTextbox.Text = "";
            balanceTextbox.Text = "";
        }

        private void accountListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = accountListbox.SelectedIndex;
            if (decimal.TryParse(amountTextBox.Text, out decimal amount))
            {
                processTransaction(index, amount);
            }
            else
                MessageBox.Show("金額格式錯誤");
        }

        private void processTransaction(int index, decimal amount)
        {

            //**************************
            if (index >= 0 && index < bankAccountsList.Count)
            {
                Account selectedAccount = bankAccountsList[index];

                if (depositRadioButton.Checked)
                {
                    selectedAccount.Deposit(amount);
                    MessageBox.Show($"存款餘額: NT$ {selectedAccount.Balance}");
                }
                else if (withdrawRadioButton.Checked)
                {
                    selectedAccount.Withdraw(amount);
                    MessageBox.Show($"存款餘額: NT$ {selectedAccount.Balance}");


                }
                else if (showRadioButton.Checked)
                {
                    MessageBox.Show($"存款餘額: NT$ {selectedAccount.Balance}");
                }
            }





        }
    }
}
