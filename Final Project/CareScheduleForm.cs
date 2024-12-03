using System;
using System.Linq;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class CareScheduleForm : Form
    {
        private readonly User loggedInUser;

        public CareScheduleForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            FormStyling.ApplyFormStyling(this);
            FormStyling.ApplyButtonStyling(btnBack);
            FormStyling.ApplyButtonStyling(btnAddSchedule);
            ApplyCalendarStyling();
            LoadScheduledTasks();
            LoadPetNames();
        }

        private void LoadPetNames()
        {
            cmbPetNames.Items.Clear();
            // Add only the pets from the logged-in user
            foreach (var pet in loggedInUser.Pets)
            {
                cmbPetNames.Items.Add(pet.Name);
            }
        }

        private void ApplyCalendarStyling()
        {
            var userScheduledDates = loggedInUser.Pets
                .SelectMany(p => p.Schedule)
                .Where(s => !string.IsNullOrEmpty(s.Description))
                .Select(s => s.Date)
                .Distinct()
                .ToArray();

            monthCalendar.BoldedDates = userScheduledDates;
        }

        private void LoadScheduledTasks()
        {
            var selectedDate = monthCalendar.SelectionStart;
            var tasksForSelectedDate = loggedInUser.Pets
                .SelectMany(p => p.Schedule)
                .Where(s => s.Date.Date == selectedDate.Date)
                .ToList();

            if (tasksForSelectedDate.Any())
            {
                lblScheduledTasks.Text = string.Join(Environment.NewLine, tasksForSelectedDate.Select(s =>
                    $"{s.Description} for {loggedInUser.Pets.FirstOrDefault(p => p.Schedule.Contains(s))?.Name}"
                ));
            }
            else
            {
                lblScheduledTasks.Text = "None";
            }
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            LoadScheduledTasks();
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtScheduledTask.Text) || dtpScheduledDate.Value <= DateTime.Now)
            {
                MessageBox.Show("Please provide a task description and select a future date.");
                return;
            }

            var selectedPetName = cmbPetNames.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedPetName))
            {
                MessageBox.Show("Please select a pet for the task.");
                return;
            }

            var pet = loggedInUser.Pets.FirstOrDefault(p => p.Name == selectedPetName);

            if (pet != null)
            {
                pet.Schedule.Add(new Schedule
                {
                    Description = txtScheduledTask.Text,
                    Date = dtpScheduledDate.Value
                });

                MessageBox.Show($"Scheduled task '{txtScheduledTask.Text}' added to {pet.Name}.");
                txtScheduledTask.Clear();
                dtpScheduledDate.Value = DateTime.Now;
                LoadScheduledTasks();
                ApplyCalendarStyling();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
