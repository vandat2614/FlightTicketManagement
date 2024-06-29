
using FlightTicketManagement.QuerySQL;
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

        public bool UpdateFlight(string newcode, string oldcode, string date, string time, string duration, string price, string seat1, string seat2)
        {
            string query = "exec update_flight  @newcode , @oldcode , @date , @time , @duration , @price , @seat1 , @seat2";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { newcode, oldcode, date, time, duration, price, seat1, seat2 });
            return result == 1;
        }

        public bool DeleteFlight(string code)
        {
            string query = "exec delete_flight @code";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { code });
            return result == 1;
        }

        public List<string> GetDepatureArrivalCode(string code)
        {
            string query = "exec check_flight @code";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { code });
            return new List<string> { result.Rows[0]["depature"].ToString(), result.Rows[0]["arrival"].ToString() };
        }

        public List<FlightData> GetListFlight()
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

        public List<string> GetListFlightCode()
        {
            List<FlightData> ListFlight = Flight.Instance.GetListFlight();
            List<string> ListFlightName = new List<string> { };
            for (int i = ListFlight.Count-1; i>=0; i--)
            {
                FlightData flight = ListFlight[i];
                ListFlightName.Add(flight.code);
            }

            return ListFlightName;
        }
        public List<FlightData> SearchFlight(string depature, string arrival, string date)
        {
            List<FlightData> result = new List<FlightData>();
            string query = "select * from flight";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                FlightData flight = new FlightData(row);
                if (flight.depature.ToLower() != depature.ToLower() || flight.arrival.ToLower() != arrival.ToLower() || flight.date.ToLower() != date.ToLower())
                    continue;
                result.Add(flight);
            }

            return result;
        }

        public List<MonthRevenueData> GetRevenueByMonth(string month)
        {
            List<MonthRevenueData> result = new List<MonthRevenueData>();
            string query = "select * from flight";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            int sum = 0;
            foreach (DataRow row in data.Rows)
            {
                if (row["date"].ToString().Split('/')[0] == month)
                {
                    string FlightCode = row["code"].ToString();
                    string DepatureAirportName = Airport.Instance.GetAirportName(row["depature"].ToString());
                    string ArrivalAirportName = Airport.Instance.GetAirportName(row["arrival"].ToString());

                    List<TicketData> ListTicket = Ticket.Instance.GetListTicket(FlightCode);

                    int Revenue = 0;
                    foreach (TicketData ticket in ListTicket) Revenue += int.Parse(ticket.price);
                    string NumTicket = ListTicket.Count.ToString();
                    string Ratio = "random";

                    result.Add(new MonthRevenueData(FlightCode, DepatureAirportName, ArrivalAirportName, NumTicket, Revenue.ToString(), Ratio));

                    sum+=Revenue;
                }
            }

            for(int i = 0; i<result.Count(); i++)
            {
                result[i].Ratio = ((1.0 * int.Parse(result[i].Revenue) / sum)).ToString();
            }

            return result;
        }

        public List<YearRevenueData> GetRevenueByYear(string year)
        {
            List<YearRevenueData> result = new List<YearRevenueData>();

            string query = "select * from flight";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count == 0)
                return result;

            for (int i = 1; i<=12; i++)
            {
                YearRevenueData temp = new YearRevenueData(i);
                result.Add(temp);
            }

            foreach (DataRow row in data.Rows)
            {
                if (row["date"].ToString().Split('/')[2] == year)
                {
                    int month = int.Parse(row["date"].ToString().Split('/')[0]);
                    result[month-1].Flights += 1;

                }
            }

            return result;
        }

    }
}
