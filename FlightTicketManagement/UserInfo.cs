using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketManagement
{
    public class UserInfo { 
        public UserInfo(DataRow row) { 
            this.id = row["id"].ToString();
            this.email = row["email"].ToString();
            this.name = row["fullname"].ToString();
            this.type = row["type"].ToString();
            this.password = row["password"].ToString();
            this.phone = row["phonenumber"].ToString();
            this.address = row["address"].ToString();
        }
    
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
    }
}
