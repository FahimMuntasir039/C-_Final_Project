namespace BloodConnect
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Panel cardPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel btnReg;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.cardPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.LinkLabel();
            this.mainLayout.SuspendLayout();
            this.cardPanel.SuspendLayout();
            this.SuspendLayout();
            // mainLayout
            this.mainLayout.ColumnCount = 3;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.Controls.Add(this.cardPanel, 1, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.Size = new System.Drawing.Size(900, 605);
            this.mainLayout.TabIndex = 0;
            // cardPanel
            this.cardPanel.BackColor = System.Drawing.Color.White;
            this.cardPanel.Controls.Add(this.lblTitle);
            this.cardPanel.Controls.Add(this.lblUsername);
            this.cardPanel.Controls.Add(this.txtUsername);
            this.cardPanel.Controls.Add(this.lblPassword);
            this.cardPanel.Controls.Add(this.txtPassword);
            this.cardPanel.Controls.Add(this.btnLogin);
            this.cardPanel.Controls.Add(this.btnReg);
            this.cardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardPanel.Location = new System.Drawing.Point(263, 80);
            this.cardPanel.Name = "cardPanel";
            this.cardPanel.Padding = new System.Windows.Forms.Padding(30);
            this.cardPanel.Size = new System.Drawing.Size(374, 444);
            this.cardPanel.TabIndex = 0;
            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.lblTitle.Location = new System.Drawing.Point(30, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Blood Connect";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblUsername
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsername.Location = new System.Drawing.Point(30, 110);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 25);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // txtUsername
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.Location = new System.Drawing.Point(30, 135);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(320, 37);
            this.txtUsername.TabIndex = 2;
            // lblPassword
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassword.Location = new System.Drawing.Point(30, 180);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 25);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // txtPassword
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.Location = new System.Drawing.Point(30, 205);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(320, 37);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // btnLogin
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(30, 278);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(320, 45);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // btnReg
            this.btnReg.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReg.LinkColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnReg.Location = new System.Drawing.Point(30, 340);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(320, 30);
            this.btnReg.TabIndex = 6;
            this.btnReg.TabStop = true;
            this.btnReg.Text = "Create New Account";
            this.btnReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnReg_LinkClicked);
            // LoginForm
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(900, 605);
            this.Controls.Add(this.mainLayout);
            this.MinimumSize = new System.Drawing.Size(450, 500);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood Connect - Login";
            this.mainLayout.ResumeLayout(false);
            this.cardPanel.ResumeLayout(false);
            this.cardPanel.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
