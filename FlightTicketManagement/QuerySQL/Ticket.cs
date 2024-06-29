using System;
using System.Collections.Generic;
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

        public bool AddTicket(string flightcode, string name, string cmnd, string phone, string type, string price)
        {
            string query = "exec add_ticket @flight_code , @name , @cmnd , @phone , @type , @price";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { flightcode, name, cmnd, phone, type, price});
            return result == 1;
        }
    }
}
