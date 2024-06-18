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
    public partial class Admin_UserForm : Form
    {
        public Admin_UserForm()
        {
            InitializeComponent();
        }

        private void AdminUsers_Load(object sender, EventArgs e)
        {
            LoadListAccount();
        }

        public void LoadListAccount()
        {
            List<UserInfo> users = Account.Instance.GetListAccount();
            ListUserGv.DataSource = users;
        }

        public bool CheckEmpty()
        {
            if (EmailTb.Text == "" || NameTb.Text == "" || PassTb.Text == "" || RoleCbb.Text == "" || PhoneTb.Text == "")
                return true;
            return false;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(CheckEmpty())
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(Account.Instance.check_email(EmailTb.Text))
                MessageBox.Show("This email is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Account.Instance.add_account(EmailTb.Text, PassTb.Text, RoleCbb.Text, NameTb.Text, PhoneTb.Text);
                MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListAccount();
            }
        }

        public string old_email = null;
        private void ListUserGv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = ListUserGv.Rows[e.RowIndex];
            EmailTb.Text = row.Cells[0].Value.ToString();
            PassTb.Text = row.Cells[1].Value.ToString();
            RoleCbb.Text = row.Cells[2].Value.ToString();
            NameTb.Text = row.Cells[3].Value.ToString();
            PhoneTb.Text = row.Cells[4].Value.ToString();
            old_email = EmailTb.Text;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if(CheckEmpty())
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(old_email != null && EmailTb.Text != old_email && Account.Instance.check_email(EmailTb.Text))
                MessageBox.Show("This email is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult result = MessageBox.Show("Are you want to update", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    Account.Instance.update_account(EmailTb.Text, old_email, PassTb.Text, NameTb.Text, RoleCbb.Text, PhoneTb.Text);
                    MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    old_email = null;
                    LoadListAccount() ;
                }
            }
        }

        public void clear()
        {
            EmailTb.Text = "";
            PassTb.Text = "";
            NameTb.Text = "";
            RoleCbb.SelectedIndex = -1;
            PhoneTb.Text = "";
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Account.Instance.delete_account(EmailTb.Text);
                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListAccount();
            }
        }

        private void EmailTb_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
