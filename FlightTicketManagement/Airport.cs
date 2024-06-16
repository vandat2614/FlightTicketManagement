
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FlightTicketManagement
{
    public class Airport
    {
        private static Airport instance;
        public static Airport Instance
        {
            get { if (instance == null) instance = new Airport(); return instance; }
            private set { instance = value; }
        }
        private Airport() { }

        public bool add_airport(string code, string name, string city)
        {
            string query = "exec add_airport @code , @name , @city";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { code, name, city });
            return result == 1;
        }

        public bool update_airport(string id, string code, string name, string city)
        {
            string query = "exec update_airport @id , @code , @name , @city";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, code, name, city});
            return result == 1;
        }

        public bool delete_airport(string id)
        {
            string query = "exec delete_airport @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result == 1;
        }

        public bool check_aiport_code(string code)
        {
            string query = "exec check_airport @code";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { code });
            return result.Rows.Count > 0;
        }

        public List<AirportInfo> GetListAirport()
        {
            List<AirportInfo> result = new List<AirportInfo>();
            string query = "select * from airport";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                AirportInfo airport = new AirportInfo(row);
                result.Add(airport);
            }

            return result;
        }

    }
}
