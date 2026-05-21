using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BloodConnect.UI.Admin
{
    public partial class ManageRequestsForm : Form
    {
        private int selectedId = 0;

        public ManageRequestsForm()
        {
            InitializeComponent();
            LoadRequests();
        }

        private void LoadRequests()
        {
            try
            {
                DataAccess da = new DataAccess();
                string query = @"SELECT br.ID, u.FullName AS PatientName, br.BloodGroup, br.UnitsRequired,
                                 br.HospitalName, br.ContactPhone, br.Status, br.RequestDate
                                 FROM BloodRequests br
                                 INNER JOIN Users u ON br.UserID = u.ID
                                 ORDER BY br.RequestDate DESC";
                dgvRequests.DataSource = da.ExecuteQuery(query);
                dgvRequests.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message);
            }
        }

        private void dgvRequests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(dgvRequests.Rows[e.RowIndex].Cells["ID"].Value);
                lblSelected.Text = "Selected Request ID: " + selectedId;
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            UpdateStatus(RequestStatus.Approved, RequestStatus.Pending);
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            UpdateStatus(RequestStatus.Rejected, RequestStatus.Pending);
        }

        private void UpdateStatus(string newStatus, string requiredCurrent)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a request first.");
                return;
            }

            try
            {
                DataAccess da = new DataAccess();
                int rows = da.ExecuteNonQuery(
                    "UPDATE BloodRequests SET Status=@status WHERE ID=@id AND Status=@cur",
                    new[]
                    {
                        new SqlParameter("@status", newStatus),
                        new SqlParameter("@id", selectedId),
                        new SqlParameter("@cur", requiredCurrent)
                    });
                if (rows == 0)
                    MessageBox.Show("Only " + requiredCurrent + " receiver requests can be updated here. Use Appointments to mark fulfilled after donation.");
                else
                {
                    MessageBox.Show("Request status updated to " + newStatus + ".");
                    LoadRequests();
                    selectedId = 0;
                    lblSelected.Text = "Selected Request ID: -";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRequests();
        }
    }
}
