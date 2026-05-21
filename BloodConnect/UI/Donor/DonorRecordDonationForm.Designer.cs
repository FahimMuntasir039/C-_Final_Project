namespace BloodConnect.UI.Donor
{
    partial class DonorRecordDonationForm
    {
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.Button btnSave;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.lblUnits = new System.Windows.Forms.Label();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTitle.Text = "Record Donation";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Size = new System.Drawing.Size(400, 40);

            this.lblInfo.Location = new System.Drawing.Point(25, 65);
            this.lblInfo.Size = new System.Drawing.Size(700, 25);
            this.lblInfo.ForeColor = System.Drawing.Color.Gray;

            this.lblBloodGroup.Text = "Blood group:";
            this.lblBloodGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBloodGroup.Location = new System.Drawing.Point(25, 105);
            this.lblBloodGroup.AutoSize = true;
            this.cmbBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBloodGroup.Location = new System.Drawing.Point(25, 130);
            this.cmbBloodGroup.Size = new System.Drawing.Size(200, 30);

            this.lblUnits.Text = "Units donated:";
            this.lblUnits.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUnits.Location = new System.Drawing.Point(25, 175);
            this.lblUnits.AutoSize = true;
            this.txtUnits.Location = new System.Drawing.Point(25, 200);
            this.txtUnits.Size = new System.Drawing.Size(200, 30);

            this.btnSave.Text = "Save Donation";
            this.btnSave.Location = new System.Drawing.Point(25, 250);
            this.btnSave.Size = new System.Drawing.Size(180, 40);
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.ClientSize = new System.Drawing.Size(870, 620);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { lblTitle, lblInfo, lblBloodGroup, cmbBloodGroup, lblUnits, txtUnits, btnSave });
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
