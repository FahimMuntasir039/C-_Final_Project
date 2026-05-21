namespace BloodConnect.UI.Donor
{
    partial class DonorDonationsForm
    {
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblGrid;
        private System.Windows.Forms.DataGridView dgvDonations;
        private System.Windows.Forms.Label lblEditSection;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblGrid = new System.Windows.Forms.Label();
            this.dgvDonations = new System.Windows.Forms.DataGridView();
            this.lblEditSection = new System.Windows.Forms.Label();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.lblUnits = new System.Windows.Forms.Label();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonations)).BeginInit();
            this.SuspendLayout();

            this.lblTitle.Text = "My Donations";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(25, 15);
            this.lblTitle.Size = new System.Drawing.Size(500, 35);

            this.lblSearch.Text = "Search (blood group or status):";
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.Location = new System.Drawing.Point(25, 58);
            this.lblSearch.AutoSize = true;

            this.txtSearch.Location = new System.Drawing.Point(25, 82);
            this.txtSearch.Size = new System.Drawing.Size(280, 28);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Location = new System.Drawing.Point(315, 80);
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.lblGrid.Text = "Donation history:";
            this.lblGrid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGrid.Location = new System.Drawing.Point(25, 118);
            this.lblGrid.AutoSize = true;

            this.dgvDonations.Location = new System.Drawing.Point(25, 142);
            this.dgvDonations.Size = new System.Drawing.Size(820, 280);
            this.dgvDonations.ReadOnly = true;
            this.dgvDonations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonations_CellClick);

            this.lblEditSection.Text = "Update or delete (select a row above first):";
            this.lblEditSection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEditSection.Location = new System.Drawing.Point(25, 432);
            this.lblEditSection.Size = new System.Drawing.Size(500, 22);

            this.lblBloodGroup.Text = "Blood group:";
            this.lblBloodGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBloodGroup.Location = new System.Drawing.Point(25, 462);
            this.lblBloodGroup.AutoSize = true;
            this.cmbBloodGroup.Location = new System.Drawing.Point(25, 486);
            this.cmbBloodGroup.Size = new System.Drawing.Size(100, 28);

            this.lblUnits.Text = "Units donated:";
            this.lblUnits.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUnits.Location = new System.Drawing.Point(140, 462);
            this.lblUnits.AutoSize = true;
            this.txtUnits.Location = new System.Drawing.Point(140, 486);
            this.txtUnits.Size = new System.Drawing.Size(80, 28);

            this.lblStatus.Text = "Status:";
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.Location = new System.Drawing.Point(235, 462);
            this.lblStatus.AutoSize = true;
            this.cmbStatus.Location = new System.Drawing.Point(235, 486);
            this.cmbStatus.Size = new System.Drawing.Size(120, 28);

            this.btnUpdate.Text = "Update";
            this.btnUpdate.Location = new System.Drawing.Point(370, 482);
            this.btnUpdate.Size = new System.Drawing.Size(90, 34);
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(470, 482);
            this.btnDelete.Size = new System.Drawing.Size(90, 34);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.ClientSize = new System.Drawing.Size(870, 620);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblTitle, lblSearch, txtSearch, btnRefresh, lblGrid, dgvDonations,
                lblEditSection, lblBloodGroup, cmbBloodGroup, lblUnits, txtUnits, lblStatus, cmbStatus,
                btnUpdate, btnDelete });
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
