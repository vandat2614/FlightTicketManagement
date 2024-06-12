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

            var result = LoginAccount.Instance.login(email, password);
            bool is_valid = result.Item1;
            string account_type = result.Item2.ToString();

            if (!is_valid)
            {
                MessageBox.Show("Địa chỉ email hoặc mật khẩu không hợp lệ");
                clear();
            } else
            {
                if(account_type == "0")
                {
                    this.Hide();
                    AdminDashBoard dashboard = new AdminDashBoard();
                    dashboard.ShowDialog();
                    this.Show();
                } else
                {
                    MessageBox.Show("Các type khác ddowijd di :v");
                }

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
            this.Show();
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