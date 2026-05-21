using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BloodConnect.UI.Donor
{
    public partial class DonorDashboardHomeForm : Form
    {
        public DonorDashboardHomeForm(int userId, string fullName)
        {
            InitializeComponent();
            lblTitle.Text = "Welcome, " + fullName;
            lblSubtitle.Text = "Blood Donor Dashboard";
            LoadStats(userId);
        }

        private void LoadStats(int userId)
        {
            try
            {
                DataAccess da = new DataAccess();
                int donations = Convert.ToInt32(da.ExecuteScalar(
                    @"SELECT COUNT(*) FROM Donations dn
                      INNER JOIN Donors d ON dn.DonorID = d.ID WHERE d.UserID = @userId",
                    new[] { new SqlParameter("@userId", userId) }));

                int appointments = Convert.ToInt32(da.ExecuteScalar(
                    @"SELECT COUNT(*) FROM DonationAppointments ap
                      INNER JOIN Donors d ON ap.DonorID = d.ID WHERE d.UserID = @userId",
                    new[] { new SqlParameter("@userId", userId) }));

                object lastDonation = da.ExecuteScalar(
                    "SELECT LastDonationDate FROM Donors WHERE UserID = @userId",
                    new[] { new SqlParameter("@userId", userId) });

                lblDonationsCount.Text = donations.ToString();
                lblAppointmentsCount.Text = appointments.ToString();
                lblLastDonation.Text = lastDonation != null && lastDonation != DBNull.Value
                    ? Convert.ToDateTime(lastDonation).ToString("dd MMM yyyy")
                    : "Never";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dashboard error: " + ex.Message);
            }
        }
    }
}
