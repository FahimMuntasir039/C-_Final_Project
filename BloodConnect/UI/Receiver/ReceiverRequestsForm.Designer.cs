namespace BloodConnect.UI.Receiver
{
    partial class ReceiverRequestsForm
    {
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblGrid;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.Label lblEditSection;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.Label lblHospital;
        private System.Windows.Forms.TextBox txtHospital;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblDonorInfo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblGrid = new System.Windows.Forms.Label();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.lblEditSection = new System.Windows.Forms.Label();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.lblUnits = new System.Windows.Forms.Label();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.lblHospital = new System.Windows.Forms.Label();
            this.txtHospital = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblDonorInfo = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.SuspendLayout();

            this.lblTitle.Text = "My Blood Requests";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(25, 10);
            this.lblTitle.Size = new System.Drawing.Size(500, 30);

            this.lblSearch.Text = "Search:";
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.Location = new System.Drawing.Point(25, 48);
            this.lblSearch.AutoSize = true;
            this.txtSearch.Location = new System.Drawing.Point(25, 72);
            this.txtSearch.Size = new System.Drawing.Size(260, 28);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Location = new System.Drawing.Point(295, 70);
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.lblGrid.Text = "Your requests (status updated by admin; donor shown when assigned):";
            this.lblGrid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGrid.Location = new System.Drawing.Point(25, 108);
            this.lblGrid.Size = new System.Drawing.Size(700, 22);

            this.dgvRequests.Location = new System.Drawing.Point(25, 132);
            this.dgvRequests.Size = new System.Drawing.Size(820, 240);
            this.dgvRequests.ReadOnly = true;
            this.dgvRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequests_CellClick);

            this.lblEditSection.Text = "Edit pending request only:";
            this.lblEditSection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEditSection.Location = new System.Drawing.Point(25, 382);
            this.lblEditSection.AutoSize = true;

            this.lblBloodGroup.Text = "Blood group:";
            this.lblBloodGroup.Location = new System.Drawing.Point(25, 408);
            this.lblBloodGroup.AutoSize = true;
            this.cmbBloodGroup.Location = new System.Drawing.Point(25, 428);
            this.cmbBloodGroup.Size = new System.Drawing.Size(70, 28);

            this.lblUnits.Text = "Units:";
            this.lblUnits.Location = new System.Drawing.Point(105, 408);
            this.lblUnits.AutoSize = true;
            this.txtUnits.Location = new System.Drawing.Point(105, 428);
            this.txtUnits.Size = new System.Drawing.Size(50, 28);

            this.lblHospital.Text = "Hospital:";
            this.lblHospital.Location = new System.Drawing.Point(165, 408);
            this.lblHospital.AutoSize = true;
            this.txtHospital.Location = new System.Drawing.Point(165, 428);
            this.txtHospital.Size = new System.Drawing.Size(180, 28);

            this.lblPhone.Text = "Your phone:";
            this.lblPhone.Location = new System.Drawing.Point(355, 408);
            this.lblPhone.AutoSize = true;
            this.txtPhone.Location = new System.Drawing.Point(355, 428);
            this.txtPhone.Size = new System.Drawing.Size(110, 28);

            this.lblStatus.Text = "Status:";
            this.lblStatus.Location = new System.Drawing.Point(475, 408);
            this.lblStatus.AutoSize = true;
            this.lblStatusValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusValue.Location = new System.Drawing.Point(475, 428);
            this.lblStatusValue.Size = new System.Drawing.Size(100, 28);
            this.lblStatusValue.Text = "-";

            this.lblDonorInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDonorInfo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDonorInfo.Location = new System.Drawing.Point(25, 465);
            this.lblDonorInfo.Size = new System.Drawing.Size(820, 40);

            this.btnUpdate.Text = "Update";
            this.btnUpdate.Location = new System.Drawing.Point(590, 424);
            this.btnUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(675, 424);
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.ClientSize = new System.Drawing.Size(870, 620);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblTitle, lblSearch, txtSearch, btnRefresh, lblGrid, dgvRequests, lblEditSection,
                lblBloodGroup, cmbBloodGroup, lblUnits, txtUnits, lblHospital, txtHospital,
                lblPhone, txtPhone, lblStatus, lblStatusValue, lblDonorInfo, btnUpdate, btnDelete });
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
