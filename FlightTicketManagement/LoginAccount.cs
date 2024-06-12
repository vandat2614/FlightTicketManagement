
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketManagement
{
    public class LoginAccount
    {
        private static LoginAccount instance;
        public static LoginAccount Instance
        {
            get { if (instance == null) instance = new LoginAccount(); return instance; }
            private set { instance = value; }
        }
        private LoginAccount() { }

        public (bool, object) login(string Email, string Password)
        {
            string query = "account_login @email , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {Email, Password});

            object type;
            if (result.Rows.Count == 0)
                type = null;
            else 
                type = result.Rows[0]["Type"];

            return (result.Rows.Count == 1, type);
        }
    }
}
