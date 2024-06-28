using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketManagement
{
    public class IntermediateAirportData
    {
        public IntermediateAirportData(DataRow row)
        {
            this.code = row["code"].ToString();
            this.name = Airport.Instance.GetAirportName(row["airport_code"].ToString());
            this.duration = row["duration"].ToString();
            this.note = row["note"].ToString();
        }

        public string code { get; set; }
        public string name { get; set; }
        public string duration { get; set; }
        public string note { get; set; }
    }
}