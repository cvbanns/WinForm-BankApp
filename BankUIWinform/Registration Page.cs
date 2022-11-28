using BankApp.Data;
using BankApp.Implementations;
using BankApp.Interfaces;
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
using static System.Net.Mime.MediaTypeNames;

namespace BankAppUI
{
    public partial class formRegistration : Form
    {
        private readonly IBank _bank;
        private readonly ICustomerData _customerData;
        private readonly ICustomer _customer;
        private readonly IValidation _validation;
        private readonly formLogin _login;
        public formRegistration(IBank bank, IValidation validation, ICustomerData customerData,
                            ICustomer customer, formLogin login)
        {
            InitializeComponent();
            _bank = bank;
            _validation = validation;
            _customerData = customerData;
            _customer = customer;
            _login = login;
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var firstName = txtFirstName.Text;
            var lastName = textBox1.Text;
            var email = txtEmail.Text;
            var password = txtPassword.Text;
            var validate = new Validation();
            if (!validate.ValidateName(firstName))
            {
                MessageBox.Show("Enter a Valid FirstName");
                return;
            }

            if (!validate.ValidateName(lastName))
            {
                MessageBox.Show("Enter a Valid LastName");
                return;
            }

            if (!validate.ValidateEmail(email))
            {
                MessageBox.Show("Enter a Valid Email");
                return;
            }

            if (!validate.ValidatePassword(password))
            {
                MessageBox.Show("Enter a Valid Password");
                return;
            }

            int lastId = _customerData.LastId() + 1;

            var newCustomer = _bank.NewCustomer(lastId, firstName, lastName, email, password);

            if (newCustomer)
            {
                MessageBox.Show("Successfully registered!");
                SwitchToLogin();
                Hide();
            }
            else
            {
                MessageBox.Show("Unable to Register please try again");
            }
            //var customer = new Customer(firstname, lastname, email, password);

        }

        private void SwitchToLogin()
        {
            _login.Show();

        }

        //MessageBox.Show("Success");
        /*var acct = new formAccount();
            acct.Show();
            Hide();

        }*/

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SwitchToLogin();
            Hide();
            /*var login = new formLogin();
            login.Show();
            Hide();
            */
        }

        private void formRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
