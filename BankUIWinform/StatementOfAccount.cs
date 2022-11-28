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
    public partial class formStatementOfAccount : Form
    {
        private readonly CustomerModel _customer;
        private readonly IAccount _account;
        private readonly IAccountData _accountData;
        private readonly formLogin _login;
        public formStatementOfAccount(CustomerModel customer, IAccount account, IAccountData accountData, formLogin login)
        {
            InitializeComponent();
            _customer = customer;
            _account = account;
            _accountData = accountData;
            _login = login;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            formHomePage page = new formHomePage();
            page.Show();
            Hide();
        }

        private void btnSoA_Click(object sender, EventArgs e)
        {
            var acctNum = txtAcctNum.Text;
            if(acctNum == "")
            {
                MessageBox.Show("Enter your account number");
                return;
            }
            var transactions = _account.GetAllTransactions(_customer.UserId, acctNum);
            if(transactions != null)
            {
                dataGridSoA.DataSource = transactions;
                lblSoAHeader.Text = "ACCOUNT STATEMENT ON ACCOUNT NO " + acctNum;
                //var tableTrans = new SOATable(_customer, _account, _accountData, transactions);

            }
            else MessageBox.Show("No transactions found for this account");

            
            //Clear all input fields
            txtAcctNum.Clear();
        }

        private void formStatementOfAccount_Load(object sender, EventArgs e)
        {

        }

        private void lblSoAHeader_Click(object sender, EventArgs e)
        {

        }
    }
}
