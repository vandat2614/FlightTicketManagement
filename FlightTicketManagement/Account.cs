
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FlightTicketManagement
{
    public class Account
    {
        private static Account instance;
        public static Account Instance
        {
            get { if (instance == null) instance = new Account(); return instance; }
            private set { instance = value; }
        }
        private Account() { }

        public bool check_account(string Email, string Password)
        {
            string query = "exec check_account @email , @pass";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { Email, Password });
            return result.Rows.Count == 1;
        }

        public object get_account_type(string email)
        {
            string query = "exec check_email @email";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { email });

            return result.Rows[0]["type"];
        }

        public bool check_email(string Email)
        {
            string query = "exec check_email @email";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { Email });
            return result.Rows.Count > 0;
        }

        public bool register_account(string Email, string Password)
        {
            string query = "exec register_account @email , @pass";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { Email, Password });
            return result == 1;
        }

        public bool add_account(string Email, string Password, string type, string name, string phone)
        {
            string query = "exec add_account @email , @pass , @type , @name , @phone";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { Email, Password, type, name, phone });
            return result == 1;
        }

        public bool update_account(string NewEmail, string OldEmail, string Password, string name, string type, string phone)
        {
            string query = "exec update_account @newemail , @oldemail , @pass , @name , @type , @phone";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { NewEmail, OldEmail, Password, name, type, phone });
            return result == 1;
        }

        public bool delete_account(string email)
        {
            string query = "exec delete_account @email";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { email });
            return result == 1;
        }

        public List<UserInfo> GetListAccount()
        {
            List<UserInfo> result = new List<UserInfo>();
            string query = "select * from account";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                UserInfo user = new UserInfo(row);
                result.Add(user);
            }

            return result;
        }
    }
}
