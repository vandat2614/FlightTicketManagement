﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketManagement
{
    public class FlightInfo
    {
        public FlightInfo(DataRow row)
        {
            this.code = row["code"].ToString();
            this.start = row["start"].ToString();
            this.dest = row["dest"].ToString();
            this.date = row["date"].ToString() ;
            this.time = row["time"].ToString() ;
            this.duration = row["duration"].ToString() ;
            this.price = row["price"].ToString();
            this.seat1 = row["seat1"].ToString();
            this.seat2=row["seat2"].ToString();
        }
        public string code { get; set; }
        public string start { get; set; }
        public string dest { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string duration { get; set; }
        public string price { get; set; }
        public string seat1 { get; set; }
        public string seat2 { get; set;
        }

    }
}
