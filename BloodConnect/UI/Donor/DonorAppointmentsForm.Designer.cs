namespace BloodConnect.UI.Donor
{
    partial class DonorAppointmentsForm
    {
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblGrid;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Label lblEditSection;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.DateTimePicker dtpAppointment;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblContactInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdateDate;
        private System.Windows.Forms.Button btnCancel;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblGrid = new System.Windows.Forms.Label();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.lblEditSection = new System.Windows.Forms.Label();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.dtpAppointment = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblContactInfo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdateDate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.SuspendLayout();

            this.lblTitle.Text = "Donation Appointments";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(25, 15);
            this.lblTitle.Size = new System.Drawing.Size(500, 35);

            this.lblSearch.Text = "Search:";
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.Location = new System.Drawing.Point(25, 58);
            this.lblSearch.AutoSize = true;
            this.txtSearch.Location = new System.Drawing.Point(25, 82);
            this.txtSearch.Size = new System.Drawing.Size(280, 28);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            this.lblGrid.Text = "Your appointment requests (status is updated by admin only):";
            this.lblGrid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGrid.Location = new System.Drawing.Point(25, 118);
            this.lblGrid.Size = new System.Drawing.Size(700, 22);

            this.dgvAppointments.Location = new System.Drawing.Point(25, 142);
            this.dgvAppointments.Size = new System.Drawing.Size(820, 220);
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointments_CellClick);

            this.lblEditSection.Text = "Request new appointment or change a pending request:";
            this.lblEditSection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEditSection.Location = new System.Drawing.Point(25, 372);
            this.lblEditSection.Size = new System.Drawing.Size(600, 22);

            this.lblAppointmentDate.Text = "Preferred appointment date:";
            this.lblAppointmentDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAppointmentDate.Location = new System.Drawing.Point(25, 400);
            this.lblAppointmentDate.AutoSize = true;
            this.dtpAppointment.Location = new System.Drawing.Point(25, 424);
            this.dtpAppointment.Size = new System.Drawing.Size(280, 28);

            this.lblStatus.Text = "Status (read-only):";
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.Location = new System.Drawing.Point(320, 400);
            this.lblStatus.AutoSize = true;
            this.lblStatusValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatusValue.Location = new System.Drawing.Point(320, 424);
            this.lblStatusValue.Size = new System.Drawing.Size(200, 28);
            this.lblStatusValue.Text = "-";

            this.lblContactInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblContactInfo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblContactInfo.Location = new System.Drawing.Point(25, 458);
            this.lblContactInfo.Size = new System.Drawing.Size(820, 45);

            this.btnAdd.Text = "Request Appointment";
            this.btnAdd.Location = new System.Drawing.Point(25, 510);
            this.btnAdd.Size = new System.Drawing.Size(150, 34);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdateDate.Text = "Update Date (Pending only)";
            this.btnUpdateDate.Location = new System.Drawing.Point(185, 510);
            this.btnUpdateDate.Size = new System.Drawing.Size(170, 34);
            this.btnUpdateDate.Click += new System.EventHandler(this.btnUpdateDate_Click);

            this.btnCancel.Text = "Cancel Request";
            this.btnCancel.Location = new System.Drawing.Point(365, 510);
            this.btnCancel.Size = new System.Drawing.Size(120, 34);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.ClientSize = new System.Drawing.Size(870, 620);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblTitle, lblSearch, txtSearch, lblGrid, dgvAppointments, lblEditSection,
                lblAppointmentDate, dtpAppointment, lblStatus, lblStatusValue, lblContactInfo,
                btnAdd, btnUpdateDate, btnCancel });
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
