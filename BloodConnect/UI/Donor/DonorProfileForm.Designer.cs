namespace BloodConnect.UI.Donor
{
    partial class DonorProfileForm
    {
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnUpdate;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTitle.Text = "My Donor Profile";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(25, 15);
            this.lblTitle.Size = new System.Drawing.Size(400, 40);

            this.lblInfo.Location = new System.Drawing.Point(25, 55);
            this.lblInfo.Size = new System.Drawing.Size(800, 25);
            this.lblInfo.ForeColor = System.Drawing.Color.Gray;

            this.lblFullName.Text = "Full name:";
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFullName.Location = new System.Drawing.Point(25, 90);
            this.lblFullName.AutoSize = true;
            this.txtFullName.Location = new System.Drawing.Point(25, 114);
            this.txtFullName.Size = new System.Drawing.Size(400, 30);

            this.lblEmail.Text = "Email:";
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.Location = new System.Drawing.Point(25, 155);
            this.lblEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(25, 179);
            this.txtEmail.Size = new System.Drawing.Size(400, 30);

            this.lblBloodGroup.Text = "Blood group:";
            this.lblBloodGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBloodGroup.Location = new System.Drawing.Point(25, 220);
            this.lblBloodGroup.AutoSize = true;
            this.cmbBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBloodGroup.Location = new System.Drawing.Point(25, 244);
            this.cmbBloodGroup.Size = new System.Drawing.Size(120, 30);

            this.lblAge.Text = "Age:";
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAge.Location = new System.Drawing.Point(165, 220);
            this.lblAge.AutoSize = true;
            this.txtAge.Location = new System.Drawing.Point(165, 244);
            this.txtAge.Size = new System.Drawing.Size(100, 30);

            this.lblPhone.Text = "Phone:";
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhone.Location = new System.Drawing.Point(25, 285);
            this.lblPhone.AutoSize = true;
            this.txtPhone.Location = new System.Drawing.Point(25, 309);
            this.txtPhone.Size = new System.Drawing.Size(400, 30);

            this.lblAddress.Text = "Address:";
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAddress.Location = new System.Drawing.Point(25, 350);
            this.lblAddress.AutoSize = true;
            this.txtAddress.Location = new System.Drawing.Point(25, 374);
            this.txtAddress.Size = new System.Drawing.Size(500, 30);

            this.btnUpdate.Text = "Update Profile";
            this.btnUpdate.Location = new System.Drawing.Point(25, 420);
            this.btnUpdate.Size = new System.Drawing.Size(160, 40);
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.ClientSize = new System.Drawing.Size(870, 620);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblTitle, lblInfo, lblFullName, txtFullName, lblEmail, txtEmail,
                lblBloodGroup, cmbBloodGroup, lblAge, txtAge, lblPhone, txtPhone,
                lblAddress, txtAddress, btnUpdate });
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
