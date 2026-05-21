using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BloodConnect.UI.Donor
{
    public partial class DonorProfileForm : Form
    {
        private readonly int userId;
        private int donorId;

        public DonorProfileForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            cmbBloodGroup.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            LoadProfile();
        }

        private void LoadProfile()
        {
            try
            {
                DataAccess da = new DataAccess();
                DataTable dt = da.ExecuteQuery(
                    @"SELECT d.ID, u.FullName, u.Email, d.BloodGroup, d.Age, d.Phone, d.Address, d.LastDonationDate
                      FROM Donors d INNER JOIN Users u ON d.UserID = u.ID WHERE d.UserID = @userId",
                    new[] { new SqlParameter("@userId", userId) });

                if (dt.Rows.Count == 0)
                {
                    lblInfo.Text = "Donor profile not found.";
                    return;
                }

                DataRow row = dt.Rows[0];
                donorId = Convert.ToInt32(row["ID"]);
                txtFullName.Text = row["FullName"].ToString();
                txtEmail.Text = row["Email"] == DBNull.Value ? "" : row["Email"].ToString();
                cmbBloodGroup.Text = row["BloodGroup"].ToString();
                txtAge.Text = row["Age"] == DBNull.Value ? "" : row["Age"].ToString();
                txtPhone.Text = row["Phone"].ToString();
                txtAddress.Text = row["Address"].ToString();
                lblInfo.Text = row["LastDonationDate"] == DBNull.Value
                    ? "Eligible to donate (no previous donation on record)."
                    : "Last donation: " + Convert.ToDateTime(row["LastDonationDate"]).ToString("dd MMM yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (donorId == 0) return;
            if (txtFullName.Text.Trim() == "" || txtPhone.Text.Trim() == "" || txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("Please fill required fields.");
                return;
            }

            try
            {
                int? age = null;
                if (txtAge.Text.Trim() != "")
                {
                    if (!int.TryParse(txtAge.Text.Trim(), out int a) || a < 18 || a > 65)
                    {
                        MessageBox.Show("Enter a valid age (18-65).");
                        return;
                    }
                    age = a;
                }

                DataAccess da = new DataAccess();
                da.ExecuteNonQuery(
                    "UPDATE Users SET FullName=@name, Email=@email, UpdatedAt=GETDATE() WHERE ID=@userId",
                    new[]
                    {
                        new SqlParameter("@name", txtFullName.Text.Trim()),
                        new SqlParameter("@email", string.IsNullOrEmpty(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text.Trim()),
                        new SqlParameter("@userId", userId)
                    });

                da.ExecuteNonQuery(
                    @"UPDATE Donors SET BloodGroup=@group, Age=@age, Phone=@phone, Address=@address WHERE ID=@donorId",
                    new[]
                    {
                        new SqlParameter("@group", cmbBloodGroup.Text),
                        new SqlParameter("@age", age.HasValue ? (object)age.Value : DBNull.Value),
                        new SqlParameter("@phone", txtPhone.Text.Trim()),
                        new SqlParameter("@address", txtAddress.Text.Trim()),
                        new SqlParameter("@donorId", donorId)
                    });

                MessageBox.Show("Profile updated successfully.");
                LoadProfile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
        }
    }
}
