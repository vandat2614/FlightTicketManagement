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
            string[] setting = Rule.Instance.get_setting();
            MinFlightDurationTb.Text = setting[0];
            MaxIntermediateAirportTb.Text = setting[1];
            MinTimeStopTb.Text = setting[2];
            MaxTimeStopTb.Text = setting[3];
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            load_setting();
        }

        public bool check_empty()
        {
            if (MinFlightDurationTb.Text == "" || MaxIntermediateAirportTb.Text == "" || MinTimeStopTb.Text == "" || MaxTimeStopTb.Text == "")
                return true;
            return false;
        }

        private void UpdateSettingBtn_Click(object sender, EventArgs e)
        {
            if (check_empty())
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult result = MessageBox.Show("Are you want to update", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Rule.Instance.update_setting(MinFlightDurationTb.Text, MaxIntermediateAirportTb.Text, MinTimeStopTb.Text, MaxTimeStopTb.Text);
                    MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_setting();
                }
            }
        }
    }
}
