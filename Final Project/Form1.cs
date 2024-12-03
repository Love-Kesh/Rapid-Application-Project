using System;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            FormStyling.ApplyFormStyling(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            User user = Database.Authenticate(username, password);
            if (user != null)
            {
                MessageBox.Show($"Welcome, {user.Name}!");
                MainDashboardForm dashboard = new MainDashboardForm(user);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

    }
}
