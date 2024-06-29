using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketManagement
{
    public class IntermediateAirport
    {
        private static IntermediateAirport instance;
        public static IntermediateAirport Instance
        {
            get { if (instance == null) instance = new IntermediateAirport(); return instance; }
            private set { instance = value; }
        }
        private IntermediateAirport() { }

        public List<IntermediateAirportData> GetListIntermediateAirport(string FlightCode)
        {
            List<IntermediateAirportData> result = new List<IntermediateAirportData>();
            string query = "exec get_list_intermediate  @flight_code";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { FlightCode });

            foreach (DataRow row in data.Rows)
            {
                IntermediateAirportData temp = new IntermediateAirportData(row);
                result.Add(temp);
            }

            return result;
        }

        public bool AddIntermediateAirport(string flightcode, string airportcode, string duration, string note = "")
        {
            string query = "exec add_intermediate_airport @flight_code , @airport_code , @duration , @note";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { flightcode, airportcode, duration, note });
            return result == 1;
        }
        public string GetAirportCodeByID(string code)
        {
            string query = "exec get_intermediate_info @code";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { code });
            return result.Rows[0]["airport_code"].ToString();
        }

        public bool UpdateIntermediateAirport(string code, string airportcode, string duration, string note = "")
        {
            string query = "exec update_intermediate_airport  @code , @airport_code , @duration , @note";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { code, airportcode, duration, note});
            return result == 1;
        }

        public bool DeleteIntermediateAirport(string code)
        {
            string query = "exec delete_intermediate_airport @code";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { code});
            return result == 1;
        }
    }
}
