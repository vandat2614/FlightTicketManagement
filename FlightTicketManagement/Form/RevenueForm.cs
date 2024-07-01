using FlightTicketManagement.QuerySQL;
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
    public partial class RevenueForm : Form
    {
        public RevenueForm()
        {
            InitializeComponent();
        }

        public void LoadRevenueByMonth(string month, string year = "")
        {
            List<MonthRevenueData> ListRevenue = Flight.Instance.GetRevenueByMonth(month, year);
            ListRevenueForm.DataSource = ListRevenue;
        }

        public void LoadRevenueByYear(string year)
        {
            if (SelectMonthCbb.SelectedIndex <= 0 && SelectYearCbb.SelectedIndex <= 0) return;
            List<YearRevenueData> ListRevenue = Flight.Instance.GetRevenueByYear(year);
            ListRevenueForm.DataSource = ListRevenue;
        }

        private void RevenueForm_Load(object sender, EventArgs e)
        {
        }

        public void LoadChange()
        {
            if (SelectMonthCbb.SelectedIndex <= 0 && SelectYearCbb.SelectedIndex <= 0)
                ListRevenueForm.Rows.Clear();
            else if (SelectMonthCbb.SelectedIndex <= 0 && SelectYearCbb.SelectedIndex > 0)
                LoadRevenueByYear(SelectYearCbb.Text);
            else if (SelectMonthCbb.SelectedIndex > 0 && SelectYearCbb.SelectedIndex <= 0)
                LoadRevenueByMonth(SelectMonthCbb.Text);
            else LoadRevenueByMonth(SelectMonthCbb.Text, SelectYearCbb.Text);

        }

        private void SelectMonthCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChange();
        }

        private void SelectYearCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChange();
        }
    }
}
