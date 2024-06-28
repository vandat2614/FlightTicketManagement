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
    public partial class ListAirportForm : Form
    {
        public ListAirportForm()
        {
            InitializeComponent();
        }

        public bool CheckEmpty()
        {
            if (AirportNameTb.Text == "" || AirportCityCbb.SelectedIndex == -1 || AirportCodeTb.Text == "" || AirportStatusCbb.SelectedIndex == -1)
                return true;
            return false;
        }

        public void ClearInfo()
        {
            AirportCodeTb.Text = "";
            AirportNameTb.Text = "";
            AirportCityCbb.SelectedIndex = -1;
            AirportStatusCbb.SelectedIndex = -1;
            AirportNoteTb.Text = "";
        }

        public void LoadListAirport()
        {
            List<AirportData> airports = Airport.Instance.GetListAirport();
            ListAirportData.DataSource = airports;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Airport.Instance.CheckAirport(AirportCodeTb.Text))
                    MessageBox.Show("This airport code is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Airport.Instance.AddAirport(AirportCodeTb.Text, AirportNameTb.Text, AirportCityCbb.Text, AirportStatusCbb.Text, AirportNoteTb.Text);
                MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListAirport();
                OldAiportCode = null;
            }

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (OldAiportCode != null && OldAiportCode != AirportCodeTb.Text && Airport.Instance.CheckAirport(AirportCodeTb.Text))
                MessageBox.Show("This airport code is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string Notification;
                if (OldAiportCode == null)
                    Notification = "You haven't selected the airport to update information, do you want to add this airport?";
                else Notification = "Are you want to update";

                DialogResult result = MessageBox.Show(Notification, "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (OldAiportCode == null)
                    {
                        if (Airport.Instance.CheckAirport(AirportCodeTb.Text))
                            MessageBox.Show("This airport code is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            Airport.Instance.AddAirport(AirportCodeTb.Text, AirportNameTb.Text, AirportCityCbb.Text, AirportStatusCbb.Text, AirportNoteTb.Text);
                            MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        Airport.Instance.UpdateAirport(AirportCodeTb.Text, OldAiportCode, AirportNameTb.Text, AirportCityCbb.Text, AirportStatusCbb.Text, AirportNoteTb.Text);
                        MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                OldAiportCode = null;
                LoadListAirport();
                ClearInfo();
            }
        }

        public string OldAiportCode = null;
        private void ListAirportGv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewRow row = ListAirportData.Rows[e.RowIndex];
            AirportCodeTb.Text = row.Cells[0].Value.ToString();
            AirportNameTb.Text = row.Cells[1].Value.ToString();
            AirportCityCbb.Text = row.Cells[2].Value.ToString();
            AirportStatusCbb.Text = row.Cells[3].Value.ToString();
            AirportNoteTb.Text = row.Cells[4].Value.ToString();
            OldAiportCode = AirportCodeTb.Text;
        }

        private void Admin_AirportForm_Load(object sender, EventArgs e)
        {
            LoadListAirport();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearInfo();
            OldAiportCode = null;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Airport.Instance.DeleteAirport(AirportCodeTb.Text);
                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListAirport();
                OldAiportCode = null;
            }
        }
    }
}
