using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketManagement
{
    public class Setting
    {
        private static Setting instance;
        public static Setting Instance
        {
            get { if (instance == null) instance = new Setting(); return instance; }
            private set { instance = value; }
        }
        private Setting() { }

        public List<string> GetListSetting() {
            string query = "select * from setting";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            DataRow row = data.Rows[0];

            string min_flight_duration = row["min_flight_duration"].ToString(); ;
            string max_intermediate_airport = row["max_intermediate_airport"].ToString(); ;
            string min_stop_time_intermediate_airport = row["min_stop_time_intermediate_airport"].ToString();
            string max_stop_time_intermediate_airport = row["max_stop_time_intermediate_airport"].ToString();
            string latest_time_book_ticket = row["latest_time_book_ticket"].ToString();
            string ticket_cancel_time = row["ticket_cancel_time"].ToString();

            return new List<string> { min_flight_duration, max_intermediate_airport, min_stop_time_intermediate_airport, max_stop_time_intermediate_airport, latest_time_book_ticket, ticket_cancel_time };
        }

        public bool UpdateSetting(string min_flight_duration , string max_intermediate_airport , string min_stop_time_intermediate_airport, string max_stop_time_intermediate_airport, string latest_time_book_ticket, string ticket_cancel_time)
        {
            string query = "exec update_setting  @min_flight_duration , @max_intermediate_airport , @min_stop_time_intermediate_airport , @max_stop_time_intermediate_airport , @latest_time_book_ticket , @ticket_cancel_time";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { min_flight_duration, max_intermediate_airport, min_stop_time_intermediate_airport, max_stop_time_intermediate_airport, latest_time_book_ticket, ticket_cancel_time });
            return result == 1;
        }

        public int GetMinFlightDuration()
        {
            return int.Parse(GetListSetting()[0]);
        }

        public int GetMaxIntermediateAirport()
        {
            return int.Parse(GetListSetting()[1]);

        }

        public int GetMinStopTime()
        {
            return int.Parse(GetListSetting()[2]);

        }

        public int GetMaxStopTime()
        {
            return int.Parse(GetListSetting()[3]);

        }

        public int GetLastTimeBookTicket()
        {
            return int.Parse(GetListSetting()[4]);

        }

        public int GetTicketCancelTime()
        {
            return int.Parse(GetListSetting()[5]);

        }

    }
}
