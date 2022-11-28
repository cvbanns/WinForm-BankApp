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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankAppUI
{
    public partial class formDeposit : Form
    {
        private readonly CustomerModel _customer;
        private readonly IAccount _account;
        private readonly IAccountData _accountData;
        private readonly formLogin _login;
        public formDeposit(CustomerModel customer, IAccount account, IAccountData accountData, formLogin login)
        {
            InitializeComponent();
            _customer = customer;
            _account = account;
            _accountData = accountData;
            _login = login;
        }
        public formDeposit()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            var acctNum = txtAcctNum.Text;
            var amount = txtAmount.Text;

            if(acctNum == "" || amount == "")
            {
                MessageBox.Show("Kindly enter a valid Account Number and also a valid amount");
                return;
            }
            if (!double.TryParse(amount, out double tempAmount))
            
            {
                MessageBox.Show("Kindly enter a valid amount of money to deposit");
                return;
            }

            var validDeposit = _account.Deposit(_customer.UserId, acctNum, tempAmount);
            
            if (validDeposit)
            {
                MessageBox.Show("Deposit Successful");
                txtAcctNum.Clear();
                txtAmount.Clear();
                return;
            }
            
            MessageBox.Show("Deposit failed!");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            formHomePage page = new formHomePage();
            page.Show();
            Hide();
        }

        private void formDeposit_Load(object sender, EventArgs e)
        {

        }
    }
}
