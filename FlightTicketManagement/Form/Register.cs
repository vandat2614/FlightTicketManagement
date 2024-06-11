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

        private bool isHidePass = true;

        private void clear()
        {
            EmailTb.Text = string.Empty;
            PassTb.Text = string.Empty;
            PassAgainTb.Text = string.Empty;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string email = EmailTb.Text;
            string pass = PassTb.Text;
            string check_pass = PassAgainTb.Text;
            if(email == "")
            {
                MessageBox.Show("Địa chỉ email không được trống");
            } else if(pass == "")
            {
                MessageBox.Show("Mật khẩu không được trống");
            } else if(check_pass == "")
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu");
            } else if (RegisterAccount.Instance.check_email(email))
            {
                MessageBox.Show("Địa chỉ email đã được sử dụng");
            } else if(pass != check_pass)
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
            } else
            {
                bool result = RegisterAccount.Instance.add_account(email, pass);
                if (result)
                {
                    MessageBox.Show("Đăng ký tài khoản thành công");
                    clear();
                }
                else
                {
                    MessageBox.Show("Đăng ký tài khoản không thành công");
                }
            }

        }

        private void HidePassLb_Click(object sender, EventArgs e)
        {
            if (isHidePass)
            {
                PassTb.PasswordChar = '\0';
                PassAgainTb.PasswordChar = '\0';
                HidePassLb.Text = "Ẩn mật khẩu";
            }
            else
            {
                PassTb.PasswordChar = '•';
                PassAgainTb.PasswordChar = '•';
                HidePassLb.Text = "Hiển thị mật khẩu";
            }
            isHidePass = !isHidePass;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void BackToLoginLb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
