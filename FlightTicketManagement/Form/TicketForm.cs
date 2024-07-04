using FlightTicketManagement.QuerySQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightTicketManagement
{
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        public void LoadListAirportName()
        {

            FlightDepatureCbb.Items.Clear();
            FlightDepatureCbb.DataSource = Airport.Instance.GetListAirportName();

            FlightArrivalCbb.Items.Clear();
            FlightArrivalCbb.DataSource = Airport.Instance.GetListAirportName();
        }

        public void LoadListFlight(List<FlightData> ListFlight)
        {
            for(int i=0;i<ListFlight.Count;i++)
            {
                FlightData flight = ListFlight[i];
                if (flight.emptyseat == "0")
                {
                    ListFlight.RemoveAt(i);
                    i--;
                }
            }

            ListFlightData.DataSource = ListFlight;

            ListFlightData.Columns["code"].HeaderText = "Flight Code";
            ListFlightData.Columns["depature"].HeaderText = "Depature";
            ListFlightData.Columns["arrival"].HeaderText = "Arrival";
            ListFlightData.Columns["date"].HeaderText = "Flight Date";
            ListFlightData.Columns["time"].HeaderText = "Time";
            ListFlightData.Columns["duration"].HeaderText = "Duration";

            ListFlightData.Columns["price"].HeaderText = "Price";
            ListFlightData.Columns["seat1"].HeaderText = "Seat1";
            ListFlightData.Columns["seat2"].HeaderText = "Seat2";

            ListFlightData.Columns["emptyseat"].HeaderText = "Empty Seat";
            ListFlightData.Columns["orderseat"].HeaderText = "Order";
            ListFlightData.Columns["buyseat"].HeaderText = "Buy";
        }

        private void SearchFlightBtn_Click(object sender, EventArgs e)
        {
            bool check()
            {
                if (FlightDepatureCbb.SelectedIndex == -1 || FlightArrivalCbb.SelectedIndex == -1)
                    return true;
                return false;
            }

            if (check())
                MessageBox.Show("You need to choose a departure and a destination.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                LoadListFlight(Flight.Instance.SearchFlight(FlightDepatureCbb.Text, FlightArrivalCbb.Text, GetFlightDate()));
            }
        }

        public string GetFlightDate()
        {
            return FlightDatePk.Value.ToString().Split(' ')[0];
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            LoadListAirportName();
            ClearInfo();
        }

        public int FlightPrice = -1;
        string FlightDate = null;
        private void ListFlightData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewRow row = ListFlightData.Rows[e.RowIndex];
            FlightCodeTb.Text = row.Cells[0].Value.ToString();
            FlightPrice = int.Parse(row.Cells[6].Value.ToString());
            FlightDate = row.Cells[3].Value.ToString();
            TicketTypeCbb.Enabled = true;
        }

        public void UpdatePrice()
        {
            if (FlightPrice == -1) return;

            if (TicketTypeCbb.SelectedIndex == 0)
                TicketPriceTb.Text = (FlightPrice * 1.05).ToString();
            else TicketPriceTb.Text = FlightPrice.ToString();
        }

        private void TicketTypeCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePrice();  
        }

        public void AddTicket(string ticket_type) {
            if (FlightCodeTb.Text == "") return;
            if (!CheckDate()){
                MessageBox.Show("Too late to book/buy tickets", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool check()
            {
                if (FlightCodeTb.Text == "" || CustomerNameTb.Text == "" || CMNDTb.Text == "" || CustomerPhoneTb.Text == "" || TicketTypeCbb.SelectedIndex == -1 || TicketPriceTb.Text == "")
                    return true;
                return false;
            }

            if (check())
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Ticket.Instance.AddTicket(FlightCodeTb.Text, CustomerNameTb.Text, CMNDTb.Text, CustomerPhoneTb.Text, TicketTypeCbb.Text, TicketPriceTb.Text, ticket_type);
                MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInfo();
            }
        }

        public void ClearInfo()
        {
            FlightCodeTb.Text = "";
            CustomerNameTb.Text = "";
            CMNDTb.Text = "";
            CustomerPhoneTb.Text = "";
            TicketTypeCbb.SelectedIndex = -1;
            TicketPriceTb.Text = "";
            FlightDepatureCbb.SelectedIndex = -1;
            FlightArrivalCbb.SelectedIndex = -1;
            FlightDatePk.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            FlightPrice = -1;
            TicketTypeCbb.Enabled = false;
            FlightDate = null;

        }

        public bool CheckDate()
        {
            DateTime currentDate = DateTime.Today;
            DateTime dateCheck = DateTime.Parse(FlightDate);

            string today = currentDate.ToString().Split(' ')[0];
            string flightdate = dateCheck.ToString().Split(' ')[0];

            DateTime Dtoday = DateTime.ParseExact(today, "M/d/yyyy", null);
            DateTime Dflightdate = DateTime.ParseExact(flightdate, "M/d/yyyy", null);

            int diff = Math.Abs((Dtoday - Dflightdate).Days);

            if (DateTime.Compare(Dtoday, Dflightdate) >= 0 || diff < Setting.Instance.GetLastTimeBookTicket())
                return false;
            return true;
        }

        private void AddTicketBtn_Click(object sender, EventArgs e)
        {
            AddTicket("buy");
        }

        private void BookTicketBtn_Click(object sender, EventArgs e)
        {
            AddTicket("book");
        }
    }
}
