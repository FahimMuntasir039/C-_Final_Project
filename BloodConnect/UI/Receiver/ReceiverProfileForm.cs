using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BloodConnect.UI.Receiver
{
    public partial class ReceiverProfileForm : Form
    {
        private readonly int userId;
        private int receiverId;

        public ReceiverProfileForm(int userId)
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
                DataTable dt = new DataAccess().ExecuteQuery(
                    @"SELECT r.ID, u.FullName, u.Email, r.BloodGroupNeeded, r.Phone, r.Address
                      FROM Receivers r INNER JOIN Users u ON r.UserID = u.ID WHERE r.UserID = @userId",
                    new[] { new SqlParameter("@userId", userId) });
                if (dt.Rows.Count == 0) { lblInfo.Text = "Receiver profile not found."; return; }
                DataRow row = dt.Rows[0];
                receiverId = Convert.ToInt32(row["ID"]);
                txtFullName.Text = row["FullName"].ToString();
                txtEmail.Text = row["Email"] == DBNull.Value ? "" : row["Email"].ToString();
                cmbBloodGroup.Text = row["BloodGroupNeeded"].ToString();
                txtPhone.Text = row["Phone"].ToString();
                txtAddress.Text = row["Address"].ToString();
            }
            catch (Exception ex) { MessageBox.Show("Load error: " + ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (receiverId == 0 || txtFullName.Text.Trim() == "") { MessageBox.Show("Fill required fields."); return; }
            try
            {
                DataAccess da = new DataAccess();
                da.ExecuteNonQuery("UPDATE Users SET FullName=@n, Email=@e, UpdatedAt=GETDATE() WHERE ID=@u",
                    new[] { new SqlParameter("@n", txtFullName.Text.Trim()), new SqlParameter("@e", string.IsNullOrEmpty(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text.Trim()), new SqlParameter("@u", userId) });
                da.ExecuteNonQuery("UPDATE Receivers SET BloodGroupNeeded=@g, Phone=@p, Address=@a WHERE ID=@r",
                    new[] { new SqlParameter("@g", cmbBloodGroup.Text), new SqlParameter("@p", txtPhone.Text.Trim()), new SqlParameter("@a", txtAddress.Text.Trim()), new SqlParameter("@r", receiverId) });
                MessageBox.Show("Profile updated.");
                LoadProfile();
            }
            catch (Exception ex) { MessageBox.Show("Update error: " + ex.Message); }
        }
    }
}
