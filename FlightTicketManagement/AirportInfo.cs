using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketManagement
{
    public class AirportInfo
    {
        public AirportInfo(DataRow row)
        {
            this.id = row["id"].ToString();
            this.code = row["code"].ToString();
            this.name = row["name"].ToString();
            this.city = row["city"].ToString();
        }
        public string id { get; set; }
        public string code { get; set; }
        public string name {  get; set; }
        public string city { get; set; }
    }
}
