namespace BloodConnect.UI.Admin
{
    partial class AdminDashboardHomeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel cardTotalUnits;
        private System.Windows.Forms.Panel cardPendingRequests;
        private System.Windows.Forms.Panel cardTotalDonors;
        private System.Windows.Forms.Label lblTotalUnitsTitle;
        private System.Windows.Forms.Label lblTotalUnitsCount;
        private System.Windows.Forms.Label lblPendingRequestsTitle;
        private System.Windows.Forms.Label lblPendingRequestsCount;
        private System.Windows.Forms.Label lblTotalDonorsTitle;
        private System.Windows.Forms.Label lblTotalDonorsCount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.cardTotalUnits = new System.Windows.Forms.Panel();
            this.lblTotalUnitsTitle = new System.Windows.Forms.Label();
            this.lblTotalUnitsCount = new System.Windows.Forms.Label();
            this.cardPendingRequests = new System.Windows.Forms.Panel();
            this.lblPendingRequestsTitle = new System.Windows.Forms.Label();
            this.lblPendingRequestsCount = new System.Windows.Forms.Label();
            this.cardTotalDonors = new System.Windows.Forms.Panel();
            this.lblTotalDonorsTitle = new System.Windows.Forms.Label();
            this.lblTotalDonorsCount = new System.Windows.Forms.Label();
            this.cardTotalUnits.SuspendLayout();
            this.cardPendingRequests.SuspendLayout();
            this.cardTotalDonors.SuspendLayout();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(40, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Admin Dashboard";
            // cardTotalUnits
            this.cardTotalUnits.BackColor = System.Drawing.Color.White;
            this.cardTotalUnits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTotalUnits.Controls.Add(this.lblTotalUnitsTitle);
            this.cardTotalUnits.Controls.Add(this.lblTotalUnitsCount);
            this.cardTotalUnits.Location = new System.Drawing.Point(40, 130);
            this.cardTotalUnits.Name = "cardTotalUnits";
            this.cardTotalUnits.Size = new System.Drawing.Size(260, 150);
            this.cardTotalUnits.TabIndex = 1;
            // lblTotalUnitsTitle
            this.lblTotalUnitsTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotalUnitsTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalUnitsTitle.Location = new System.Drawing.Point(25, 25);
            this.lblTotalUnitsTitle.Name = "lblTotalUnitsTitle";
            this.lblTotalUnitsTitle.Size = new System.Drawing.Size(200, 30);
            this.lblTotalUnitsTitle.TabIndex = 0;
            this.lblTotalUnitsTitle.Text = "Total Blood Units";
            // lblTotalUnitsCount
            this.lblTotalUnitsCount.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTotalUnitsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblTotalUnitsCount.Location = new System.Drawing.Point(25, 65);
            this.lblTotalUnitsCount.Name = "lblTotalUnitsCount";
            this.lblTotalUnitsCount.Size = new System.Drawing.Size(200, 60);
            this.lblTotalUnitsCount.TabIndex = 1;
            this.lblTotalUnitsCount.Text = "0";
            // cardPendingRequests
            this.cardPendingRequests.BackColor = System.Drawing.Color.White;
            this.cardPendingRequests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardPendingRequests.Controls.Add(this.lblPendingRequestsTitle);
            this.cardPendingRequests.Controls.Add(this.lblPendingRequestsCount);
            this.cardPendingRequests.Location = new System.Drawing.Point(320, 130);
            this.cardPendingRequests.Name = "cardPendingRequests";
            this.cardPendingRequests.Size = new System.Drawing.Size(260, 150);
            this.cardPendingRequests.TabIndex = 2;
            // lblPendingRequestsTitle
            this.lblPendingRequestsTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPendingRequestsTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblPendingRequestsTitle.Location = new System.Drawing.Point(25, 25);
            this.lblPendingRequestsTitle.Name = "lblPendingRequestsTitle";
            this.lblPendingRequestsTitle.Size = new System.Drawing.Size(200, 30);
            this.lblPendingRequestsTitle.TabIndex = 0;
            this.lblPendingRequestsTitle.Text = "Pending Requests";
            // lblPendingRequestsCount
            this.lblPendingRequestsCount.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblPendingRequestsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblPendingRequestsCount.Location = new System.Drawing.Point(25, 65);
            this.lblPendingRequestsCount.Name = "lblPendingRequestsCount";
            this.lblPendingRequestsCount.Size = new System.Drawing.Size(200, 60);
            this.lblPendingRequestsCount.TabIndex = 1;
            this.lblPendingRequestsCount.Text = "0";
            // cardTotalDonors
            this.cardTotalDonors.BackColor = System.Drawing.Color.White;
            this.cardTotalDonors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTotalDonors.Controls.Add(this.lblTotalDonorsTitle);
            this.cardTotalDonors.Controls.Add(this.lblTotalDonorsCount);
            this.cardTotalDonors.Location = new System.Drawing.Point(600, 130);
            this.cardTotalDonors.Name = "cardTotalDonors";
            this.cardTotalDonors.Size = new System.Drawing.Size(260, 150);
            this.cardTotalDonors.TabIndex = 3;
            // lblTotalDonorsTitle
            this.lblTotalDonorsTitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotalDonorsTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalDonorsTitle.Location = new System.Drawing.Point(25, 25);
            this.lblTotalDonorsTitle.Name = "lblTotalDonorsTitle";
            this.lblTotalDonorsTitle.Size = new System.Drawing.Size(200, 30);
            this.lblTotalDonorsTitle.TabIndex = 0;
            this.lblTotalDonorsTitle.Text = "Registered Donors";
            // lblTotalDonorsCount
            this.lblTotalDonorsCount.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTotalDonorsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblTotalDonorsCount.Location = new System.Drawing.Point(25, 65);
            this.lblTotalDonorsCount.Name = "lblTotalDonorsCount";
            this.lblTotalDonorsCount.Size = new System.Drawing.Size(200, 60);
            this.lblTotalDonorsCount.TabIndex = 1;
            this.lblTotalDonorsCount.Text = "0";
            // AdminDashboardHomeForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(870, 650);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cardTotalUnits);
            this.Controls.Add(this.cardPendingRequests);
            this.Controls.Add(this.cardTotalDonors);
            this.Name = "AdminDashboardHomeForm";
            this.Text = "Admin Dashboard Home";
            this.cardTotalUnits.ResumeLayout(false);
            this.cardPendingRequests.ResumeLayout(false);
            this.cardTotalDonors.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
