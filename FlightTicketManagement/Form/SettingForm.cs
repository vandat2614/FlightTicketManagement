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
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        public void load_setting()
        {
            List<string> ListSetting = Setting.Instance.GetListSetting();
            MinFlightDurationTb.Text = ListSetting[0];
            MaxIntermediateAirportTb.Text = ListSetting[1];
            IntermediateMinTimeStopTb.Text = ListSetting[2];
            IntermediateMaxTimeStopTb.Text = ListSetting[3];
            LatestTimeBookTicketTb.Text = ListSetting[4];
            TicketCancelTimeTb.Text = ListSetting[5];
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            load_setting();
        }

        public bool CheckSetting()
        {
            bool IsInteger(string input)
            {
                int result;
                return int.TryParse(input, out result);
            }

            if (!IsInteger(MinFlightDurationTb.Text) || int.Parse(MinFlightDurationTb.Text) <= 0) return false;
            if (!IsInteger(MaxIntermediateAirportTb.Text) || int.Parse(MaxIntermediateAirportTb.Text) <= 0) return false;
            if (!IsInteger(IntermediateMinTimeStopTb.Text) || int.Parse(IntermediateMinTimeStopTb.Text) <= 0) return false;
            if (!IsInteger(IntermediateMaxTimeStopTb.Text) || int.Parse(IntermediateMaxTimeStopTb.Text) <= 0) return false;
            if (!IsInteger(LatestTimeBookTicketTb.Text) || int.Parse(LatestTimeBookTicketTb.Text) <= 0) return false;
            if (!IsInteger(TicketCancelTimeTb.Text) || int.Parse(TicketCancelTimeTb.Text) <= 0) return false;

            return true;
        }

        private void UpdateSettingBtn_Click(object sender, EventArgs e)
        {
            bool check_empty()
            {
                if (MinFlightDurationTb.Text == "" || MaxIntermediateAirportTb.Text == "" || IntermediateMinTimeStopTb.Text == "" || IntermediateMaxTimeStopTb.Text == "" || LatestTimeBookTicketTb.Text == "" || TicketCancelTimeTb.Text == "")
                    return true;
                return false;
            }

            if (check_empty())
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(!CheckSetting())
                MessageBox.Show("All fields must be in numeric format and positive.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult result = MessageBox.Show("Are you want to update", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Setting.Instance.UpdateSetting(MinFlightDurationTb.Text, MaxIntermediateAirportTb.Text, IntermediateMinTimeStopTb.Text, IntermediateMaxTimeStopTb.Text, LatestTimeBookTicketTb.Text, TicketCancelTimeTb.Text);
                    MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_setting();
                }
            }
        }
    }
}
