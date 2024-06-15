
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

        public bool login(string Email, string Password)
        {
            string query = "account_login @email , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { Email, Password });
            return result.Rows.Count == 1;
        }

        public object getType(string email)
        {
            string query = "exec check_email @email";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { email });

            return result.Rows[0]["Type"];
        }

        public bool check_email(string Email)
        {
            string query = "exec check_email @email";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { Email });
            return result.Rows.Count > 0;
        }

        public bool add_account(string Email, string Password)
        {
            string query = "exec add_account @email , @password";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { Email, Password });
            return result == 1;
        }

        public bool add_acoount_full(string Email, string Password, string name, string role, string phone)
        {
            string query = "exec add_account_full @email , @password , @name , @type , @phone";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { Email, Password, name, role, phone });
            return result == 1;
        }

        public bool update_account(string id, string Email, string Password, string name, string role, string phone)
        {
            string query = "exec update_account @id , @email , @password , @name , @type , @phone";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, Email, Password, name, role, phone });
            return result == 1;
        }

        public bool delete_account(string id)
        {
            string query = "exec delete_account @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
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
