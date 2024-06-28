
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
    public class Flight
    {
        private static Flight instance;
        public static Flight Instance
        {
            get { if (instance == null) instance = new Flight(); return instance; }
            private set { instance = value; }
        }
        private Flight() { }

        public bool CheckFlightCode(string Code)
        {
            string query = "exec check_flight @code";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { Code });
            return result.Rows.Count > 0;
        }

        public bool AddFlight(string code, string depature, string arrival, string date, string time, string duration, string price, string seat1, string seat2)
        {
            string query = "exec add_flight @code , @depature , @arrival , @date , @time , @duration , @price , @seat1 , @seat2";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { code, depature, arrival, date, time, duration, price, seat1, seat2 });
            return result == 1;
        }

        public bool UpdateFlight(string code, string start, string dest, string date, string time, string duration, string price, string seat1, string seat2)
        {
            string query = "exec update_flight  @code , @start , @dest , @date , @time , @duration , @price , @seat1 , @seat2";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { code, start, dest, date, time, duration, price, seat1, seat2 });
            return result == 1;
        }

        public bool DeleteFlight(string code)
        {
            string query = "exec delete_flight @code";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { code });
            return result == 1;
        }

        public List<FlightData> GetListFlightt()
        {
            List<FlightData> result = new List<FlightData>();
            string query = "select * from flight";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                FlightData flight = new FlightData(row);
                result.Add(flight);
            }

            return result;
        }
    }
}
