using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightTicketManagement
{
    public partial class Admin_FlightForm : Form
    {
        public Admin_FlightForm()
        {
            InitializeComponent();
        }

        public void LoadListFlight()
        {
            List<FlightInfo> flights = Flight.Instance.GetListFlightt();
            ListFlightGv.DataSource = flights;
        }

        private void Admin_FlightForm_Load(object sender, EventArgs e)
        {
            LoadListFlight();
            LoadListAirport();
        }

        public bool CheckEmpty()
        {
            if(FlightCodeTb.Text == "" || FlightPriceTb.Text == "" || FlightDepatureCbb.Text == "" || FlightArrivalCbb.Text == "" || FlightSeat1Tb.Text == "" || FlightSeat2Tb.Text == "")
                return true;
            return false;
        }

        public string getDate()
        {
            return FlightDepatureDatePk.Value.ToString().Split(' ')[0];
        }

        public string getTimeFlight()
        {
            string[] temp = FlightDepatureTimePk.Value.ToString().Split(' ');
            return string.Concat(temp[1], ' ', temp[2]);
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Flight.Instance.check_flight_code(FlightCodeTb.Text))
                MessageBox.Show("This flight code is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Flight.Instance.add_flight(FlightCodeTb.Text, FlightDepatureCbb.Text, FlightArrivalCbb.Text, getDate(), getTimeFlight(), FlightDurationPk.Text, FlightPriceTb.Text, FlightSeat1Tb.Text, FlightSeat2Tb.Text);
                MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListFlight();
            }
        }

        public void LoadListAirport()
        {
            FlightDepatureCbb.Items.Clear();
            FlightArrivalCbb.Items.Clear();
            List<AirportInfo> result = Airport.Instance.GetListAirport();
            foreach(AirportInfo info in result)
            {
                FlightDepatureCbb.Items.Add(info.code);
                FlightArrivalCbb.Items.Add(info.code);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (IsChangeCode)
                MessageBox.Show("This flight code is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult result = MessageBox.Show("Are you want to update", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Flight.Instance.update_flight(FlightCodeTb.Text, FlightDepatureCbb.Text, FlightArrivalCbb.Text, getDate(), getTimeFlight(), FlightDurationPk.Text, FlightPriceTb.Text, FlightSeat1Tb.Text, FlightSeat2Tb.Text);
                    MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListFlight();
                }
            }
        }

        private void ListFlightGv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IsChangeCode = false;
            DataGridViewRow row = ListFlightGv.Rows[e.RowIndex];
            FlightCodeTb.Text = row.Cells[0].Value.ToString();
            FlightDepatureCbb.Text = row.Cells[1].Value.ToString();
            FlightArrivalCbb.Text = row.Cells[2].Value.ToString();
            FlightDepatureDatePk.Text = row.Cells[3].Value.ToString();
            FlightDepatureTimePk.Text = row.Cells[4].Value.ToString();
            FlightDurationPk.Text = row.Cells[5].Value.ToString();
            FlightPriceTb.Text = row.Cells[6].Value.ToString();
            FlightSeat1Tb.Text = row.Cells[7].Value.ToString();
            FlightSeat2Tb.Text = row.Cells[8].Value.ToString();
        }

        public bool IsChangeCode = false;
        private void CodeTb_TextChanged(object sender, EventArgs e)
        {
            IsChangeCode = false;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            IsChangeCode = false;
            FlightCodeTb.Text = "";
            FlightDepatureCbb.Text = "";
            FlightArrivalCbb.Text = "";
            FlightDepatureDatePk.Text = ""; 
            FlightDepatureTimePk.Text = "";
            FlightDurationPk.Text = "";
            FlightPriceTb.Text = "";
            FlightSeat1Tb.Text = "";
            FlightSeat2Tb.Text = "";
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Flight.Instance.delete_flight(FlightCodeTb.Text);
                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListFlight();
            }
        }
    }
}
