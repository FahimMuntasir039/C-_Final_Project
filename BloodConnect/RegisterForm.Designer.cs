namespace BloodConnect
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel cardPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel fieldsPanel;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cardPanel = new System.Windows.Forms.Panel();
            this.fieldsPanel = new System.Windows.Forms.Panel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cardPanel.SuspendLayout();
            this.fieldsPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // cardPanel
            this.cardPanel.BackColor = System.Drawing.Color.White;
            this.cardPanel.Controls.Add(this.fieldsPanel);
            this.cardPanel.Controls.Add(this.footerPanel);
            this.cardPanel.Controls.Add(this.headerPanel);
            this.cardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardPanel.Padding = new System.Windows.Forms.Padding(24);
            this.cardPanel.TabIndex = 0;
            // headerPanel
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.btnBack);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(24, 24);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(392, 88);
            this.headerPanel.TabIndex = 0;
            // btnBack
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 32);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // lblTitle
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(392, 44);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Register";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // fieldsPanel
            this.fieldsPanel.AutoScroll = true;
            this.fieldsPanel.Controls.Add(this.lblFullName);
            this.fieldsPanel.Controls.Add(this.txtFullName);
            this.fieldsPanel.Controls.Add(this.lblEmail);
            this.fieldsPanel.Controls.Add(this.txtEmail);
            this.fieldsPanel.Controls.Add(this.lblUsername);
            this.fieldsPanel.Controls.Add(this.txtUsername);
            this.fieldsPanel.Controls.Add(this.lblPassword);
            this.fieldsPanel.Controls.Add(this.txtPassword);
            this.fieldsPanel.Controls.Add(this.lblConfirmPassword);
            this.fieldsPanel.Controls.Add(this.txtConfirmPassword);
            this.fieldsPanel.Controls.Add(this.lblUserType);
            this.fieldsPanel.Controls.Add(this.cmbUserType);
            this.fieldsPanel.Controls.Add(this.lblBloodGroup);
            this.fieldsPanel.Controls.Add(this.cmbBloodGroup);
            this.fieldsPanel.Controls.Add(this.lblAge);
            this.fieldsPanel.Controls.Add(this.txtAge);
            this.fieldsPanel.Controls.Add(this.lblPhone);
            this.fieldsPanel.Controls.Add(this.txtPhone);
            this.fieldsPanel.Controls.Add(this.lblAddress);
            this.fieldsPanel.Controls.Add(this.txtAddress);
            this.fieldsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldsPanel.Location = new System.Drawing.Point(24, 112);
            this.fieldsPanel.Name = "fieldsPanel";
            this.fieldsPanel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.fieldsPanel.Size = new System.Drawing.Size(392, 508);
            this.fieldsPanel.TabIndex = 1;
            // lblFullName
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFullName.Location = new System.Drawing.Point(0, 8);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(380, 24);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // txtFullName
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFullName.Location = new System.Drawing.Point(0, 36);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(380, 34);
            this.txtFullName.TabIndex = 1;
            // lblEmail
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.Location = new System.Drawing.Point(0, 82);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(380, 24);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // txtEmail
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(0, 110);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(380, 34);
            this.txtEmail.TabIndex = 3;
            // lblUsername
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsername.Location = new System.Drawing.Point(0, 156);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(380, 24);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // txtUsername
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Location = new System.Drawing.Point(0, 184);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(380, 34);
            this.txtUsername.TabIndex = 5;
            // lblPassword
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassword.Location = new System.Drawing.Point(0, 230);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(380, 24);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // txtPassword
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(0, 258);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(380, 34);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // lblConfirmPassword
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblConfirmPassword.Location = new System.Drawing.Point(0, 304);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(380, 24);
            this.lblConfirmPassword.TabIndex = 8;
            this.lblConfirmPassword.Text = "Confirm Password";
            this.lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // txtConfirmPassword
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(0, 332);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(380, 34);
            this.txtConfirmPassword.TabIndex = 9;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // lblUserType
            this.lblUserType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUserType.Location = new System.Drawing.Point(0, 378);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(380, 24);
            this.lblUserType.TabIndex = 10;
            this.lblUserType.Text = "Register As";
            // cmbUserType
            this.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbUserType.Items.AddRange(new object[] { "Blood Donor", "Blood Receiver" });
            this.cmbUserType.Location = new System.Drawing.Point(0, 406);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(380, 36);
            this.cmbUserType.TabIndex = 11;
            // lblBloodGroup
            this.lblBloodGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBloodGroup.Location = new System.Drawing.Point(0, 452);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(380, 24);
            this.lblBloodGroup.TabIndex = 12;
            this.lblBloodGroup.Text = "Your Blood Group";
            // cmbBloodGroup
            this.cmbBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBloodGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBloodGroup.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            this.cmbBloodGroup.Location = new System.Drawing.Point(0, 480);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Size = new System.Drawing.Size(380, 36);
            this.cmbBloodGroup.TabIndex = 13;
            // lblAge
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAge.Location = new System.Drawing.Point(0, 526);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(380, 24);
            this.lblAge.TabIndex = 14;
            this.lblAge.Text = "Age";
            // txtAge
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAge.Location = new System.Drawing.Point(0, 554);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(380, 34);
            this.txtAge.TabIndex = 15;
            // lblPhone
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhone.Location = new System.Drawing.Point(0, 600);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(380, 24);
            this.lblPhone.TabIndex = 16;
            this.lblPhone.Text = "Phone";
            // txtPhone
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(0, 628);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(380, 34);
            this.txtPhone.TabIndex = 17;
            // lblAddress
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAddress.Location = new System.Drawing.Point(0, 674);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(380, 24);
            this.lblAddress.TabIndex = 18;
            this.lblAddress.Text = "Address";
            // txtAddress
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.Location = new System.Drawing.Point(0, 702);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(380, 34);
            this.txtAddress.TabIndex = 19;
            // footerPanel
            this.footerPanel.Controls.Add(this.btnRegister);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(24, 620);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.footerPanel.Size = new System.Drawing.Size(392, 56);
            this.footerPanel.TabIndex = 2;
            // btnRegister
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // RegisterForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(440, 780);
            this.Controls.Add(this.cardPanel);
            this.MinimumSize = new System.Drawing.Size(440, 680);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood Connect - Register";
            this.cardPanel.ResumeLayout(false);
            this.fieldsPanel.ResumeLayout(false);
            this.fieldsPanel.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
