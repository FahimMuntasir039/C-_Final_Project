using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BloodConnect.UI.Donor
{
    public partial class DonorRecordDonationForm : Form
    {
        private readonly int userId;
        private int donorId;

        public DonorRecordDonationForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            cmbBloodGroup.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            LoadDonorInfo();
        }

        private void LoadDonorInfo()
        {
            try
            {
                DataTable dt = new DataAccess().ExecuteQuery(
                    "SELECT ID, BloodGroup FROM Donors WHERE UserID = @userId",
                    new[] { new SqlParameter("@userId", userId) });
                if (dt.Rows.Count > 0)
                {
                    donorId = Convert.ToInt32(dt.Rows[0]["ID"]);
                    cmbBloodGroup.Text = dt.Rows[0]["BloodGroup"].ToString();
                    lblInfo.Text = "Record a new donation. Stock will be updated automatically.";
                }
                else
                {
                    lblInfo.Text = "Donor profile not found.";
                    btnSave.Enabled = false;
                }
            }
            catch (Exception ex) { MessageBox.Show("Load error: " + ex.Message); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (donorId == 0 || txtUnits.Text.Trim() == "") { MessageBox.Show("Enter units donated."); return; }
            try
            {
                DataAccess da = new DataAccess();
                int units = Convert.ToInt32(txtUnits.Text.Trim());
                da.ExecuteNonQuery(
                    @"INSERT INTO Donations (DonorID, BloodGroup, UnitsDonated, DonationDate, Status)
                      VALUES (@donorId, @group, @units, GETDATE(), 'Completed')",
                    new[] { new SqlParameter("@donorId", donorId), new SqlParameter("@group", cmbBloodGroup.Text), new SqlParameter("@units", units) });
                da.ExecuteNonQuery(
                    "UPDATE Donors SET LastDonationDate = GETDATE() WHERE ID = @donorId",
                    new[] { new SqlParameter("@donorId", donorId) });
                da.ExecuteNonQuery(
                    @"UPDATE BloodStock SET UnitsAvailable = UnitsAvailable + @units WHERE BloodGroup = @group",
                    new[] { new SqlParameter("@units", units), new SqlParameter("@group", cmbBloodGroup.Text) });
                MessageBox.Show("Donation recorded successfully.");
                txtUnits.Clear();
            }
            catch (Exception ex) { MessageBox.Show("Save error: " + ex.Message); }
        }
    }
}
