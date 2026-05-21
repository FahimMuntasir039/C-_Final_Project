using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BloodConnect.UI.Receiver
{
    public partial class ReceiverSearchBloodForm : Form
    {
        public ReceiverSearchBloodForm()
        {
            InitializeComponent();
            cmbBloodGroup.Items.Add("All");
            cmbBloodGroup.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            cmbBloodGroup.SelectedIndex = 0;
            SearchBlood();
        }

        private void SearchBlood()
        {
            try
            {
                string q = "SELECT BloodGroup, UnitsAvailable, HospitalName FROM BloodStock WHERE UnitsAvailable > 0";
                var p = new List<SqlParameter>();
                if (cmbBloodGroup.SelectedIndex > 0)
                {
                    q += " AND BloodGroup = @group";
                    p.Add(new SqlParameter("@group", cmbBloodGroup.Text));
                }
                if (!string.IsNullOrWhiteSpace(txtLocation.Text))
                {
                    q += " AND HospitalName LIKE @loc";
                    p.Add(new SqlParameter("@loc", "%" + txtLocation.Text.Trim() + "%"));
                }
                q += " ORDER BY BloodGroup";
                dgvStock.DataSource = new DataAccess().ExecuteQuery(q, p.Count > 0 ? p.ToArray() : null);
            }
            catch (Exception ex) { MessageBox.Show("Search error: " + ex.Message); }
        }

        private void btnSearch_Click(object sender, EventArgs e) => SearchBlood();
        private void txtLocation_TextChanged(object sender, EventArgs e) => SearchBlood();
        private void cmbBloodGroup_SelectedIndexChanged(object sender, EventArgs e) => SearchBlood();
    }
}
