using BankApp.Data;
using BankApp.Interfaces;
using BankApp.Models;
using BankAppWinForm;
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
    public partial class formAccountDetails : Form
    {
        private readonly CustomerModel _customer;
        private readonly IAccount _account;
        private readonly IAccountData _accountData;
        private readonly formLogin _login;
        public formAccountDetails(CustomerModel customer, IAccount account, IAccountData accountData, formLogin login)
        {
            InitializeComponent();
            _customer = customer;
            _account = account;
            _accountData = accountData;
            _login = login;
        }
        public formAccountDetails()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            formHomePage page = new formHomePage(_customer, _account, _accountData, _login);
            page.Show();
            Hide();
        }

        private void formAccountDetails_Load(object sender, EventArgs e)
        {
            var list = new List<AccountDetailsFormatModel>();
            var allAcount = _accountData.GetAccountsByUserId(_customer.UserId);

            if (allAcount.Count > 0)
            {
                foreach (var account in allAcount)
                {
                    list.Add(new AccountDetailsFormatModel() { Name = _customer.Name, AccountNo = account.AccountNo, AccountType = account.AccountType, Balance = account.Balance });
                }
                dataGridAcctDeetUser.DataSource = list;
            }
            else
            {
                MessageBox.Show("No account for this user");
            }
        }

        private void dataGridAcctDeetUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
