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
    public partial class AdminUsers : Form
    {
        public AdminUsers()
        {
            InitializeComponent();
        }

        private void AdminUsers_Load(object sender, EventArgs e)
        {
            LoadUserList();
        }

        public void LoadUserList()
        {
            List<UserInfo> users = UserData.Instance.GetUserData();
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
            else if(RegisterAccount.Instance.check_email(EmailTb.Text))
                MessageBox.Show("This email is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                RegisterAccount.Instance.add_acoount_full(EmailTb.Text, PassTb.Text, NameTb.Text, RoleCbb.Text, PhoneTb.Text);
                MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUserList();
            }
        }

        public string id_account_update = null;
        private void ListUserGv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = ListUserGv.Rows[e.RowIndex];
            id_account_update = row.Cells[0].Value.ToString();
            NameTb.Text = row.Cells[1].Value.ToString();
            RoleCbb.Text = row.Cells[2].Value.ToString();
            EmailTb.Text = row.Cells[3].Value.ToString();
            PassTb.Text = row.Cells[4].Value.ToString();
            PhoneTb.Text = row.Cells[5].Value.ToString();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if(CheckEmpty())
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult result = MessageBox.Show("Are you want to update", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    RegisterAccount.Instance.update_account(id_account_update, EmailTb.Text, PassTb.Text, NameTb.Text, RoleCbb.Text, PhoneTb.Text);
                    MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUserList() ;
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
                RegisterAccount.Instance.delete_account(id_account_update);
                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUserList();
            }
        }
    }
}
