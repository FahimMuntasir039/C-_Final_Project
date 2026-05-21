using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BloodConnect.UI.Admin
{
    public partial class AdminDashboardHomeForm : Form
    {
        public AdminDashboardHomeForm()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                DataAccess da = new DataAccess();

                int totalUnits = Convert.ToInt32(da.ExecuteScalar(
                    "SELECT ISNULL(SUM(UnitsAvailable), 0) FROM BloodStock"));

                int pendingRequests = Convert.ToInt32(da.ExecuteScalar(
                    "SELECT COUNT(*) FROM BloodRequests WHERE Status = 'Pending'"));

                int totalDonors = Convert.ToInt32(da.ExecuteScalar(
                    "SELECT COUNT(*) FROM Donors"));

                lblTotalUnitsCount.Text = totalUnits.ToString();
                lblPendingRequestsCount.Text = pendingRequests.ToString();
                lblTotalDonorsCount.Text = totalDonors.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dashboard loading error: " + ex.Message);
            }
        }
    }
}
