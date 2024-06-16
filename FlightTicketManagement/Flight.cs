
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

        public bool add_flight(string code, string start, string destination, string datetime, string time, string price, string seat1, string seat2)
        {
            string query = "exec add_flight @code , @start , @destination , @datetime , @time , @price , @seat1 , @seat2";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { code, start, destination, datetime, time, price, seat1, seat2 });
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
