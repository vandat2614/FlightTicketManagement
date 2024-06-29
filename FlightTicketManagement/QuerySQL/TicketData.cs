using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketManagement.QuerySQL
{
    public class TicketData
    {
        public TicketData(DataRow row) {
            this.code = row["code"].ToString();
            this.flight_code = row["flight_code"].ToString();
            this.name = row["name"].ToString();
            this.cmnd = row["cmnd"].ToString();
            this.phone = row["phone"].ToString();
            this.seat_type = row["seat_type"].ToString();
            this.price = row["price"].ToString();
            this.ticket_type = row["ticket_type"].ToString() ;
        }

        public string code { set; get; }
        public string flight_code { set; get; }
        public string name { set; get; }
        public string cmnd { set; get; }
        public string phone { set; get; }
        public string seat_type { set; get; }

        public string price { set; get; }
        public string ticket_type { set; get; }
    }
}
