
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FlightTicketManagement
{
    public class Rule
    {
        private static Rule instance;
        public static Rule Instance
        {
            get { if (instance == null) instance = new Rule(); return instance; }
            private set { instance = value; }
        }
        private Rule() { }

        public string[] get_setting()
        {
            string query = "select * from AirportRule";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            string minFlightDuration = null, maxIntermediateAirport = null, minIntermediateAirportStop = null, maxIntermediateAiportStop = null;
            foreach (DataRow row in data.Rows)
            {
                minFlightDuration = row["minFlightDuration"].ToString();
                maxIntermediateAirport = row["maxIntermediateAirport"].ToString();
                minIntermediateAirportStop = row["minIntermediateAirportStop"].ToString();
                maxIntermediateAiportStop = row["maxIntermediateAiportStop"].ToString();
            }

            return new string[] { minFlightDuration, maxIntermediateAirport, minIntermediateAirportStop, maxIntermediateAiportStop };
        }

        public bool update_setting(string minFlightDuration, string maxIntermediateAirport, string minIntermediateAirportStop, string maxIntermediateAiportStop)
        {
            string query = "exec update_rule @minFlightDuration , @maxIntermediateAirport , @minIntermediateAirportStop , @maxIntermediateAiportStop";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { minFlightDuration, maxIntermediateAirport, minIntermediateAirportStop, maxIntermediateAiportStop });
            return result == 1;
        }


    }
}
