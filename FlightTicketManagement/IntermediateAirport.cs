using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketManagement
{
    public class IntermediateAirport
    {
        private static IntermediateAirport instance;
        public static IntermediateAirport Instance
        {
            get { if (instance == null) instance = new IntermediateAirport(); return instance; }
            private set { instance = value; }
        }
        private IntermediateAirport() { }
    }
}
