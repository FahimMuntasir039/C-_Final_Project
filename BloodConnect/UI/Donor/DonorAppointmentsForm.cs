using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BloodConnect.UI.Donor
{
    public partial class DonorAppointmentsForm : Form
    {
        private readonly int userId;
        private int donorId;
        private int selectedId;

        public DonorAppointmentsForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadDonorId();
            LoadAppointments();
        }

        private void LoadDonorId()
        {
            object id = new DataAccess().ExecuteScalar("SELECT ID FROM Donors WHERE UserID=@u", new[] { new SqlParameter("@u", userId) });
            if (id != null) donorId = Convert.ToInt32(id);
        }

        private void LoadAppointments(string search = "")
        {
            if (donorId == 0) return;
            string q = @"SELECT ap.ID, ap.AppointmentDate, ap.Status,
                                ru.FullName AS ReceiverName, br.BloodGroup AS RequestBloodGroup,
                                br.HospitalName, br.ContactPhone AS ReceiverPhone
                         FROM DonationAppointments ap
                         LEFT JOIN BloodRequests br ON ap.BloodRequestID = br.ID
                         LEFT JOIN Users ru ON br.UserID = ru.ID
                         WHERE ap.DonorID=@d";
            var p = new List<SqlParameter> { new SqlParameter("@d", donorId) };
            if (!string.IsNullOrWhiteSpace(search))
            {
                q += " AND (ap.Status LIKE @s OR ru.FullName LIKE @s OR br.HospitalName LIKE @s)";
                p.Add(new SqlParameter("@s", "%" + search.Trim() + "%"));
            }
            q += " ORDER BY ap.AppointmentDate DESC";
            dgvAppointments.DataSource = new DataAccess().ExecuteQuery(q, p.ToArray());
            selectedId = 0;
            lblStatusValue.Text = "-";
            lblContactInfo.Text = "Receiver contact details appear here after admin assigns you to a request.";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => LoadAppointments(txtSearch.Text);

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (donorId == 0) return;
            try
            {
                new DataAccess().ExecuteNonQuery(
                    "INSERT INTO DonationAppointments (DonorID, AppointmentDate, Status) VALUES (@d, @date, @pending)",
                    new[]
                    {
                        new SqlParameter("@d", donorId),
                        new SqlParameter("@date", dtpAppointment.Value),
                        new SqlParameter("@pending", AppointmentStatus.Pending)
                    });
                MessageBox.Show("Appointment request submitted. Admin will review and approve.");
                LoadAppointments(txtSearch.Text);
            }
            catch (Exception ex) { MessageBox.Show("Add error: " + ex.Message); }
        }

        private void dgvAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            selectedId = Convert.ToInt32(dgvAppointments.Rows[e.RowIndex].Cells["ID"].Value);
            string status = dgvAppointments.Rows[e.RowIndex].Cells["Status"].Value.ToString();
            dtpAppointment.Value = Convert.ToDateTime(dgvAppointments.Rows[e.RowIndex].Cells["AppointmentDate"].Value);
            lblStatusValue.Text = status;

            bool isPending = status == AppointmentStatus.Pending;
            btnUpdateDate.Enabled = isPending;
            btnCancel.Enabled = isPending;

            object receiverName = dgvAppointments.Rows[e.RowIndex].Cells["ReceiverName"].Value;
            if (status == AppointmentStatus.Assigned || status == AppointmentStatus.Completed)
            {
                string name = receiverName == DBNull.Value ? "-" : receiverName.ToString();
                string hospital = dgvAppointments.Rows[e.RowIndex].Cells["HospitalName"].Value?.ToString() ?? "-";
                string phone = dgvAppointments.Rows[e.RowIndex].Cells["ReceiverPhone"].Value?.ToString() ?? "-";
                string bg = dgvAppointments.Rows[e.RowIndex].Cells["RequestBloodGroup"].Value?.ToString() ?? "-";
                lblContactInfo.Text = "Receiver: " + name + " | Blood: " + bg + " | Hospital: " + hospital + " | Phone: " + phone;
            }
            else if (status == AppointmentStatus.Approved)
            {
                lblContactInfo.Text = "Approved by admin. Waiting for assignment to a matching receiver request.";
            }
            else
            {
                lblContactInfo.Text = "Receiver contact details appear after admin assigns you to a matching request.";
            }
        }

        private void btnUpdateDate_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) { MessageBox.Show("Select a pending appointment."); return; }
            try
            {
                int rows = new DataAccess().ExecuteNonQuery(
                    "UPDATE DonationAppointments SET AppointmentDate=@d WHERE ID=@id AND DonorID=@donor AND Status=@pending",
                    new[]
                    {
                        new SqlParameter("@d", dtpAppointment.Value),
                        new SqlParameter("@id", selectedId),
                        new SqlParameter("@donor", donorId),
                        new SqlParameter("@pending", AppointmentStatus.Pending)
                    });
                MessageBox.Show(rows > 0 ? "Appointment date updated." : "Only pending appointments can be changed.");
                LoadAppointments(txtSearch.Text);
            }
            catch (Exception ex) { MessageBox.Show("Update error: " + ex.Message); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) return;
            if (MessageBox.Show("Cancel this appointment request?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try
            {
                int rows = new DataAccess().ExecuteNonQuery(
                    "UPDATE DonationAppointments SET Status=@c WHERE ID=@id AND DonorID=@d AND Status=@pending",
                    new[]
                    {
                        new SqlParameter("@c", AppointmentStatus.Cancelled),
                        new SqlParameter("@id", selectedId),
                        new SqlParameter("@d", donorId),
                        new SqlParameter("@pending", AppointmentStatus.Pending)
                    });
                MessageBox.Show(rows > 0 ? "Appointment cancelled." : "Only pending requests can be cancelled.");
                LoadAppointments(txtSearch.Text);
            }
            catch (Exception ex) { MessageBox.Show("Cancel error: " + ex.Message); }
        }
    }
}
