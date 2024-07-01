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
    public partial class IntermediateAirportForm : Form
    {
        public string selected { get; set; }

        public string FlightCode;
        public IntermediateAirportForm(string FlightCode)
        {
            this.FlightCode = FlightCode;
            InitializeComponent();
        }

        public void LoadListAirport()
        {
            List<IntermediateAirportData> ListData = IntermediateAirport.Instance.GetListIntermediateAirport(this.FlightCode);
            ListIntermediateAirportData.DataSource = ListData;

            ListIntermediateAirportData.Columns["code"].HeaderText = "Flight Code";
            ListIntermediateAirportData.Columns["name"].HeaderText = "Airport";
            ListIntermediateAirportData.Columns["duration"].HeaderText = "Duration";
            ListIntermediateAirportData.Columns["note"].HeaderText = "Note";

        }

        public string SelectedAirportCode = null;
        private void SelectIntermediateAirportBtn_Click(object sender, EventArgs e)
        {
            SelectAirportForm SelectForm = new SelectAirportForm();
            SelectForm.ShowDialog();
            SelectedAirportCode = SelectForm.SelectedCode;
            if (SelectedAirportCode == null)
                SelectIntermediateAirportBtn.Text = "SELECT";
            SelectIntermediateAirportBtn.Text = SelectForm.SelectedName;
        }

        public void ClearInfo()
        {
            SelectedAirportCode = null;
            SelectedId = null;
            SelectIntermediateAirportBtn.Text = "SELECT";
            IntermediateAirportStopTimeTb.Text = "";
            IntermediateAirportNoteTb.Text = "";
        }
        public bool CheckEmpty()
        {
            if (SelectIntermediateAirportBtn.Text.ToLower() == "select" || IntermediateAirportStopTimeTb.Text == "") { 
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool CheckDuration()
        {
            string str = IntermediateAirportStopTimeTb.Text;
            bool IsInt(string input)
            {
                int result;
                return int.TryParse(input, out result);
            }

            if(!IsInt(str) || int.Parse(str) < 0)
            {
                MessageBox.Show("The duration must be a positive number.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            int min = Setting.Instance.GetMinStopTime();
            int max = Setting.Instance.GetMaxStopTime();
            int time = int.Parse(str);
            if(!(min <= time && time <= max))
            {
                MessageBox.Show("The layover time at airports must be from " + min.ToString() + " to " + max.ToString() + " minutes.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool CheckNumIntermediateAirport()
        {
            int num = IntermediateAirport.Instance.GetNumIntermediateAirport(this.FlightCode);
            int max = Setting.Instance.GetMaxIntermediateAirport();
            if (num >= max) {
                MessageBox.Show("The maximum number of intermediate airports is " + max.ToString(), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void AddFlightBtn_Click(object sender, EventArgs e)
        {
            if (!CheckEmpty() || !CheckDuration() || !CheckNumIntermediateAirport())
                return;
            else
            {
                IntermediateAirport.Instance.AddIntermediateAirport(this.FlightCode, SelectedAirportCode, IntermediateAirportStopTimeTb.Text, IntermediateAirportNoteTb.Text);
                MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListAirport();
                ClearInfo();
            }
        }

        private void IntermediateAirportForm_Load(object sender, EventArgs e)
        {
            LoadListAirport();
            ClearInfo();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public string SelectedId = null;
        private void ListIntermediateAirportData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewRow row = ListIntermediateAirportData.Rows[e.RowIndex];
            SelectIntermediateAirportBtn.Text = row.Cells[1].Value.ToString();
            IntermediateAirportStopTimeTb.Text = row.Cells[2].Value.ToString();
            IntermediateAirportNoteTb.Text = row.Cells[3].Value.ToString();
            SelectedAirportCode = IntermediateAirport.Instance.GetAirportCodeByID(row.Cells[0].Value.ToString());
            SelectedId = row.Cells[0].Value.ToString();

        }

        private void IntermediateAirportUpdateBtn_Click(object sender, EventArgs e)
        {
            if (SelectedId == null) return;
            if (!CheckEmpty() || !CheckDuration() || !CheckNumIntermediateAirport())
                return;
            else
            {
                DialogResult result = MessageBox.Show("Are you want to update", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    IntermediateAirport.Instance.UpdateIntermediateAirport(SelectedId, SelectedAirportCode, IntermediateAirportStopTimeTb.Text, IntermediateAirportNoteTb.Text);
                    MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadListAirport();
                    ClearInfo();
                }
            }
        }

        private void IntermediateAirportDeleteBtn_Click(object sender, EventArgs e)
        {
            if (SelectedId == null) return;
            DialogResult result = MessageBox.Show("Are you sure you want to delete", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                IntermediateAirport.Instance.DeleteIntermediateAirport(SelectedId);
                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListAirport();
                ClearInfo();
            }
        }
    }
}
