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
            List<IntermediateAirportData> ListData = Flight.Instance.GetListIntermediateAirport(this.FlightCode);
            ListIntermediateAirportData.DataSource = ListData;
        }

        public string SelectedAirportCode = null;
        private void SelectIntermediateAirportBtn_Click(object sender, EventArgs e)
        {
            SelectAirportForm SelectForm = new SelectAirportForm();
            SelectForm.ShowDialog();
            SelectedAirportCode = SelectForm.SelectedCode;
            SelectIntermediateAirportBtn.Text = SelectForm.SelectedName;
        }

        public bool CheckEmpty()
        {
            if (SelectIntermediateAirportBtn.Text.ToLower() == "select" || IntermediateAirportStopTimeTb.Text == "")
                return true;
            return false;
        }

        private void AddFlightBtn_Click(object sender, EventArgs e)
        {
            if(CheckEmpty())
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Flight.Instance.AddIntermediateAirport(this.FlightCode, SelectedAirportCode, IntermediateAirportStopTimeTb.Text, IntermediateAirportNoteTb.Text);
                MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListAirport();
            }
        }

        private void IntermediateAirportForm_Load(object sender, EventArgs e)
        {
            LoadListAirport();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ListIntermediateAirportData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewRow row = ListIntermediateAirportData.Rows[e.RowIndex];
            SelectIntermediateAirportBtn.Text = row.Cells[1].Value.ToString();
            IntermediateAirportStopTimeTb.Text = row.Cells[2].Value.ToString();
            IntermediateAirportNoteTb.Text = row.Cells[3].Value.ToString();
            SelectedAirportCode = Flight.Instance.GetAirportCodeByID(row.Cells[0].Value.ToString());
        }
    }
}
