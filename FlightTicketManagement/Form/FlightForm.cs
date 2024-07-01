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
            List<FlightData> ListFlight = Flight.Instance.GetListFlight();
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

        public void ClearInfo()
        {
            FlightCodeTb.Text = "";
            DepatureFlightBtn.Text = "Selected";
            ArrivalFlightBtn.Text = "Selected";
            FlightDepatureDatePk.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            FlightDepatureTimePk.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 0, 0);
            FlightDurationTb.Text = "";
            FlightPriceTb.Text = "";
            FlightSeat1Tb.Text = "";
            FlightSeat2Tb.Text = "";

            OldFlightCode = null;
            SelectedDepatureCode = null;
            SelectedArrivalCode = null;
        }

        public bool CheckEmpty()
        {
            if (FlightCodeTb.Text == "" || FlightPriceTb.Text == "" || DepatureFlightBtn.Text == "Selected" || ArrivalFlightBtn.Text == "Selected" || FlightSeat1Tb.Text == "" || FlightSeat2Tb.Text == "" || FlightDurationTb.Text == "")
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool CheckFlightCode()
        {
            if (Flight.Instance.CheckFlightCode(FlightCodeTb.Text))
            {
                MessageBox.Show("This flight code is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public bool IsInteger(string input)
        {
            int result;
            return int.TryParse(input, out result);
        }

        public bool CheckTicketPrice()
        {
            string str = FlightPriceTb.Text;

            if (!IsInteger(str) || int.Parse(str) <= 0)
            {
                MessageBox.Show("The ticket price must be a positive integer.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        public bool CheckNumSeat()
        {
            string seat1 = FlightSeat1Tb.Text;
            string seat2 = FlightSeat2Tb.Text;

            if (!IsInteger(seat1) || int.Parse(seat1) <= 0)
            {
                MessageBox.Show("The number of seats must be a positive integer.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsInteger(seat1) || int.Parse(seat1) <= 0)
            {
                MessageBox.Show("The number of seats must be a positive integer.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool CheckFlightDuration()
        {
            string str = FlightDurationTb.Text;
            if(!IsInteger(str) || int.Parse(str) <= 0) { 
                MessageBox.Show("The flight duration must be a positive number.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            int min = Setting.Instance.GetMinFlightDuration();
            if(int.Parse(str) < min)
            {
                MessageBox.Show("The flight duration must be at least " + min.ToString() +  " minutes.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

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

        public bool CheckFloatField(string str)
        {
            bool IsFloat(string input)
            {
                float result;
                return float.TryParse(input, out result);
            }

            if (!IsFloat(str) || float.Parse(str) <= 0)
                return false;
            return true;
        }

        private void AddFlightBtn_Click(object sender, EventArgs e)
        {
            if (!CheckEmpty() || !CheckFlightCode() || !CheckTicketPrice() || !CheckNumSeat() || !CheckFlightDuration())
                return;
            else
            {
                Flight.Instance.AddFlight(FlightCodeTb.Text, SelectedDepatureCode, SelectedArrivalCode, GetFlightDate(), GetFlightTime(), FlightDurationTb.Text, FlightPriceTb.Text, FlightSeat1Tb.Text, FlightSeat2Tb.Text);
                MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListFlight();
                ClearInfo();
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
            ClearInfo();
        }

        private void DeleteFlightBtn_Click(object sender, EventArgs e)
        {
            if (OldFlightCode == null) return;
            DialogResult result = MessageBox.Show("Are you sure you want to delete", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Flight.Instance.DeleteFlight(FlightCodeTb.Text);
                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListFlight();
                ClearInfo();
            }
        }

        public string OldFlightCode = null;
        private void ListFlightData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.ColumnIndex < 0) { return; }
            DataGridViewRow row = ListFlightData.Rows[e.RowIndex];
            FlightCodeTb.Text = row.Cells[0].Value.ToString();
            DepatureFlightBtn.Text = row.Cells[1].Value.ToString();
            ArrivalFlightBtn.Text = row.Cells[2].Value.ToString();
            FlightDepatureDatePk.Text = row.Cells[3].Value.ToString();
            FlightDepatureTimePk.Text = row.Cells[4].Value.ToString();
            FlightDurationTb.Text = row.Cells[5].Value.ToString();
            FlightPriceTb.Text = row.Cells[6].Value.ToString();
            FlightSeat1Tb.Text = row.Cells[7].Value.ToString();
            FlightSeat2Tb.Text = row.Cells[8].Value.ToString();

            SelectedDepatureCode = Flight.Instance.GetDepatureArrivalCode(FlightCodeTb.Text)[0];
            SelectedArrivalCode = Flight.Instance.GetDepatureArrivalCode(FlightCodeTb.Text)[1];

            OldFlightCode = FlightCodeTb.Text;
        }

        private void UpdateFlightBtn_Click(object sender, EventArgs e)
        {
            if (OldFlightCode == null) return;
            if (!CheckEmpty() || !CheckTicketPrice() || !CheckNumSeat() || !CheckFlightDuration())
                return;
            else if (OldFlightCode != FlightCodeTb.Text && !CheckFlightCode())
                return;
            else
            {
                DialogResult result = MessageBox.Show("Are you want to update", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Flight.Instance.UpdateFlight(FlightCodeTb.Text, OldFlightCode, GetFlightDate(), GetFlightTime(), FlightDurationTb.Text, FlightPriceTb.Text, FlightSeat1Tb.Text, FlightSeat2Tb.Text);
                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListFlight();
                    ClearInfo();
                }
            }
        }

        private void LoadIntermediateForm_Click(object sender, EventArgs e)
        {
            if (OldFlightCode == null) return;
            IntermediateAirportForm IntermediateForm = new IntermediateAirportForm(FlightCodeTb.Text);
            IntermediateForm.ShowDialog();
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
