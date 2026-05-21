namespace BloodConnect.UI.Receiver
{
    partial class ReceiverDashboard
    {
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnSearchBlood;
        private System.Windows.Forms.Button btnRequests;
        private System.Windows.Forms.Button btnNewRequest;
        private System.Windows.Forms.Button btnLogout;

        private void InitializeComponent()
        {
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnSearchBlood = new System.Windows.Forms.Button();
            this.btnRequests = new System.Windows.Forms.Button();
            this.btnNewRequest = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(25, 55, 95);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Size = new System.Drawing.Size(230, 650);
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(0, 25);
            this.lblLogo.Size = new System.Drawing.Size(230, 45);
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            SetupBtn(btnDashboard, "Dashboard", 90, btnDashboard_Click);
            SetupBtn(btnProfile, "My Profile", 148, btnProfile_Click);
            SetupBtn(btnSearchBlood, "Search Blood", 206, btnSearchBlood_Click);
            SetupBtn(btnRequests, "My Requests", 264, btnRequests_Click);
            SetupBtn(btnNewRequest, "New Request", 322, btnNewRequest_Click);
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            SetupBtn(btnLogout, "Logout", 590, btnLogout_Click);
            this.sidebarPanel.Controls.AddRange(new System.Windows.Forms.Control[] { lblLogo, btnDashboard, btnProfile, btnSearchBlood, btnRequests, btnNewRequest, btnLogout });
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Controls.Add(this.contentPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Name = "ReceiverDashboard";
            this.Text = "Blood Connect - Receiver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        private void SetupBtn(System.Windows.Forms.Button btn, string text, int top, System.EventHandler click)
        {
            btn.Text = text;
            btn.Location = new System.Drawing.Point(15, top);
            btn.Size = new System.Drawing.Size(200, 42);
            btn.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            btn.ForeColor = System.Drawing.Color.White;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btn.Click += click;
        }
    }
}
