namespace BloodConnect.UI.Donor
{
    partial class DonorDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnDonations;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnDonations = new System.Windows.Forms.Button();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.sidebarPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(35, 45, 63);
            this.sidebarPanel.Controls.Add(this.lblLogo);
            this.sidebarPanel.Controls.Add(this.btnDashboard);
            this.sidebarPanel.Controls.Add(this.btnProfile);
            this.sidebarPanel.Controls.Add(this.btnDonations);
            this.sidebarPanel.Controls.Add(this.btnAppointments);
            this.sidebarPanel.Controls.Add(this.btnLogout);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Size = new System.Drawing.Size(230, 650);
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(0, 25);
            this.lblLogo.Size = new System.Drawing.Size(230, 45);
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            SetupBtn(this.btnDashboard, "Dashboard", 90, this.btnDashboard_Click);
            SetupBtn(this.btnProfile, "My Profile", 148, this.btnProfile_Click);
            SetupBtn(this.btnDonations, "My Donations", 206, this.btnDonations_Click);
            SetupBtn(this.btnAppointments, "Appointments", 264, this.btnAppointments_Click);
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            SetupBtn(this.btnLogout, "Logout", 590, this.btnLogout_Click);
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.mainPanel.Controls.Add(this.contentPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Name = "DonorDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood Connect - Donor";
            this.sidebarPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void SetupBtn(System.Windows.Forms.Button btn, string text, int top, System.EventHandler click)
        {
            btn.Text = text;
            btn.Location = new System.Drawing.Point(15, top);
            btn.Size = new System.Drawing.Size(200, 42);
            btn.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            btn.ForeColor = System.Drawing.Color.White;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btn.Click += click;
        }
    }
}
