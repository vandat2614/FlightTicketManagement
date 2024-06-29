using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketManagement.QuerySQL
{
    public class MonthRevenueData
    {
        public MonthRevenueData(string FlightCode, string DepatureAirportName, string ArrivalAirportName, string NumTicket, string Revenue, string Ratio) { 
            this.FlightCode = FlightCode;
            this.Flight = DepatureAirportName + " to " + ArrivalAirportName;
            this.Tickets = NumTicket;
            this.Revenue = Revenue;
            this.Ratio = Ratio;
        }
        public string FlightCode { get; set; }
        public string Flight { get; set; }
        public string Tickets { get; set; }
        public string Revenue { get; set;}
        public string Ratio { get; set; }
    }
}
