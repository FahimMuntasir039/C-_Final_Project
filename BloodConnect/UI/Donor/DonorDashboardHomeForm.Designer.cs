namespace BloodConnect.UI.Donor
{
    partial class DonorDashboardHomeForm
    {
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblDonationsCount;
        private System.Windows.Forms.Label lblAppointmentsCount;
        private System.Windows.Forms.Label lblLastDonation;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblDonationsCount = new System.Windows.Forms.Label();
            this.lblAppointmentsCount = new System.Windows.Forms.Label();
            this.lblLastDonation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Size = new System.Drawing.Size(800, 45);
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location = new System.Drawing.Point(30, 70);
            this.lblSubtitle.Size = new System.Drawing.Size(500, 30);
            this.lblSubtitle.Text = "Blood Donor Dashboard";
            AddStat("Total Donations", this.lblDonationsCount, 130);
            AddStat("Appointments", this.lblAppointmentsCount, 230);
            AddStat("Last Donation", this.lblLastDonation, 330);
            this.ClientSize = new System.Drawing.Size(870, 620);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblDonationsCount);
            this.Controls.Add(this.lblAppointmentsCount);
            this.Controls.Add(this.lblLastDonation);
            this.ResumeLayout(false);
        }

        private void AddStat(string title, System.Windows.Forms.Label valueLabel, int top)
        {
            var titleLbl = new System.Windows.Forms.Label
            {
                Text = title,
                Font = new System.Drawing.Font("Segoe UI", 10F),
                Location = new System.Drawing.Point(30, top),
                Size = new System.Drawing.Size(200, 25)
            };
            valueLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            valueLabel.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
            valueLabel.Location = new System.Drawing.Point(30, top + 28);
            valueLabel.Size = new System.Drawing.Size(300, 40);
            valueLabel.Text = "0";
            this.Controls.Add(titleLbl);
        }
    }
}
