using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightTicketManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public bool CheckEmpty()
        {
            if (EmailLoginTb.Text == "" || PassLoginTb.Text == "")
                return true;
            else return false;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(CheckEmpty())
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(!Account.Instance.CheckAccount(EmailLoginTb.Text, PassLoginTb.Text))
                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                string AccountType = Account.Instance.GetAccountType(EmailLoginTb.Text);
                if (AccountType == "admin")
                    new AdminForm().Show();
            }

        }

        private void ShowPassCb_CheckedChanged(object sender, EventArgs e)
        {
            PassLoginTb.PasswordChar = ShowPassCb.Checked ? '\0' : '•';
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void LoadRegisterFormBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegisterForm().ShowDialog();
        }
    }
}