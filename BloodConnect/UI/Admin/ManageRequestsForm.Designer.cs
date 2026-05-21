namespace BloodConnect.UI.Admin
{
    partial class ManageRequestsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lblGrid;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvRequests;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblGrid = new System.Windows.Forms.Label();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(25, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manage Blood Requests";
            // lblSelected
            this.lblSelected.Location = new System.Drawing.Point(25, 70);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(300, 30);
            this.lblSelected.TabIndex = 1;
            this.lblSelected.Text = "Selected Request ID: - (double-click a row in the grid below)";
            // lblGrid
            this.lblGrid.Text = "All blood receiver requests:";
            this.lblGrid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGrid.Location = new System.Drawing.Point(25, 155);
            this.lblGrid.AutoSize = true;
            this.lblGrid.TabIndex = 7;
            // btnApprove
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Location = new System.Drawing.Point(25, 110);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(95, 36);
            this.btnApprove.TabIndex = 2;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // btnReject
            this.btnReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnReject.FlatAppearance.BorderSize = 0;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.Location = new System.Drawing.Point(130, 110);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(95, 36);
            this.btnReject.TabIndex = 3;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // lblHelp
            this.lblHelp.Text = "Approve receiver requests here. Assign donor in Appointments. Fulfilled is set when donation is complete.";
            this.lblHelp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHelp.ForeColor = System.Drawing.Color.Gray;
            this.lblHelp.Location = new System.Drawing.Point(340, 118);
            this.lblHelp.Size = new System.Drawing.Size(500, 28);
            this.lblHelp.TabIndex = 8;
            // btnRefresh
            this.btnRefresh.BackColor = System.Drawing.Color.Gray;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(235, 110);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 36);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // dgvRequests
            this.dgvRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequests.Location = new System.Drawing.Point(25, 160);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.ReadOnly = true;
            this.dgvRequests.Size = new System.Drawing.Size(820, 430);
            this.dgvRequests.TabIndex = 6;
            this.dgvRequests.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequests_CellDoubleClick);
            // ManageRequestsForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 620);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lblGrid);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvRequests);
            this.Name = "ManageRequestsForm";
            this.Text = "Manage Blood Requests";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
