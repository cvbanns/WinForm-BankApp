using BankApp.Data;
using BankApp.Interfaces;
using BankApp.Models;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAppUI
{
    public partial class formWithdrawal : Form
    {
        private readonly CustomerModel _customer;
        private readonly IAccount _account;
        private readonly IAccountData _accountData;
        private readonly formLogin _login;
        public formWithdrawal(CustomerModel customer, IAccount account, IAccountData accountData, formLogin login)
        {
            InitializeComponent();
            _customer = customer;
            _account = account;
            _accountData = accountData;
            _login = login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formHomePage page = new formHomePage();
            page.Show();
            Hide();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            var acctNum = txtAcctNum.Text;
            var amount = txtAmount.Text;
            
            if (acctNum == "" || amount == "")
            {
                MessageBox.Show("Kindly input valid Account Number and Amount");
                return;
            }
            if (!double.TryParse(amount, out double tempAmount))
            {
                MessageBox.Show("Amount input is invalid");
                return;
            }

            var validWithdraw = _account.Withdrawal(_customer.UserId, acctNum, tempAmount);
            if (validWithdraw)
            {
                MessageBox.Show("Withdrawal Successful!");
                //Clear all input text fields
                txtAmount.Clear();
                txtAcctNum.Clear();
                return;
            }
            MessageBox.Show("Unable to withdraw from this account");
            
        }

        private void formWithdrawal_Load(object sender, EventArgs e)
        {

        }
    }
}
