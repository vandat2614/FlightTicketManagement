
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

        public bool AddAirport(string Code, string Name, string City, string Status, string Note)
        {
            string query = "exec add_airport @code , @name , @city , @status , @note";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { Code, Name, City, Status, Note });
            return result == 1;
        }

        public bool UpdateAirport(string NewCode, string OldCode, string Name, string City, string Status, string Note)
        {
            string query = "exec update_airport  @newcode , @oldcode , @name , @city , @status , @note";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { NewCode, OldCode, Name, City, Status, Note });
            return result == 1;
        }

        public bool DeleteAirport(string code)
        {
            string query = "exec delete_airport @code";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { code });
            return result == 1;
        }

        public bool CheckAirport(string code)
        {
            string query = "exec check_airport @code";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { code });
            return result.Rows.Count > 0;
        }

        public List<AirportData> GetListAirport()
        {
            List<AirportData> result = new List<AirportData>();
            string query = "select * from airport";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                AirportData airport = new AirportData(row);
                result.Add(airport);
            }

            return result;
        }

    }
}
