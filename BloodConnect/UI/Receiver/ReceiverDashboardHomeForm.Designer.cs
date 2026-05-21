namespace BloodConnect.UI.Receiver
{
    partial class ReceiverDashboardHomeForm
    {
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblRequestsCount;
        private System.Windows.Forms.Label lblPendingCount;
        private System.Windows.Forms.Label lblStockCount;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label { Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold), Location = new System.Drawing.Point(30, 25), Size = new System.Drawing.Size(800, 45) };
            this.lblSubtitle = new System.Windows.Forms.Label { Text = "Blood Receiver Dashboard", ForeColor = System.Drawing.Color.Gray, Location = new System.Drawing.Point(30, 70), Size = new System.Drawing.Size(500, 30) };
            this.lblRequestsCount = new System.Windows.Forms.Label();
            this.lblPendingCount = new System.Windows.Forms.Label();
            this.lblStockCount = new System.Windows.Forms.Label();
            AddStat("My Requests", lblRequestsCount, 130);
            AddStat("Pending Requests", lblPendingCount, 230);
            AddStat("Blood Groups In Stock", lblStockCount, 330);
            this.ClientSize = new System.Drawing.Size(870, 620);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { lblTitle, lblSubtitle, lblRequestsCount, lblPendingCount, lblStockCount });
        }

        private void AddStat(string title, System.Windows.Forms.Label val, int top)
        {
            this.Controls.Add(new System.Windows.Forms.Label { Text = title, Location = new System.Drawing.Point(30, top), AutoSize = true });
            val.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            val.ForeColor = System.Drawing.Color.FromArgb(0, 123, 255);
            val.Location = new System.Drawing.Point(30, top + 28);
            val.Size = new System.Drawing.Size(300, 40);
            val.Text = "0";
        }
    }
}
