namespace BloodConnect.UI.Receiver
{
    partial class ReceiverNewRequestForm
    {
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.Label lblHospital;
        private System.Windows.Forms.TextBox txtHospital;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSubmit;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.lblUnits = new System.Windows.Forms.Label();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.lblHospital = new System.Windows.Forms.Label();
            this.txtHospital = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblTitle.Text = "Submit New Blood Request";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Size = new System.Drawing.Size(450, 40);

            this.lblBloodGroup.Text = "Blood group needed:";
            this.lblBloodGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBloodGroup.Location = new System.Drawing.Point(25, 75);
            this.lblBloodGroup.AutoSize = true;
            this.cmbBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBloodGroup.Location = new System.Drawing.Point(25, 100);
            this.cmbBloodGroup.Size = new System.Drawing.Size(200, 30);

            this.lblUnits.Text = "Units required:";
            this.lblUnits.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUnits.Location = new System.Drawing.Point(25, 145);
            this.lblUnits.AutoSize = true;
            this.txtUnits.Location = new System.Drawing.Point(25, 170);
            this.txtUnits.Size = new System.Drawing.Size(200, 30);

            this.lblHospital.Text = "Hospital name:";
            this.lblHospital.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHospital.Location = new System.Drawing.Point(25, 215);
            this.lblHospital.AutoSize = true;
            this.txtHospital.Location = new System.Drawing.Point(25, 240);
            this.txtHospital.Size = new System.Drawing.Size(400, 30);

            this.lblPhone.Text = "Contact phone:";
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhone.Location = new System.Drawing.Point(25, 285);
            this.lblPhone.AutoSize = true;
            this.txtPhone.Location = new System.Drawing.Point(25, 310);
            this.txtPhone.Size = new System.Drawing.Size(250, 30);

            this.btnSubmit.Text = "Submit Request";
            this.btnSubmit.Location = new System.Drawing.Point(25, 360);
            this.btnSubmit.Size = new System.Drawing.Size(180, 40);
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            this.ClientSize = new System.Drawing.Size(870, 620);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblTitle, lblBloodGroup, cmbBloodGroup, lblUnits, txtUnits,
                lblHospital, txtHospital, lblPhone, txtPhone, btnSubmit });
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
