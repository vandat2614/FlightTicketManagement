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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public bool checkEmpty()
        {
            if (EmailTb.Text == "" || PassTb.Text == "" || PassAgainTb.Text == "")
                return true;
            else return false;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (checkEmpty())
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (RegisterAccount.Instance.check_email(EmailTb.Text))
                    MessageBox.Show("This email is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (PassTb.Text != PassAgainTb.Text)
                    MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    RegisterAccount.Instance.add_account(EmailTb.Text, PassTb.Text);
                    MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    new Login().Show();
                }
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
        }

        private void ShowPassCb_CheckedChanged(object sender, EventArgs e)
        {
            PassTb.PasswordChar = ShowPassCb.Checked ? '\0' : '•';
            PassAgainTb.PasswordChar = ShowPassCb.Checked ? '\0' : '•';
        }
    }
}
