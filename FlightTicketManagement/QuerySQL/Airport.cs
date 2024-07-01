
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public string GetAirportName(string code)
        {
            string query = "exec check_airport @code";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { code });
            return result.Rows[0]["name"].ToString();
        }

        public string GetAirportCode(string name)
        {
            string query = "exec check_airport @code";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { name });
            return result.Rows[0]["code"].ToString();
        }

        public bool IsUsed(string airportcode)
        {
            List<FlightData> result = new List<FlightData>();
            string query = "select * from flight";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                if (row["depature"].ToString() == airportcode || row["arrival"].ToString() == airportcode)
                    return true;
            }
            return false;
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

        public List<string> GetListAirportName()
        {
            List<AirportData> ListAirport = Airport.Instance.GetListAirport();
            List<string> ListAirportName = new List<string> { };
            for (int i = ListAirport.Count-1; i>=0; i--)
            {
                AirportData airport = ListAirport[i];
                ListAirportName.Add(airport.name);
            }

            return ListAirportName;
        }

    }
}
