using BankApp.Data;
using BankApp.Implementations;
using BankApp.Interfaces;
using BankApp.Implementations;
using Microsoft.Win32;
using System.Runtime.CompilerServices;

namespace BankAppUI
{
    public partial class formLogin : Form
    {
        private formRegistration _register;
        private readonly IBank _bank;
        private readonly ICustomerData _customerData;
        private readonly IAccountData _accountData;
        private readonly IValidation _validation;
        private readonly ICustomer _customer;
        private readonly IAccount _account;
        public formLogin(IBank bank, IValidation validation, ICustomerData customerData,
                            ICustomer customer, IAccount account, IAccountData accountData)
        {
            InitializeComponent();
            _bank = bank;
            _customerData = customerData;
            _validation = validation;
            _customer = customer;
            _register = new formRegistration(_bank, _validation, _customerData, _customer, this);
            _account = account;
            _accountData = accountData;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var login = new formRegistration(_bank, _validation, _customerData, _customer, this);
            login.Show();
            Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //txtPassword.PasswordChar = '*';
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please provide a valid Email and Password");
                return;
            }
            var customer = _bank.Login(txtEmail.Text, txtPassword.Text);
           
            if (customer == null) MessageBox.Show("User does not exist");
            else
            {
                var home = new formHomePage(customer, _account, _accountData,this);
                home.Show();
                Hide();
            }
             
        }
    }
}