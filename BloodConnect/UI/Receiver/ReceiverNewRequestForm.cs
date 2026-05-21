using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BloodConnect.UI.Receiver
{
    public partial class ReceiverNewRequestForm : Form
    {
        private readonly int userId;

        public ReceiverNewRequestForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            cmbBloodGroup.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            cmbBloodGroup.SelectedIndex = 0;
            LoadReceiverDefaults();
        }

        private void LoadReceiverDefaults()
        {
            try
            {
                var dt = new DataAccess().ExecuteQuery(
                    "SELECT BloodGroupNeeded, Phone, Address FROM Receivers WHERE UserID = @userId",
                    new[] { new SqlParameter("@userId", userId) });
                if (dt.Rows.Count > 0)
                {
                    cmbBloodGroup.Text = dt.Rows[0]["BloodGroupNeeded"].ToString();
                    txtPhone.Text = dt.Rows[0]["Phone"].ToString();
                    txtHospital.Text = dt.Rows[0]["Address"].ToString();
                }
            }
            catch { }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUnits.Text.Trim() == "" || txtHospital.Text.Trim() == "" || txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            try
            {
                int rows = new DataAccess().ExecuteNonQuery(
                    @"INSERT INTO BloodRequests (UserID, BloodGroup, UnitsRequired, HospitalName, ContactPhone, Status, RequestDate)
                      VALUES (@userId, @group, @units, @hospital, @phone, 'Pending', GETDATE())",
                    new[]
                    {
                        new SqlParameter("@userId", userId),
                        new SqlParameter("@group", cmbBloodGroup.Text),
                        new SqlParameter("@units", txtUnits.Text),
                        new SqlParameter("@hospital", txtHospital.Text.Trim()),
                        new SqlParameter("@phone", txtPhone.Text.Trim())
                    });
                if (rows > 0)
                {
                    MessageBox.Show("Blood request submitted successfully.");
                    txtUnits.Clear();
                }
            }
            catch (Exception ex) { MessageBox.Show("Submit error: " + ex.Message); }
        }
    }
}
