using System;
using System.Windows.Forms;

namespace BloodConnect.UI.Receiver
{
    public partial class ReceiverDashboard : Form
    {
        private readonly int userId;
        private readonly string userName;

        public ReceiverDashboard(int userId, string fullName)
        {
            InitializeComponent();
            this.userId = userId;
            userName = fullName;
            lblLogo.Text = "RECEIVER PORTAL";
            LoadForm(new ReceiverDashboardHomeForm(userId, userName));
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

        private void btnDashboard_Click(object sender, EventArgs e) => LoadForm(new ReceiverDashboardHomeForm(userId, userName));
        private void btnProfile_Click(object sender, EventArgs e) => LoadForm(new ReceiverProfileForm(userId));
        private void btnSearchBlood_Click(object sender, EventArgs e) => LoadForm(new ReceiverSearchBloodForm());
        private void btnRequests_Click(object sender, EventArgs e) => LoadForm(new ReceiverRequestsForm(userId));
        private void btnNewRequest_Click(object sender, EventArgs e) => LoadForm(new ReceiverNewRequestForm(userId));

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            Close();
        }
    }
}
