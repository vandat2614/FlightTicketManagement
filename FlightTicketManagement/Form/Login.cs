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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool checkEmpty()
        {
            if (EmailTb.Text == "" || PassTb.Text == "")
                return true;
            else return false;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            if(checkEmpty())
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(!LoginAccount.Instance.login(EmailTb.Text, PassTb.Text))
                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string type = LoginAccount.Instance.getType(EmailTb.Text).ToString();
                if (type == "admin")
                    new AdminForm().Show();
                this.Hide();
            }

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registerForm = new Register();
            registerForm.ShowDialog();
        }

        private void PassTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowPassCb_CheckedChanged(object sender, EventArgs e)
        {
            PassTb.PasswordChar = ShowPassCb.Checked ? '\0' : '•';
        }
    }
}