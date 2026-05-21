using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BloodConnect.UI.Receiver
{
    public partial class ReceiverRequestsForm : Form
    {
        private readonly int userId;
        private int selectedId;

        public ReceiverRequestsForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            cmbBloodGroup.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            LoadRequests();
        }

        private void LoadRequests(string search = "")
        {
            try
            {
                string q = @"SELECT br.ID, br.BloodGroup, br.UnitsRequired, br.HospitalName, br.ContactPhone,
                                      br.Status, br.RequestDate,
                                      du.FullName AS AssignedDonor, d.Phone AS DonorPhone,
                                      ap.AppointmentDate AS DonationAppointmentDate
                               FROM BloodRequests br
                               LEFT JOIN DonationAppointments ap ON ap.BloodRequestID = br.ID
                                    AND ap.Status IN ('Assigned', 'Completed')
                               LEFT JOIN Donors d ON ap.DonorID = d.ID
                               LEFT JOIN Users du ON d.UserID = du.ID
                               WHERE br.UserID = @userId";
                var p = new List<SqlParameter> { new SqlParameter("@userId", userId) };
                if (!string.IsNullOrWhiteSpace(search))
                {
                    q += " AND (br.BloodGroup LIKE @s OR br.HospitalName LIKE @s OR br.Status LIKE @s OR du.FullName LIKE @s)";
                    p.Add(new SqlParameter("@s", "%" + search.Trim() + "%"));
                }
                q += " ORDER BY br.RequestDate DESC";
                dgvRequests.DataSource = new DataAccess().ExecuteQuery(q, p.ToArray());
                selectedId = 0;
                lblDonorInfo.Text = "Assigned donor contact appears here after admin links a donor to your request.";
            }
            catch (Exception ex) { MessageBox.Show("Load error: " + ex.Message); }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => LoadRequests(txtSearch.Text);

        private void dgvRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            selectedId = Convert.ToInt32(dgvRequests.Rows[e.RowIndex].Cells["ID"].Value);
            string status = dgvRequests.Rows[e.RowIndex].Cells["Status"].Value.ToString();
            cmbBloodGroup.Text = dgvRequests.Rows[e.RowIndex].Cells["BloodGroup"].Value.ToString();
            txtUnits.Text = dgvRequests.Rows[e.RowIndex].Cells["UnitsRequired"].Value.ToString();
            txtHospital.Text = dgvRequests.Rows[e.RowIndex].Cells["HospitalName"].Value.ToString();
            txtPhone.Text = dgvRequests.Rows[e.RowIndex].Cells["ContactPhone"].Value.ToString();
            lblStatusValue.Text = status;

            bool isPending = status == RequestStatus.Pending;
            btnUpdate.Enabled = isPending;
            btnDelete.Enabled = isPending;

            if (status == RequestStatus.Assigned || status == RequestStatus.Fulfilled)
            {
                string donor = dgvRequests.Rows[e.RowIndex].Cells["AssignedDonor"].Value?.ToString() ?? "-";
                string donorPhone = dgvRequests.Rows[e.RowIndex].Cells["DonorPhone"].Value?.ToString() ?? "-";
                string appt = dgvRequests.Rows[e.RowIndex].Cells["DonationAppointmentDate"].Value?.ToString() ?? "-";
                lblDonorInfo.Text = "Assigned donor: " + donor + " | Phone: " + donorPhone + " | Appointment: " + appt;
            }
            else if (status == RequestStatus.Approved)
            {
                lblDonorInfo.Text = "Request approved. Admin will assign a matching donor soon.";
            }
            else
            {
                lblDonorInfo.Text = "Assigned donor contact appears after admin links a donor to your request.";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) { MessageBox.Show("Select a request to update."); return; }
            try
            {
                new DataAccess().ExecuteNonQuery(
                    @"UPDATE BloodRequests SET BloodGroup=@g, UnitsRequired=@u, HospitalName=@h, ContactPhone=@p
                      WHERE ID=@id AND UserID=@userId AND Status = 'Pending'",
                    new[]
                    {
                        new SqlParameter("@g", cmbBloodGroup.Text),
                        new SqlParameter("@u", Convert.ToInt32(txtUnits.Text)),
                        new SqlParameter("@h", txtHospital.Text.Trim()),
                        new SqlParameter("@p", txtPhone.Text.Trim()),
                        new SqlParameter("@id", selectedId),
                        new SqlParameter("@userId", userId)
                    });
                MessageBox.Show("Request updated.");
                LoadRequests(txtSearch.Text);
            }
            catch (Exception ex) { MessageBox.Show("Update error: " + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) return;
            if (MessageBox.Show("Delete this blood request?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try
            {
                int rows = new DataAccess().ExecuteNonQuery(
                    "DELETE FROM BloodRequests WHERE ID=@id AND UserID=@userId AND Status = 'Pending'",
                    new[] { new SqlParameter("@id", selectedId), new SqlParameter("@userId", userId) });
                MessageBox.Show(rows > 0 ? "Request deleted." : "Only pending requests can be deleted.");
                LoadRequests(txtSearch.Text);
            }
            catch (Exception ex) { MessageBox.Show("Delete error: " + ex.Message); }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadRequests(txtSearch.Text);
    }
}
