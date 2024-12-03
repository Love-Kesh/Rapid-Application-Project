using System;
using System.Linq;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class TaskListForm : Form
    {
        private readonly User loggedInUser;

        public TaskListForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            FormStyling.ApplyFormStyling(this);
            FormStyling.ApplyButtonStyling(btnMarkCompleted);
            FormStyling.ApplyButtonStyling(btnBack);
            FormStyling.ApplyButtonStyling(btnAddTask);

            // Define the columns for the DataGridView programmatically if not already defined
            if (dataGridView.Columns.Count == 0)
            {
                dataGridView.Columns.Add("PetName", "Pet Name");
                dataGridView.Columns.Add("Description", "Task Description");
                dataGridView.Columns.Add("Status", "Task Status");
            }

            LoadPetNames(); // Populate the ComboBox with pet names
            LoadTaskList(); // Load tasks for the logged-in user
        }

        private void LoadPetNames()
        {
            cmbPetNames.Items.Clear();
            // Add the pets of the logged-in user to the ComboBox
            foreach (var pet in loggedInUser.Pets)
            {
                cmbPetNames.Items.Add(pet.Name);
            }

            if (cmbPetNames.Items.Count > 0)
                cmbPetNames.SelectedIndex = 0; // Optionally, select the first pet by default
        }

        private void LoadTaskList()
        {
            dataGridView.Rows.Clear();

            // Loop through each pet and load their tasks
            foreach (var pet in loggedInUser.Pets)
            {
                foreach (var task in pet.Tasks)
                {
                    // Add a row for each task in the DataGridView
                    dataGridView.Rows.Add(pet.Name, task.Description, task.IsCompleted ? "Completed" : "Pending");
                }
            }

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaskDescription.Text))
            {
                MessageBox.Show("Please provide a task description.");
                return;
            }

            // Add the task to the selected pet
            var selectedPetName = cmbPetNames.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedPetName))
            {
                MessageBox.Show("Please select a pet for the task.");
                return;
            }

            var pet = loggedInUser.Pets.FirstOrDefault(p => p.Name == selectedPetName);

            if (pet != null)
            {
                pet.Tasks.Add(new PetTask
                {
                    Description = txtTaskDescription.Text,
                    IsCompleted = false
                });

                MessageBox.Show($"Task '{txtTaskDescription.Text}' added to {pet.Name}.");
                txtTaskDescription.Clear();
                LoadTaskList(); // Refresh the task list
            }
        }

        private void btnMarkComplete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView.SelectedRows[0];
                var taskDescription = selectedRow.Cells["Description"].Value.ToString();
                var petName = selectedRow.Cells["PetName"].Value.ToString();

                var pet = loggedInUser.Pets.FirstOrDefault(p => p.Name == petName);
                var task = pet?.Tasks.FirstOrDefault(t => t.Description == taskDescription);

                if (task != null)
                {
                    task.IsCompleted = true;
                    MessageBox.Show($"Task '{task.Description}' marked as completed.");
                    LoadTaskList(); // Refresh the task list
                }
            }
            else
            {
                MessageBox.Show("Please select a task to mark as completed.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
