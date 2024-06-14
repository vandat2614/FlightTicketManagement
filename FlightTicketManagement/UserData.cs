using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketManagement
{
    public class UserData
    {
        private static UserData instance;
        public static UserData Instance
        {
            get { if (instance == null) instance = new UserData(); return instance; }
            private set { instance = value; }
        }
        private UserData() { }

        public List<UserInfo> GetUserData()
        {
            List<UserInfo> result = new List<UserInfo>();

            string query = "select * from account";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            
            foreach(DataRow row in data.Rows)
            {
                UserInfo user = new UserInfo(row);
                result.Add(user);
            }

            return result;
        }

    }
}
