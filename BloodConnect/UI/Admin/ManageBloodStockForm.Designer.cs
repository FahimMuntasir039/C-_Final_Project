namespace BloodConnect.UI.Admin
{
    partial class ManageBloodStockForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblGrid;
        private System.Windows.Forms.DataGridView dgvStock;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.formPanel = new System.Windows.Forms.Panel();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.lblUnits = new System.Windows.Forms.Label();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblGrid = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.headerPanel.SuspendLayout();
            this.formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // headerPanel
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Padding = new System.Windows.Forms.Padding(25, 15, 25, 10);
            this.headerPanel.Size = new System.Drawing.Size(1000, 70);
            this.headerPanel.TabIndex = 2;
            // lblTitle
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(25, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(950, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manage Blood Stock";
            // formPanel
            this.formPanel.Controls.Add(this.lblBloodGroup);
            this.formPanel.Controls.Add(this.cmbBloodGroup);
            this.formPanel.Controls.Add(this.lblUnits);
            this.formPanel.Controls.Add(this.txtUnits);
            this.formPanel.Controls.Add(this.btnSave);
            this.formPanel.Controls.Add(this.btnUpdate);
            this.formPanel.Controls.Add(this.btnDelete);
            this.formPanel.Controls.Add(this.btnClear);
            this.formPanel.Controls.Add(this.lblSearch);
            this.formPanel.Controls.Add(this.txtSearch);
            this.formPanel.Controls.Add(this.lblGrid);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.formPanel.Location = new System.Drawing.Point(0, 70);
            this.formPanel.Name = "formPanel";
            this.formPanel.Padding = new System.Windows.Forms.Padding(25);
            this.formPanel.Size = new System.Drawing.Size(1000, 180);
            this.formPanel.TabIndex = 1;
            // lblBloodGroup
            this.lblBloodGroup.Location = new System.Drawing.Point(25, 20);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(120, 25);
            this.lblBloodGroup.TabIndex = 0;
            this.lblBloodGroup.Text = "Blood Group";
            // cmbBloodGroup
            this.cmbBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBloodGroup.Location = new System.Drawing.Point(25, 50);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Size = new System.Drawing.Size(200, 28);
            this.cmbBloodGroup.TabIndex = 1;
            // lblUnits
            this.lblUnits.Location = new System.Drawing.Point(250, 20);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(150, 25);
            this.lblUnits.TabIndex = 2;
            this.lblUnits.Text = "Units Available";
            // txtUnits
            this.txtUnits.Location = new System.Drawing.Point(250, 50);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(200, 26);
            this.txtUnits.TabIndex = 3;
            // btnSave
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(480, 50);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // btnUpdate
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(580, 50);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 36);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // btnDelete
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(680, 50);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 36);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // btnClear
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(780, 50);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 36);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // lblSearch
            this.lblSearch.Text = "Search stock (blood group):";
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.Location = new System.Drawing.Point(480, 95);
            this.lblSearch.AutoSize = true;
            this.lblSearch.TabIndex = 8;
            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(480, 120);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 26);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // lblGrid
            this.lblGrid.Text = "Blood stock list (double-click a row to edit):";
            this.lblGrid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGrid.Height = 24;
            this.lblGrid.Padding = new System.Windows.Forms.Padding(25, 4, 0, 0);
            this.lblGrid.TabIndex = 10;
            // dgvStock
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.ColumnHeadersHeight = 34;
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.Location = new System.Drawing.Point(0, 250);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(1000, 350);
            this.dgvStock.TabIndex = 0;
            this.dgvStock.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellDoubleClick);
            // ManageBloodStockForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.lblGrid);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "ManageBloodStockForm";
            this.Text = "Manage Blood Stock";
            this.headerPanel.ResumeLayout(false);
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
