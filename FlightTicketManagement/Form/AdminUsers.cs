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
    }
}
