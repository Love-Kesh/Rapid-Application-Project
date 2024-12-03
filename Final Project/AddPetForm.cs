using System;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class AddPetForm : Form
    {
        private readonly User loggedInUser;

        public AddPetForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            FormStyling.ApplyFormStyling(this);  // Apply shared styling
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            // Check for empty fields
            if (string.IsNullOrWhiteSpace(txtPetName.Text) ||
                string.IsNullOrWhiteSpace(txtPetType.Text) ||
                string.IsNullOrWhiteSpace(txtPetBreed.Text) ||
                string.IsNullOrWhiteSpace(txtWeight.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtHeight.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit if there are empty fields
            }

            double petWeight, petHeight;
            int petAge;

            // Check if weight, age, and height are valid numbers
            if (!double.TryParse(txtWeight.Text, out petWeight))
            {
                MessageBox.Show("Please enter a valid number for weight.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtAge.Text, out petAge))
            {
                MessageBox.Show("Please enter a valid integer for age.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtHeight.Text, out petHeight))
            {
                MessageBox.Show("Please enter a valid number for height.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create new Pet object if all validations pass
            Pet newPet = new Pet
            {
                Name = txtPetName.Text,
                Type = txtPetType.Text,
                Breed = txtPetBreed.Text,
                Weight = petWeight,
                Age = petAge,
                Height = petHeight
            };

            // Add the new pet to the logged-in user's pet list
            loggedInUser.Pets.Add(newPet);

            // Show success message and close the form
            MessageBox.Show("Pet added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
