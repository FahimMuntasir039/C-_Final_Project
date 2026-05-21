namespace BloodConnect.UI.Admin
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBloodStock;
        private System.Windows.Forms.Button btnRequests;
        private System.Windows.Forms.Button btnDonors;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBloodStock = new System.Windows.Forms.Button();
            this.btnRequests = new System.Windows.Forms.Button();
            this.btnDonors = new System.Windows.Forms.Button();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.sidebarPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // sidebarPanel
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.sidebarPanel.Controls.Add(this.lblLogo);
            this.sidebarPanel.Controls.Add(this.btnDashboard);
            this.sidebarPanel.Controls.Add(this.btnBloodStock);
            this.sidebarPanel.Controls.Add(this.btnRequests);
            this.sidebarPanel.Controls.Add(this.btnDonors);
            this.sidebarPanel.Controls.Add(this.btnAppointments);
            this.sidebarPanel.Controls.Add(this.btnLogout);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(225, 650);
            this.sidebarPanel.TabIndex = 1;
            // lblLogo
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(12, 20);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(200, 50);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "BLOOD CONNECT";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // btnDashboard
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(12, 90);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 42);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // btnBloodStock
            this.btnBloodStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnBloodStock.FlatAppearance.BorderSize = 0;
            this.btnBloodStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloodStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBloodStock.ForeColor = System.Drawing.Color.White;
            this.btnBloodStock.Location = new System.Drawing.Point(12, 148);
            this.btnBloodStock.Name = "btnBloodStock";
            this.btnBloodStock.Size = new System.Drawing.Size(200, 42);
            this.btnBloodStock.TabIndex = 2;
            this.btnBloodStock.Text = "Blood Stock";
            this.btnBloodStock.UseVisualStyleBackColor = false;
            this.btnBloodStock.Click += new System.EventHandler(this.btnBloodStock_Click);
            // btnRequests
            this.btnRequests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnRequests.FlatAppearance.BorderSize = 0;
            this.btnRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequests.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRequests.ForeColor = System.Drawing.Color.White;
            this.btnRequests.Location = new System.Drawing.Point(12, 206);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.Size = new System.Drawing.Size(200, 42);
            this.btnRequests.TabIndex = 3;
            this.btnRequests.Text = "Blood Requests";
            this.btnRequests.UseVisualStyleBackColor = false;
            this.btnRequests.Click += new System.EventHandler(this.btnRequests_Click);
            // btnDonors
            this.btnDonors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDonors.FlatAppearance.BorderSize = 0;
            this.btnDonors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonors.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDonors.ForeColor = System.Drawing.Color.White;
            this.btnDonors.Location = new System.Drawing.Point(12, 264);
            this.btnDonors.Name = "btnDonors";
            this.btnDonors.Size = new System.Drawing.Size(200, 42);
            this.btnDonors.TabIndex = 4;
            this.btnDonors.Text = "Donors";
            this.btnDonors.UseVisualStyleBackColor = false;
            this.btnDonors.Click += new System.EventHandler(this.btnDonors_Click);
            // btnAppointments
            this.btnAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnAppointments.FlatAppearance.BorderSize = 0;
            this.btnAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAppointments.ForeColor = System.Drawing.Color.White;
            this.btnAppointments.Location = new System.Drawing.Point(12, 322);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(200, 42);
            this.btnAppointments.TabIndex = 5;
            this.btnAppointments.Text = "Appointments";
            this.btnAppointments.UseVisualStyleBackColor = false;
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            // btnLogout
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(12, 590);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 42);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // mainPanel
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.mainPanel.Controls.Add(this.contentPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(225, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(875, 650);
            this.mainPanel.TabIndex = 0;
            // contentPanel
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(875, 650);
            this.contentPanel.TabIndex = 0;
            // AdminDashboard
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidebarPanel);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.sidebarPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
