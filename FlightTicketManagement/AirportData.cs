using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketManagement
{
    public class AirportData
    {
        public AirportData(DataRow row)
        {
            this.code = row["code"].ToString();
            this.name = row["name"].ToString();
            this.city = row["city"].ToString();
            this.status = row["status"].ToString();
            this.note = row["note"].ToString();

        }
        public string code { get; set; }
        public string name {  get; set; }
        public string city { get; set; }
        public string status { get; set; }
        public string note { get; set; }
    }
}
