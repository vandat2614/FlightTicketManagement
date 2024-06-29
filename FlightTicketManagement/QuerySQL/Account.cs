
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

        public bool CheckAccount(string Email, string Password)
        {
            string query = "exec check_account @email , @pass";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { Email, Password });
            return result.Rows.Count == 1;
        }

        public string GetAccountType(string Email)
        {
            string query = "exec check_email @email";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { Email });

            return result.Rows[0]["type"].ToString().ToLower();
        }

        public bool CheckEmail(string Email)
        {
            string query = "exec check_email @email";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { Email });
            return result.Rows.Count > 0;
        }

        public bool RegisterAccount(string Email, string Password, string Type = "customer", string Name = "", string Phone = "")
        {
            string query = "exec register_account @email , @pass , @type , @name , @phone";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { Email, Password , Type, Name, Phone});
            return result == 1;
        }

        public bool UpdateAccount(string NewEmail, string OldEmail, string Password, string Name, string Type, string Phone)
        {
            string query = "exec update_account @newemail , @oldemail , @pass , @name , @type , @phone";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { NewEmail, OldEmail, Password, Name, Type, Phone });
            return result == 1;
        }

        public bool DeleteAcount(string Email)
        {
            string query = "exec delete_account @email";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { Email });
            return result == 1;
        }

        public List<AccountData> GetListAccount()
        {
            List<AccountData> ListAccount = new List<AccountData>();
            string query = "select * from account";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                AccountData user = new AccountData(row);
                ListAccount.Add(user);
            }

            return ListAccount;
        }
    }
}
