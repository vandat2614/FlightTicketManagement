using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightTicketManagement
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        public bool CheckEmpty()
        {
            if (EmailRegisterTb.Text == "" || PassRegisterTb.Text == "" || ConfPassRegisterTb.Text == "")
                return true;
            else return false;
        }
        public bool IsValidEmail(string Email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(Email);
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!IsValidEmail(EmailRegisterTb.Text))
                MessageBox.Show("Invalid email address.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Account.Instance.CheckEmail(EmailRegisterTb.Text))
                MessageBox.Show("This email is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (PassRegisterTb.Text != ConfPassRegisterTb.Text)
                MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else { 
                Account.Instance.RegisterAccount(EmailRegisterTb.Text, PassRegisterTb.Text);
                MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new LoginForm().Show();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowPassCb_CheckedChanged(object sender, EventArgs e)
        {
            PassRegisterTb.PasswordChar = ShowPassCb.Checked ? '\0' : '•';
            ConfPassRegisterTb.PasswordChar = ShowPassCb.Checked ? '\0' : '•';
        }

        private void LoadLoginFormBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().ShowDialog();
        }
    }
}
