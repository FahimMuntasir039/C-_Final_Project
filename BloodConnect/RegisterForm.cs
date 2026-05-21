using System;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BloodConnect
{
    public partial class RegisterForm : Form
    {
        private readonly LoginForm loginForm;

        public RegisterForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            cmbBloodGroup.SelectedIndex = 0;
            cmbUserType.SelectedIndex = 0;
            UpdateLabelsForUserType();

            SetupPlaceholder(txtFullName, "Enter your full name");
            SetupPlaceholder(txtEmail, "Enter your email (optional)");
            SetupPlaceholder(txtUsername, "Choose a username");
            SetupPasswordField(txtPassword);
            SetupPasswordField(txtConfirmPassword);
            SetupPlaceholder(txtPhone, "Enter phone number");
            SetupPlaceholder(txtAddress, "Enter your address");
            SetupPlaceholder(txtAge, "Enter your age");

            cmbUserType.SelectedIndexChanged += (s, e) => UpdateLabelsForUserType();
        }

        private void UpdateLabelsForUserType()
        {
            bool isDonor = cmbUserType.SelectedIndex == 0;
            lblBloodGroup.Text = isDonor ? "Your Blood Group" : "Blood Group Needed";
        }

        private bool IsDonorRegistration()
        {
            return cmbUserType.SelectedIndex == 0;
        }

        private void SetupPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Tag = placeholder;
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.GotFocus += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void SetupPasswordField(TextBox textBox)
        {
            textBox.Text = "";
            textBox.ForeColor = Color.Black;
            textBox.Tag = null;
            textBox.UseSystemPasswordChar = false;
            textBox.PasswordChar = '●';
            textBox.TextChanged += (s, e) => textBox.PasswordChar = '●';
        }

        private string GetFieldValue(TextBox textBox)
        {
            if (textBox == txtPassword || textBox == txtConfirmPassword)
                return textBox.Text.Trim();

            string placeholder = textBox.Tag as string ?? "";
            string value = textBox.Text.Trim();
            return value == placeholder ? "" : value;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = GetFieldValue(txtFullName);
            string email = GetFieldValue(txtEmail);
            string username = GetFieldValue(txtUsername);
            string password = GetFieldValue(txtPassword);
            string confirmPassword = GetFieldValue(txtConfirmPassword);
            string bloodGroup = cmbBloodGroup.Text;
            string phone = GetFieldValue(txtPhone);
            string address = GetFieldValue(txtAddress);
            string ageText = GetFieldValue(txtAge);
            bool isDonor = IsDonorRegistration();
            int roleId = isDonor ? UserRoles.Donor : UserRoles.Receiver;

            if (fullName == "" || username == "" || password == "" || confirmPassword == "" || phone == "" || address == "")
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            int? age = null;
            if (ageText != "")
            {
                if (!int.TryParse(ageText, out int parsedAge) || parsedAge < 18 || parsedAge > 65)
                {
                    MessageBox.Show("Please enter a valid age (18-65).");
                    return;
                }
                age = parsedAge;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Password and Confirm Password do not match.");
                return;
            }

            try
            {
                DataAccess da = new DataAccess();

                int exists = Convert.ToInt32(da.ExecuteScalar(
                    "SELECT COUNT(*) FROM Users WHERE Username = @username",
                    new[] { new SqlParameter("@username", username) }));

                if (exists > 0)
                {
                    MessageBox.Show("Username already exists. Please choose another.");
                    return;
                }

                int userId = Convert.ToInt32(da.ExecuteScalar(
                    @"INSERT INTO Users (Username, FullName, Email, Password, UserRoleID, UpdatedAt)
                      OUTPUT INSERTED.ID
                      VALUES (@username, @fullName, @email, @password, @roleId, GETDATE())",
                    new[]
                    {
                        new SqlParameter("@username", username),
                        new SqlParameter("@fullName", fullName),
                        new SqlParameter("@email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email),
                        new SqlParameter("@password", password),
                        new SqlParameter("@roleId", roleId)
                    }));

                if (isDonor)
                {
                    da.ExecuteNonQuery(
                        @"INSERT INTO Donors (UserID, BloodGroup, Age, Phone, Address)
                          VALUES (@userId, @bloodGroup, @age, @phone, @address)",
                        new[]
                        {
                            new SqlParameter("@userId", userId),
                            new SqlParameter("@bloodGroup", bloodGroup),
                            new SqlParameter("@age", age.HasValue ? (object)age.Value : DBNull.Value),
                            new SqlParameter("@phone", phone),
                            new SqlParameter("@address", address)
                        });
                }
                else
                {
                    da.ExecuteNonQuery(
                        @"INSERT INTO Receivers (UserID, BloodGroupNeeded, Phone, Address)
                          VALUES (@userId, @bloodGroup, @phone, @address)",
                        new[]
                        {
                            new SqlParameter("@userId", userId),
                            new SqlParameter("@bloodGroup", bloodGroup),
                            new SqlParameter("@phone", phone),
                            new SqlParameter("@address", address)
                        });
                }

                MessageBox.Show("Registration successful as " + (isDonor ? "Blood Donor" : "Blood Receiver") + ". Please login.");
                loginForm.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }
    }
}
