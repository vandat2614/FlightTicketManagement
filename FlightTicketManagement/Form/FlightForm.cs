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
    public partial class FlightForm : Form
    {
        public FlightForm()
        {
            InitializeComponent();
        }

        public void LoadListFlight()
        {
            List<FlightData> ListFlight = Flight.Instance.GetListFlightt();
            ListFlightData.DataSource = ListFlight;
        }


        public void ClearInfo()
        {
            FlightCodeTb.Text = "";
            DepatureFlightBtn.Text = "Selected";
            ArrivalFlightBtn.Text = "Selected";
            FlightDepatureDatePk.Text = "";
            FlightDepatureTimePk.Text = "";
            FlightDurationTb.Text = "";
            FlightPriceTb.Text = "";
            FlightSeat1Tb.Text = "";
            FlightSeat2Tb.Text = "";
        }

        public bool CheckEmpty()
        {
            if (FlightCodeTb.Text == "" || FlightPriceTb.Text == "" || DepatureFlightBtn.Text == "Selected" || ArrivalFlightBtn.Text == "Selected" || FlightSeat1Tb.Text == "" || FlightSeat2Tb.Text == "" || FlightDurationTb.Text == "")
                return true;
            return false;
        }

        public string GetFlightDate()
        {
            return FlightDepatureDatePk.Value.ToString().Split(' ')[0];
        }

        public string GetFlightTime()
        {
            string[] temp = FlightDepatureTimePk.Value.ToString().Split(' ');
            return string.Concat(temp[1], ' ', temp[2]);
        }

        private void AddFlightBtn_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Flight.Instance.CheckFlightCode(FlightCodeTb.Text))
                MessageBox.Show("This flight code is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Flight.Instance.AddFlight(FlightCodeTb.Text, SelectedDepatureCode, SelectedArrivalCode, GetFlightDate(), GetFlightTime(), FlightDurationTb.Text, FlightPriceTb.Text, FlightSeat1Tb.Text, FlightSeat2Tb.Text);
                MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public string SelectedDepatureCode = null, SelectedArrivalCode = null;
        private void ArrivalFlightBtn_Click(object sender, EventArgs e)
        {
            SelectAirportForm SelectForm = new SelectAirportForm();
            SelectForm.ShowDialog();
            if (SelectForm.SelectedCode != null)
            {
                SelectedArrivalCode = SelectForm.SelectedCode;
                ArrivalFlightBtn.Text = SelectForm.SelectedName;
            }
        }

        private void ClearInfoBtn_Click(object sender, EventArgs e)
        {
            ClearInfo();
        }

        private void Admin_FlightForm_Load(object sender, EventArgs e)
        {
            LoadListFlight();
        }

        private void DeleteFlightBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Flight.Instance.DeleteFlight(FlightCodeTb.Text);
                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ListFlightData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.ColumnIndex < 0) { return; }
            DataGridViewRow row = ListFlightData.Rows[e.RowIndex];
            FlightCodeTb.Text = row.Cells[0].Value.ToString();
            DepatureFlightBtn.Text = row.Cells[1].Value.ToString();
            ArrivalFlightBtn.Text = row.Cells[2].Value.ToString();
        /*    FlightDepatureDatePk. = row.Cells[3].Value.ToString();
            FlightDepatureTimePk.Text = row.Cells[4].Value.ToString();*/
            FlightDurationTb.Text = row.Cells[5].Value.ToString();
            FlightPriceTb.Text = row.Cells[6].Value.ToString();
            FlightSeat1Tb.Text = row.Cells[7].Value.ToString();
            FlightSeat2Tb.Text = row.Cells[8].Value.ToString();
        }

        private void DepatureFlightBtn_Click(object sender, EventArgs e)
        {
            SelectAirportForm SelectForm = new SelectAirportForm();
            SelectForm.ShowDialog();
            if (SelectForm.SelectedCode != null)
            {
                SelectedDepatureCode = SelectForm.SelectedCode;
                DepatureFlightBtn.Text = SelectForm.SelectedName;
            }
        }
    }
}
