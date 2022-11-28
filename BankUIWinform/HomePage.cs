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
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAppUI
{
    public partial class formHomePage : Form
    {
        private readonly CustomerModel _customer;
        private readonly IAccount _account;
        private readonly IAccountData _accountData;
        private readonly formLogin _login;
        public formHomePage(CustomerModel customer, IAccount account, IAccountData accountData, formLogin login)
        {
            InitializeComponent();
            _customer = customer;
            _account = account;
            _accountData = accountData;
            _login = login;
        }
        public formHomePage()
        {
            InitializeComponent();
        }

        private void formHomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateNewAcct_Click(object sender, EventArgs e)
        {
            var createAcct = new formAccount(_customer, _account, _accountData, _login);
            createAcct.Show();
            Hide();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            var withdrawal = new formWithdrawal(_customer, _account, _accountData, _login);
            withdrawal.Show();
            Hide();
        }

        private void btnAcctBal_Click(object sender, EventArgs e)
        {
            var AcctDetails = new formAccountDetails(_customer, _account, _accountData, _login);
            var allAcount = _accountData.GetAccountsByUserId(_customer.UserId);
            if (allAcount.Count > 0)
            {
                AcctDetails.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("No account for this user");
            }

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            formDeposit deposit = new formDeposit(_customer, _account, _accountData, _login);
            deposit.Show();
            Hide();
        }

        private void btnSoA_Click(object sender, EventArgs e)
        {
            var statementOfAccount = new formStatementOfAccount(_customer, _account, _accountData, _login);
            statementOfAccount.Show();
            Hide();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            var transfer = new formTransfer(_customer, _account, _accountData, _login);
            transfer.Show();
            Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
