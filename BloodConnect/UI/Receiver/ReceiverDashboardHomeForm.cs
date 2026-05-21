using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BloodConnect.UI.Receiver
{
    public partial class ReceiverDashboardHomeForm : Form
    {
        public ReceiverDashboardHomeForm(int userId, string fullName)
        {
            InitializeComponent();
            lblTitle.Text = "Welcome, " + fullName;
            LoadStats(userId);
        }

        private void LoadStats(int userId)
        {
            try
            {
                DataAccess da = new DataAccess();
                int requests = Convert.ToInt32(da.ExecuteScalar(
                    "SELECT COUNT(*) FROM BloodRequests WHERE UserID = @userId",
                    new[] { new SqlParameter("@userId", userId) }));
                int pending = Convert.ToInt32(da.ExecuteScalar(
                    "SELECT COUNT(*) FROM BloodRequests WHERE UserID = @userId AND Status = 'Pending'",
                    new[] { new SqlParameter("@userId", userId) }));
                int stock = Convert.ToInt32(da.ExecuteScalar("SELECT COUNT(*) FROM BloodStock WHERE UnitsAvailable > 0"));
                lblRequestsCount.Text = requests.ToString();
                lblPendingCount.Text = pending.ToString();
                lblStockCount.Text = stock.ToString();
            }
            catch (Exception ex) { MessageBox.Show("Dashboard error: " + ex.Message); }
        }
    }
}
