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
    public partial class formTransfer : Form
    {
        private readonly CustomerModel _customer;
        private readonly IAccount _account;
        private readonly IAccountData _accountData;
        private readonly formLogin _login;
        public formTransfer(CustomerModel customer, IAccount account, IAccountData accountData, formLogin login)
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

        private void txtSendAcct_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if(ValidateInput())
            {
                var amount = double.Parse(txtAmount.Text);
                if(amount < 0)
                {
                    MessageBox.Show("Enter an Amount greater than 0");
                    return;
                }
                var transferApproval = _account.Transfer(_customer.UserId, amount, txtSendAcct.Text, txtDestAcct.Text);
                if (transferApproval)
                {
                    MessageBox.Show("Transfer successful!");
                    //Clears all input text fields
                    txtSendAcct.Clear(); 
                    txtDestAcct.Clear(); 
                    txtAmount.Clear();
                }
                else MessageBox.Show("Insufficient Funds.");
            }
           
        }

        private bool ValidateInput()
        {
            var sendAcctNo = txtSendAcct.Text;
            var destAcctNo = txtDestAcct.Text;
            var amount = txtAmount.Text;


            if (sendAcctNo == "" || destAcctNo == "" || amount == "")
            {
                MessageBox.Show("Kidly input data in all fields");
                return false;
            }
            var sendAcct = _accountData.GetAccountByUserIdAndAccountNo(_customer.UserId, sendAcctNo);
            if (sendAcct == null)
            {
                MessageBox.Show("Open an account to enjoy this feature.");
                return false;
            }
            var destAcct = _accountData.GetAccountByAccountNo(destAcctNo);
            if (destAcct == null)
            {
                MessageBox.Show("This account does not exist");
                return false;
            }
            if (!double.TryParse(amount, out double amt))
            {
                MessageBox.Show("Enter a valid Amount");
                return false;
            }
            return true;
        }
    }
}
