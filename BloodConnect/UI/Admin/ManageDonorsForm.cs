using System;
using System.Windows.Forms;

namespace BloodConnect.UI.Admin
{
    public partial class ManageDonorsForm : Form
    {
        public ManageDonorsForm()
        {
            InitializeComponent();
            LoadDonors();
        }

        private void LoadDonors()
        {
            try
            {
                DataAccess da = new DataAccess();
                string query = @"SELECT d.ID, u.FullName, u.Username, u.Email, d.BloodGroup, d.Phone, d.Address
                                 FROM Donors d
                                 INNER JOIN Users u ON d.UserID = u.ID
                                 ORDER BY u.FullName";
                dgvDonors.DataSource = da.ExecuteQuery(query);
                dgvDonors.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDonors();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataAccess da = new DataAccess();
                string query = @"SELECT d.ID, u.FullName, u.Username, u.Email, d.BloodGroup, d.Phone, d.Address
                                 FROM Donors d
                                 INNER JOIN Users u ON d.UserID = u.ID
                                 WHERE u.FullName LIKE @search OR d.BloodGroup LIKE @search OR d.Phone LIKE @search";
                dgvDonors.DataSource = da.ExecuteQuery(query,
                    new Microsoft.Data.SqlClient.SqlParameter[]
                    {
                        new Microsoft.Data.SqlClient.SqlParameter("@search", "%" + txtSearch.Text.Trim() + "%")
                    });
                dgvDonors.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
        }
    }
}
