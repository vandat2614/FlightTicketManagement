using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketManagement.QuerySQL
{
    public class Ticket
    {
        private static Ticket instance;
        public static Ticket Instance
        {
            get { if (instance == null) instance = new Ticket(); return instance; }
            private set { instance = value; }
        }
        private Ticket() { }

        public bool AddTicket(string flightcode, string name, string cmnd, string phone, string seat_type, string price, string ticket_type)
        {
            string query = "exec add_ticket @flight_code , @name , @cmnd , @phone , @seat_type , @price , @ticket_type";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { flightcode, name, cmnd, phone, seat_type, price, ticket_type});
            return result == 1;
        }

        public bool UpdateTicket(string code, string name, string cmnd, string phone, string seat_type, string price, string ticket_type)
        {
            string query = "exec update_ticket  @code , @name , @cmnd , @phone , @seat_type , @price , @ticket_type";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { code, name, cmnd, phone, seat_type, price, ticket_type });
            return result == 1;
        }

        public bool DeleteTicket(string code)
        {
            string query = "exec delete_ticket @code";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { code });
            return result == 1;
        }

        public List<TicketData> GetListTicket(string flightcode="")
        {
            List<TicketData> result = new List<TicketData>();
            string query = "select * from ticket";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                TicketData ticket = new TicketData(row);
                if(flightcode == "" || ticket.flight_code == flightcode)
                    result.Add(ticket);
            }

            return result;
        }

    }
}
