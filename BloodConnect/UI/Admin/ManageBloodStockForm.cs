using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BloodConnect.UI.Admin
{
    public partial class ManageBloodStockForm : Form
    {
        private int selectedId = 0;

        public ManageBloodStockForm()
        {
            InitializeComponent();
            cmbBloodGroup.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            cmbBloodGroup.SelectedIndex = 0;
            LoadStock();
        }

        private void LoadStock()
        {
            try
            {
                DataAccess da = new DataAccess();
                dgvStock.DataSource = da.ExecuteQuery("SELECT * FROM BloodStock ORDER BY BloodGroup");
                dgvStock.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess da = new DataAccess();
                int rows = da.ExecuteNonQuery(
                    @"INSERT INTO BloodStock (BloodGroup, UnitsAvailable)
                      VALUES (@group, @units)",
                    new[]
                    {
                        new SqlParameter("@group", cmbBloodGroup.Text),
                        new SqlParameter("@units", txtUnits.Text)
                    });

                if (rows > 0)
                {
                    MessageBox.Show("Blood stock added.");
                    LoadStock();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            try
            {
                DataAccess da = new DataAccess();
                da.ExecuteNonQuery(
                    @"UPDATE BloodStock SET BloodGroup=@group, UnitsAvailable=@units WHERE ID=@id",
                    new[]
                    {
                        new SqlParameter("@group", cmbBloodGroup.Text),
                        new SqlParameter("@units", txtUnits.Text),
                        new SqlParameter("@id", selectedId)
                    });

                MessageBox.Show("Blood stock updated.");
                LoadStock();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    DataAccess da = new DataAccess();
                    da.ExecuteNonQuery("DELETE FROM BloodStock WHERE ID=@id",
                        new[] { new SqlParameter("@id", selectedId) });
                    MessageBox.Show("Deleted.");
                    LoadStock();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete error: " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            selectedId = 0;
            cmbBloodGroup.SelectedIndex = 0;
            txtUnits.Clear();
        }

        private void dgvStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStock.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["ID"].Value);
                cmbBloodGroup.Text = row.Cells["BloodGroup"].Value.ToString();
                txtUnits.Text = row.Cells["UnitsAvailable"].Value.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataAccess da = new DataAccess();
                dgvStock.DataSource = da.ExecuteQuery(
                    "SELECT * FROM BloodStock WHERE BloodGroup LIKE @search",
                    new[] { new SqlParameter("@search", "%" + txtSearch.Text.Trim() + "%") });
                dgvStock.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
        }
    }
}
