namespace BloodConnect.UI.Admin
{
    partial class ManageDonorsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvDonors;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvDonors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).BeginInit();
            this.SuspendLayout();
            this.lblTitle.Text = "Manage Donors";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(25, 15);
            this.lblTitle.Size = new System.Drawing.Size(400, 50);
            this.lblSearch.Text = "Search donors (name, blood group, phone):";
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.Location = new System.Drawing.Point(25, 68);
            this.lblSearch.AutoSize = true;
            this.txtSearch.Location = new System.Drawing.Point(25, 92);
            this.txtSearch.Size = new System.Drawing.Size(300, 30);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Location = new System.Drawing.Point(340, 90);
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.BackColor = System.Drawing.Color.Gray;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.dgvDonors.Location = new System.Drawing.Point(25, 135);
            this.dgvDonors.Size = new System.Drawing.Size(820, 470);
            this.dgvDonors.ReadOnly = true;
            this.dgvDonors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientSize = new System.Drawing.Size(870, 620);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvDonors);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
