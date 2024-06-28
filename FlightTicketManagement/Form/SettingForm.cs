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

        public bool check_empty()
        {
            if (MinFlightDurationTb.Text == "" || MaxIntermediateAirportTb.Text == "" || IntermediateMinTimeStopTb.Text == "" || IntermediateMaxTimeStopTb.Text == "" || LatestTimeBookTicketTb.Text == "" || TicketCancelTimeTb.Text == "")
                return true;
            return false;
        }
        public bool IsInteger(string input)
        {
            int result;
            return int.TryParse(input, out result);
        }


        private void UpdateSettingBtn_Click(object sender, EventArgs e)
        {
            if (check_empty())
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!IsInteger(MinFlightDurationTb.Text) || !IsInteger(MaxIntermediateAirportTb.Text) || !IsInteger(IntermediateMinTimeStopTb.Text) || !IsInteger(IntermediateMaxTimeStopTb.Text) || !IsInteger(LatestTimeBookTicketTb.Text) || !IsInteger(TicketCancelTimeTb.Text))
                MessageBox.Show("All fields must be in numeric format", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
