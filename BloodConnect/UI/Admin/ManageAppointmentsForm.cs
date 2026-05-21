using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BloodConnect.UI.Admin
{
    public partial class ManageAppointmentsForm : Form
    {
        private int selectedAppointmentId;
        private string selectedDonorBloodGroup = "";

        public ManageAppointmentsForm()
        {
            InitializeComponent();
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            try
            {
                string q = @"SELECT ap.ID, du.FullName AS DonorName, d.BloodGroup AS DonorBloodGroup,
                                    ap.AppointmentDate, ap.Status,
                                    br.ID AS RequestID, ru.FullName AS ReceiverName,
                                    br.BloodGroup AS RequestBloodGroup, br.HospitalName
                             FROM DonationAppointments ap
                             INNER JOIN Donors d ON ap.DonorID = d.ID
                             INNER JOIN Users du ON d.UserID = du.ID
                             LEFT JOIN BloodRequests br ON ap.BloodRequestID = br.ID
                             LEFT JOIN Users ru ON br.UserID = ru.ID
                             ORDER BY ap.AppointmentDate DESC";
                dgvAppointments.DataSource = new DataAccess().ExecuteQuery(q);
                dgvAppointments.ClearSelection();
                selectedAppointmentId = 0;
                lblSelected.Text = "Selected appointment: none";
                cmbMatchingRequests.DataSource = null;
            }
            catch (Exception ex) { MessageBox.Show("Load error: " + ex.Message); }
        }

        private void dgvAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            selectedAppointmentId = Convert.ToInt32(dgvAppointments.Rows[e.RowIndex].Cells["ID"].Value);
            lblSelected.Text = "Selected appointment ID: " + selectedAppointmentId;

            string status = dgvAppointments.Rows[e.RowIndex].Cells["Status"].Value.ToString();
            selectedDonorBloodGroup = dgvAppointments.Rows[e.RowIndex].Cells["DonorBloodGroup"].Value.ToString();

            object reqId = dgvAppointments.Rows[e.RowIndex].Cells["RequestID"].Value;
            if (reqId != DBNull.Value && reqId != null)
                cmbMatchingRequests.SelectedValue = Convert.ToInt32(reqId);

            LoadMatchingRequests(status);
        }

        private void LoadMatchingRequests(string appointmentStatus)
        {
            if (selectedAppointmentId == 0 || string.IsNullOrEmpty(selectedDonorBloodGroup)) return;

            try
            {
                DataTable dt = new DataAccess().ExecuteQuery(
                    @"SELECT br.ID,
                             CAST(br.ID AS NVARCHAR) + N' — ' + ru.FullName + N' (' + br.BloodGroup + N', ' +
                             CAST(br.UnitsRequired AS NVARCHAR) + N' units @ ' + ISNULL(br.HospitalName, N'') + N')' AS DisplayText
                      FROM BloodRequests br
                      INNER JOIN Users ru ON br.UserID = ru.ID
                      WHERE br.BloodGroup = @bg
                        AND br.Status IN ('Approved', 'Pending')
                        AND br.ID NOT IN (
                            SELECT BloodRequestID FROM DonationAppointments
                            WHERE BloodRequestID IS NOT NULL AND Status IN ('Assigned', 'Completed')
                        )
                      ORDER BY br.RequestDate DESC",
                    new[] { new SqlParameter("@bg", selectedDonorBloodGroup) });

                cmbMatchingRequests.DisplayMember = "DisplayText";
                cmbMatchingRequests.ValueMember = "ID";
                cmbMatchingRequests.DataSource = dt;

                bool canAssign = appointmentStatus == AppointmentStatus.Approved;
                btnAssign.Enabled = canAssign && dt.Rows.Count > 0;
            }
            catch (Exception ex) { MessageBox.Show("Load requests error: " + ex.Message); }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            UpdateAppointmentStatus(AppointmentStatus.Approved, AppointmentStatus.Pending);
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            UpdateAppointmentStatus(AppointmentStatus.Cancelled, AppointmentStatus.Pending);
        }

        private void UpdateAppointmentStatus(string newStatus, string requiredCurrent)
        {
            if (selectedAppointmentId == 0) { MessageBox.Show("Select an appointment."); return; }
            try
            {
                int rows = new DataAccess().ExecuteNonQuery(
                    "UPDATE DonationAppointments SET Status=@s WHERE ID=@id AND Status=@cur",
                    new[]
                    {
                        new SqlParameter("@s", newStatus),
                        new SqlParameter("@id", selectedAppointmentId),
                        new SqlParameter("@cur", requiredCurrent)
                    });
                if (rows == 0) MessageBox.Show("Only " + requiredCurrent + " appointments can be updated this way.");
                else { MessageBox.Show("Appointment marked as " + newStatus + "."); LoadAppointments(); }
            }
            catch (Exception ex) { MessageBox.Show("Update error: " + ex.Message); }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (selectedAppointmentId == 0 || cmbMatchingRequests.SelectedValue == null)
            {
                MessageBox.Show("Select an approved appointment and a matching receiver request.");
                return;
            }

            int requestId = Convert.ToInt32(cmbMatchingRequests.SelectedValue);
            try
            {
                DataAccess da = new DataAccess();
                int rows = da.ExecuteNonQuery(
                    @"UPDATE DonationAppointments SET BloodRequestID=@req, Status=@assigned
                      WHERE ID=@id AND Status=@approved",
                    new[]
                    {
                        new SqlParameter("@req", requestId),
                        new SqlParameter("@assigned", AppointmentStatus.Assigned),
                        new SqlParameter("@id", selectedAppointmentId),
                        new SqlParameter("@approved", AppointmentStatus.Approved)
                    });
                if (rows == 0) { MessageBox.Show("Assignment failed. Appointment must be Approved."); return; }

                da.ExecuteNonQuery(
                    "UPDATE BloodRequests SET Status=@s WHERE ID=@id",
                    new[] { new SqlParameter("@s", RequestStatus.Assigned), new SqlParameter("@id", requestId) });

                MessageBox.Show("Donor assigned to receiver request. Both users can now see contact details.");
                LoadAppointments();
            }
            catch (Exception ex) { MessageBox.Show("Assign error: " + ex.Message); }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (selectedAppointmentId == 0) { MessageBox.Show("Select an appointment."); return; }

            try
            {
                DataAccess da = new DataAccess();
                DataTable dt = da.ExecuteQuery(
                    @"SELECT ap.ID, ap.DonorID, ap.BloodRequestID, d.BloodGroup, br.UnitsRequired
                      FROM DonationAppointments ap
                      INNER JOIN Donors d ON ap.DonorID = d.ID
                      LEFT JOIN BloodRequests br ON ap.BloodRequestID = br.ID
                      WHERE ap.ID=@id AND ap.Status=@assigned",
                    new[]
                    {
                        new SqlParameter("@id", selectedAppointmentId),
                        new SqlParameter("@assigned", AppointmentStatus.Assigned)
                    });

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Only Assigned appointments can be marked complete.");
                    return;
                }

                DataRow row = dt.Rows[0];
                int donorId = Convert.ToInt32(row["DonorID"]);
                string bloodGroup = row["BloodGroup"].ToString();
                int units = row["UnitsRequired"] == DBNull.Value ? 1 : Convert.ToInt32(row["UnitsRequired"]);
                int? requestId = row["BloodRequestID"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["BloodRequestID"]);

                da.ExecuteNonQuery(
                    @"INSERT INTO Donations (DonorID, BloodGroup, UnitsDonated, DonationDate, Status, BloodRequestID, AppointmentID)
                      VALUES (@donor, @bg, @units, GETDATE(), 'Completed', @req, @appt)",
                    new[]
                    {
                        new SqlParameter("@donor", donorId),
                        new SqlParameter("@bg", bloodGroup),
                        new SqlParameter("@units", units),
                        new SqlParameter("@req", (object)requestId ?? DBNull.Value),
                        new SqlParameter("@appt", selectedAppointmentId)
                    });

                da.ExecuteNonQuery(
                    "UPDATE DonationAppointments SET Status=@c, UnitsDonated=@u WHERE ID=@id",
                    new[]
                    {
                        new SqlParameter("@c", AppointmentStatus.Completed),
                        new SqlParameter("@u", units),
                        new SqlParameter("@id", selectedAppointmentId)
                    });

                da.ExecuteNonQuery("UPDATE Donors SET LastDonationDate = GETDATE() WHERE ID=@d",
                    new[] { new SqlParameter("@d", donorId) });

                if (requestId.HasValue)
                {
                    da.ExecuteNonQuery(
                        "UPDATE BloodRequests SET Status=@s WHERE ID=@id",
                        new[] { new SqlParameter("@s", RequestStatus.Fulfilled), new SqlParameter("@id", requestId.Value) });
                }

                da.ExecuteNonQuery(
                    @"UPDATE BloodStock SET UnitsAvailable = UnitsAvailable + @units WHERE BloodGroup = @bg",
                    new[] { new SqlParameter("@units", units), new SqlParameter("@bg", bloodGroup) });

                MessageBox.Show("Donation completed. Records updated for donor and receiver.");
                LoadAppointments();
            }
            catch (Exception ex) { MessageBox.Show("Complete error: " + ex.Message); }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadAppointments();
    }
}
