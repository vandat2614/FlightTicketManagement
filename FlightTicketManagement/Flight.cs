
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public bool check_flight_code(string code)
        {
            string query = "exec check_flight @code";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { code });
            return result.Rows.Count > 0;
        }

        public bool add_flight(string code, string start, string dest, string date, string time, string duration, string price, string seat1, string seat2)
        {
            string query = "exec add_flight @code , @start , @dest , @date , @time , @duration , @price , @seat1 , @seat2";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { code, start, dest, date, time, duration, price, seat1, seat2 });
            return result == 1;
        }

        public bool update_flight(string code, string start, string dest, string date, string time, string duration, string price, string seat1, string seat2)
        {
            string query = "exec update_flight  @code , @start , @dest , @date , @time , @duration , @price , @seat1 , @seat2";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { code, start, dest, date, time, duration, price, seat1, seat2 });
            return result == 1;
        }

        public bool delete_flight(string code)
        {
            string query = "exec delete_flight @code";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { code });
            return result == 1;
        }

        public List<FlightInfo> GetListFlightt()
        {
            List<FlightInfo> result = new List<FlightInfo>();
            string query = "select * from flight";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                FlightInfo flight = new FlightInfo(row);
                result.Add(flight);
            }

            return result;
        }

    }
}
