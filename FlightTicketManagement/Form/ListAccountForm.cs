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
    public partial class ListAccountForm : Form
    {
        public ListAccountForm()
        {
            InitializeComponent();
        }

        private void AdminUsers_Load(object sender, EventArgs e)
        {
            LoadListAccount();
        }

        public void LoadListAccount()
        {
            List<AccountData> ListAccount = Account.Instance.GetListAccount();
            ListAccountData.DataSource = ListAccount;

            ListAccountData.Columns["email"].HeaderText = "Email";
            ListAccountData.Columns["pass"].HeaderText = "Password";
            ListAccountData.Columns["type"].HeaderText = "Account Type";
            ListAccountData.Columns["name"].HeaderText = "User Name";
            ListAccountData.Columns["phone"].HeaderText = "Phone Number";
        }

        public bool CheckEmpty()
        {
            if (AccountEmailTb.Text == "" || AccountPassTb.Text == "")
                return true;
            return false;
        }

        public bool IsValidEmail(string Email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(Email);
        }

        public void ClearInfo()
        {
            AccountEmailTb.Text = "";
            AccountPassTb.Text = "";
            AccountNameTb.Text = "";
            AccountTypeCbb.SelectedIndex = -1;
            AccountPhoneTb.Text = "";

            AccountOldEmail = null;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (AccountOldEmail == null) return;
            if(CheckEmpty())
                MessageBox.Show("Email address or password cannot be empty", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(!IsValidEmail(AccountEmailTb.Text))
                MessageBox.Show("Invalid email address.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (AccountOldEmail != null && AccountOldEmail != AccountEmailTb.Text && Account.Instance.CheckEmail(AccountEmailTb.Text))
                MessageBox.Show("This email is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult result = MessageBox.Show("Are you want to update", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                        Account.Instance.UpdateAccount(AccountEmailTb.Text, AccountOldEmail, AccountPassTb.Text, AccountNameTb.Text, AccountTypeCbb.Text, AccountPhoneTb.Text);
                        MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInfo();
                    LoadListAccount();
                }

            }
        }


        private void AddAccountBtn_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
                MessageBox.Show("Email address or password cannot be empty", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(!IsValidEmail(AccountEmailTb.Text))
                MessageBox.Show("Invalid email address.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Account.Instance.CheckEmail(AccountEmailTb.Text))
                MessageBox.Show("This email is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Account.Instance.RegisterAccount(AccountEmailTb.Text, AccountPassTb.Text, AccountTypeCbb.Text, AccountNameTb.Text, AccountPhoneTb.Text);
                MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInfo();
                LoadListAccount();
            }
        }

        private void ClearInfoBtn_Click(object sender, EventArgs e)
        {
            ClearInfo();
        }

        private void DeleteAccountBtn_Click(object sender, EventArgs e)
        {
            if (AccountOldEmail == null) return;
            DialogResult result = MessageBox.Show("Are you sure you want to delete", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Account.Instance.DeleteAcount(AccountEmailTb.Text);
                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListAccount();
                ClearInfo();
            }
        }

        public string AccountOldEmail = null;
        private void ListAccountData_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewRow row = ListAccountData.Rows[e.RowIndex];
            AccountEmailTb.Text = row.Cells[0].Value.ToString();
            AccountPassTb.Text = row.Cells[1].Value.ToString();
            AccountTypeCbb.Text = row.Cells[2].Value.ToString();
            AccountNameTb.Text = row.Cells[3].Value.ToString();
            AccountPhoneTb.Text = row.Cells[4].Value.ToString();

            AccountOldEmail = AccountEmailTb.Text;
        }
    }
}
