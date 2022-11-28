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
    public partial class formAccount : Form
    {
        private readonly CustomerModel _customer;
        private readonly IAccount _account;
        private readonly IAccountData _accountData;
        private readonly formLogin _login;
        public formAccount(CustomerModel customer, IAccount account, IAccountData accountData, formLogin login)
        {
            InitializeComponent();
            _customer = customer;
            _account = account;
            _accountData = accountData;
            _login = login;
        }
       

        private void btnCreateAcct_Click(object sender, EventArgs e)
        {
            var openBal = txtOpenBal.Text;
            var savingsAcct = rdBtnSavings.Text;
            var currentAcct = rdBtnCurrent.Text;
            var acctType = savingsAcct;
            var isChecked = rdBtnSavings.Checked;
            if (isChecked)
            {
                acctType = savingsAcct;
            }
            else
            {
                acctType = currentAcct;
            }
            if(openBal == "")
            {
                MessageBox.Show("Enter a valid amount as Opening Balance");
                return;
            }

            var validOpenBal = double.TryParse(openBal, out double amount);

            if (validOpenBal)
            {
                if(amount < 0)
                {
                    MessageBox.Show("Enter a valid amount as Opening Balance");
                    return;
                }
                if(acctType == savingsAcct && amount < 1000)
                {
                    MessageBox.Show("1000 naira is the minimum allowable opening balance for this account ");
                    return;
                }
                var createdAcct = _account.CreateAccount(_customer.UserId, acctType, amount);
                if (createdAcct)
                {
                    MessageBox.Show("Success!");
                    rdBtnCurrent.Checked = false;
                    rdBtnSavings.Checked = true;
                    txtOpenBal.Clear();
                }
                else
                {
                    MessageBox.Show("Account creation FAILED");
                }
            }

            
            formHomePage page = new formHomePage(_customer, _account, _accountData, _login);
            page.ShowDialog();
            Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var page = new formHomePage();
            page.Show();
            Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtOpenBal_TextChanged(object sender, EventArgs e)
        {

        }

        private void formAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
