using System;
using System.Windows.Forms;

namespace BloodConnect.UI.Admin
{
    public partial class AdminDashboard : Form
    {
        private readonly int userId;
        private readonly string userName;

        public AdminDashboard(int userId, string fullName)
        {
            InitializeComponent();
            this.userId = userId;
            userName = fullName;
            LoadForm(new AdminDashboardHomeForm());
        }

        private void LoadForm(Form form)
        {
            contentPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(form);
            form.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadForm(new AdminDashboardHomeForm());
        }

        private void btnBloodStock_Click(object sender, EventArgs e)
        {
            LoadForm(new ManageBloodStockForm());
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            LoadForm(new ManageRequestsForm());
        }

        private void btnDonors_Click(object sender, EventArgs e)
        {
            LoadForm(new ManageDonorsForm());
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            LoadForm(new ManageAppointmentsForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            Close();
        }
    }
}
