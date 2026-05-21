namespace BloodConnect.UI.Receiver
{
    partial class ReceiverSearchBloodForm
    {
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.DataGridView dgvStock;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();

            this.lblTitle.Text = "Search Blood by Group and Location";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(25, 15);
            this.lblTitle.Size = new System.Drawing.Size(550, 35);

            this.lblBloodGroup.Text = "Blood group:";
            this.lblBloodGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBloodGroup.Location = new System.Drawing.Point(25, 60);
            this.lblBloodGroup.AutoSize = true;
            this.cmbBloodGroup.Location = new System.Drawing.Point(25, 84);
            this.cmbBloodGroup.Size = new System.Drawing.Size(120, 28);
            this.cmbBloodGroup.SelectedIndexChanged += new System.EventHandler(this.cmbBloodGroup_SelectedIndexChanged);

            this.lblLocation.Text = "Hospital / location:";
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLocation.Location = new System.Drawing.Point(165, 60);
            this.lblLocation.AutoSize = true;
            this.txtLocation.Location = new System.Drawing.Point(165, 84);
            this.txtLocation.Size = new System.Drawing.Size(280, 28);
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);

            this.btnSearch.Text = "Search";
            this.btnSearch.Location = new System.Drawing.Point(460, 82);
            this.btnSearch.Size = new System.Drawing.Size(90, 32);
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.lblResults.Text = "Available blood stock:";
            this.lblResults.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblResults.Location = new System.Drawing.Point(25, 125);
            this.lblResults.AutoSize = true;

            this.dgvStock.Location = new System.Drawing.Point(25, 150);
            this.dgvStock.Size = new System.Drawing.Size(820, 450);
            this.dgvStock.ReadOnly = true;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.ClientSize = new System.Drawing.Size(870, 620);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblTitle, lblBloodGroup, cmbBloodGroup, lblLocation, txtLocation, btnSearch, lblResults, dgvStock });
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
