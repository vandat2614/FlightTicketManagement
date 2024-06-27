using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketManagement
{
    public class AccountData { 
        public AccountData(DataRow row) { 
            this.email = row["email"].ToString();
            this.pass = row["pass"].ToString();
            this.name = row["name"].ToString();
            this.type = row["type"].ToString();
            this.phone = row["phone"].ToString();
        }
        public string email { get; set; }
        public string pass { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
    }
}
