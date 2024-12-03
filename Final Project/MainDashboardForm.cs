using System;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class MainDashboardForm : Form
    {
        private User loggedInUser;

        public MainDashboardForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            FormStyling.ApplyFormStyling(this);
            FormStyling.ApplyButtonStyling(btnTaskList);
            FormStyling.ApplyButtonStyling(btnHealthMetrics);
            FormStyling.ApplyButtonStyling(btnCareSchedule);
        }

        private void btnViewPets_Click(object sender, EventArgs e)
        {
            ViewPetsForm viewPetsForm = new ViewPetsForm(loggedInUser);  // Pass loggedInUser to the form
            viewPetsForm.Show();
        }

        // Button click event for Add Pets
        private void btnAddPet_Click(object sender, EventArgs e)
        {
            AddPetForm addPetForm = new AddPetForm(loggedInUser);  // Pass loggedInUser to the form
            addPetForm.Show();
        }

        private void btnTaskList_Click(object sender, EventArgs e)
        {
            TaskListForm taskListForm = new TaskListForm(loggedInUser);
            taskListForm.ShowDialog(); // Opens TaskListForm
        }

        private void btnHealthMetrics_Click(object sender, EventArgs e)
        {
            HealthMetricsForm healthMetricsForm = new HealthMetricsForm(loggedInUser);
            healthMetricsForm.ShowDialog(); // Opens HealthMetricsForm
        }

        private void btnCareSchedule_Click(object sender, EventArgs e)
        {
            CareScheduleForm careScheduleForm = new CareScheduleForm(loggedInUser);
            careScheduleForm.ShowDialog(); // Opens CareScheduleForm
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Clear any session data for the logged-in user
            loggedInUser = null;

            // Optionally, close the current form and show the Login form again
            LoginForm loginForm = new LoginForm(); // Assuming you have a LoginForm
            loginForm.Show();

            // Close the current dashboard
            this.Close();
        }
    }
}
