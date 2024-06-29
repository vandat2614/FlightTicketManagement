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
        }

        public string SelectedAirportCode = null;
        private void SelectIntermediateAirportBtn_Click(object sender, EventArgs e)
        {
            SelectAirportForm SelectForm = new SelectAirportForm();
            SelectForm.ShowDialog();
            SelectedAirportCode = SelectForm.SelectedCode;
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
                IntermediateAirport.Instance.AddIntermediateAirport(this.FlightCode, SelectedAirportCode, IntermediateAirportStopTimeTb.Text, IntermediateAirportNoteTb.Text);
                MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListAirport();
                ClearInfo();
                SelectedAirportCode = null;
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
            if(CheckEmpty())
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult result = MessageBox.Show("Are you want to update", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
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
