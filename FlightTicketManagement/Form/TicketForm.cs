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
            ListFlightData.DataSource = ListFlight;
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
            TicketTypeCbb.SelectedIndex = -1;
            FlightDepatureCbb.SelectedIndex = -1;
            FlightArrivalCbb.SelectedIndex = -1;
        }

        public int FlightPrice = -1;
        private void ListFlightData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewRow row = ListFlightData.Rows[e.RowIndex];
            FlightCodeTb.Text = row.Cells[0].Value.ToString();
            FlightPrice = int.Parse(row.Cells[6].Value.ToString());
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
