using System;
using System.Windows.Forms;

namespace BloodConnect.UI.Donor
{
    public partial class DonorDashboard : Form
    {
        private readonly int userId;
        private readonly string userName;

        public DonorDashboard(int userId, string fullName)
        {
            InitializeComponent();
            this.userId = userId;
            userName = fullName;
            lblLogo.Text = "DONOR PORTAL";
            LoadForm(new DonorDashboardHomeForm(userId, userName));
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

        private void btnDashboard_Click(object sender, EventArgs e) => LoadForm(new DonorDashboardHomeForm(userId, userName));
        private void btnProfile_Click(object sender, EventArgs e) => LoadForm(new DonorProfileForm(userId));
        private void btnDonations_Click(object sender, EventArgs e) => LoadForm(new DonorDonationsForm(userId));
        private void btnAppointments_Click(object sender, EventArgs e) => LoadForm(new DonorAppointmentsForm(userId));

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            Close();
        }
    }
}
