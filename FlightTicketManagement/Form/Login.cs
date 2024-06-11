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

        private bool isHidePass = true;

        private void clear()
        {
            EmailTb.Text = string.Empty;
            PassTb.Text = string.Empty;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string email = EmailTb.Text;
            string password = PassTb.Text;
            if(LoginAccount.Instance.login(email, password))
            {
                this.Hide();
                DashBoard dashboard = new DashBoard();
                dashboard.ShowDialog();
            } else
            {
                MessageBox.Show("Địa chỉ email hoặc mật khẩu không hợp lệ");
                clear();
            }
        }

        private void HidePassLb_Click(object sender, EventArgs e)
        {
            if (isHidePass)
            {
                PassTb.PasswordChar = '\0';
                HidePassLb.Text = "Ẩn mật khẩu";
            } else
            {
                PassTb.PasswordChar = '•';
                HidePassLb.Text = "Hiển thị mật khẩu";
            }
            isHidePass = !isHidePass;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
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
    }
}