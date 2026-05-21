namespace BloodConnect.UI.Admin
{
    partial class ManageAppointmentsForm
    {
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Label lblAssign;
        private System.Windows.Forms.ComboBox cmbMatchingRequests;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblHelp;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.lblAssign = new System.Windows.Forms.Label();
            this.cmbMatchingRequests = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.SuspendLayout();

            this.lblTitle.Text = "Manage Donation Appointments";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(25, 15);
            this.lblTitle.Size = new System.Drawing.Size(500, 35);

            this.lblHelp.Text = "Flow: Approve request → Assign matching receiver → Mark complete (updates donation & receiver records)";
            this.lblHelp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHelp.ForeColor = System.Drawing.Color.Gray;
            this.lblHelp.Location = new System.Drawing.Point(25, 50);
            this.lblHelp.Size = new System.Drawing.Size(820, 40);

            this.lblSelected.Location = new System.Drawing.Point(25, 95);
            this.lblSelected.Size = new System.Drawing.Size(400, 22);
            this.lblSelected.Text = "Selected appointment: none";

            this.dgvAppointments.Location = new System.Drawing.Point(25, 125);
            this.dgvAppointments.Size = new System.Drawing.Size(820, 280);
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppointments_CellClick);

            this.btnApprove.Text = "Approve";
            this.btnApprove.Location = new System.Drawing.Point(25, 420);
            this.btnApprove.Size = new System.Drawing.Size(90, 34);
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);

            this.btnReject.Text = "Cancel";
            this.btnReject.Location = new System.Drawing.Point(125, 420);
            this.btnReject.Size = new System.Drawing.Size(90, 34);
            this.btnReject.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);

            this.lblAssign.Text = "Assign to matching receiver request (blood group must match):";
            this.lblAssign.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAssign.Location = new System.Drawing.Point(25, 465);
            this.lblAssign.Size = new System.Drawing.Size(450, 22);

            this.cmbMatchingRequests.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMatchingRequests.Location = new System.Drawing.Point(25, 490);
            this.cmbMatchingRequests.Size = new System.Drawing.Size(520, 28);

            this.btnAssign.Text = "Assign Donor to Receiver";
            this.btnAssign.Location = new System.Drawing.Point(555, 486);
            this.btnAssign.Size = new System.Drawing.Size(170, 34);
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);

            this.btnComplete.Text = "Mark Donation Complete";
            this.btnComplete.Location = new System.Drawing.Point(735, 486);
            this.btnComplete.Size = new System.Drawing.Size(170, 34);
            this.btnComplete.BackColor = System.Drawing.Color.FromArgb(52, 120, 246);
            this.btnComplete.ForeColor = System.Drawing.Color.White;
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);

            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Location = new System.Drawing.Point(735, 420);
            this.btnRefresh.Size = new System.Drawing.Size(90, 34);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.ClientSize = new System.Drawing.Size(870, 620);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblTitle, lblHelp, lblSelected, dgvAppointments, btnApprove, btnReject,
                lblAssign, cmbMatchingRequests, btnAssign, btnComplete, btnRefresh });
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
