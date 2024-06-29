using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketManagement.QuerySQL
{
    public class YearRevenueData
    {
        public YearRevenueData(int Month)
        {
            this.Month = Month;
            this.Flights = 0;
            this.Revenue = 0;
            this.Ratio = 0;
        }

        public int Month { get; set; }
        public int Flights { get; set; }
        public int Revenue { get; set; }
        public float Ratio { get; set; }
    }
}
