using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BloodConnect.UI.Donor
{
    public partial class DonorDonationsForm : Form
    {
        private readonly int userId;
        private int donorId;
        private int selectedDonationId;

        public DonorDonationsForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            cmbStatus.Items.AddRange(new object[] { "Completed", "Pending", "Cancelled" });
            cmbBloodGroup.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            LoadDonorId();
            LoadDonations();
        }

        private void LoadDonorId()
        {
            object id = new DataAccess().ExecuteScalar(
                "SELECT ID FROM Donors WHERE UserID = @userId",
                new[] { new SqlParameter("@userId", userId) });
            if (id != null) donorId = Convert.ToInt32(id);
        }

        private void LoadDonations(string search = "")
        {
            if (donorId == 0) return;
            try
            {
                string query = @"SELECT dn.ID, dn.BloodGroup, dn.UnitsDonated, dn.DonationDate, dn.Status
                                 FROM Donations dn WHERE dn.DonorID = @donorId";
                if (!string.IsNullOrWhiteSpace(search))
                    query += " AND (dn.BloodGroup LIKE @search OR dn.Status LIKE @search)";

                query += " ORDER BY dn.DonationDate DESC";
                var param = new System.Collections.Generic.List<SqlParameter>
                {
                    new SqlParameter("@donorId", donorId)
                };
                if (!string.IsNullOrWhiteSpace(search))
                    param.Add(new SqlParameter("@search", "%" + search.Trim() + "%"));

                dgvDonations.DataSource = new DataAccess().ExecuteQuery(query, param.ToArray());
                dgvDonations.ClearSelection();
                selectedDonationId = 0;
            }
            catch (Exception ex) { MessageBox.Show("Load error: " + ex.Message); }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => LoadDonations(txtSearch.Text);

        private void dgvDonations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            selectedDonationId = Convert.ToInt32(dgvDonations.Rows[e.RowIndex].Cells["ID"].Value);
            cmbBloodGroup.Text = dgvDonations.Rows[e.RowIndex].Cells["BloodGroup"].Value.ToString();
            txtUnits.Text = dgvDonations.Rows[e.RowIndex].Cells["UnitsDonated"].Value.ToString();
            cmbStatus.Text = dgvDonations.Rows[e.RowIndex].Cells["Status"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedDonationId == 0 || txtUnits.Text.Trim() == "") { MessageBox.Show("Select a donation and enter units."); return; }
            try
            {
                new DataAccess().ExecuteNonQuery(
                    "UPDATE Donations SET BloodGroup=@g, UnitsDonated=@u, Status=@s WHERE ID=@id AND DonorID=@donorId",
                    new[]
                    {
                        new SqlParameter("@g", cmbBloodGroup.Text),
                        new SqlParameter("@u", Convert.ToInt32(txtUnits.Text)),
                        new SqlParameter("@s", cmbStatus.Text),
                        new SqlParameter("@id", selectedDonationId),
                        new SqlParameter("@donorId", donorId)
                    });
                MessageBox.Show("Donation updated.");
                LoadDonations(txtSearch.Text);
            }
            catch (Exception ex) { MessageBox.Show("Update error: " + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedDonationId == 0) { MessageBox.Show("Select a donation to delete."); return; }
            if (MessageBox.Show("Delete this donation record?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try
            {
                new DataAccess().ExecuteNonQuery(
                    "DELETE FROM Donations WHERE ID=@id AND DonorID=@donorId",
                    new[] { new SqlParameter("@id", selectedDonationId), new SqlParameter("@donorId", donorId) });
                MessageBox.Show("Donation deleted.");
                LoadDonations(txtSearch.Text);
            }
            catch (Exception ex) { MessageBox.Show("Delete error: " + ex.Message); }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadDonations(txtSearch.Text);
    }
}
