using System;
using System.Linq;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class ViewPetsForm : Form
    {
        private readonly User loggedInUser;

        public ViewPetsForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            FormStyling.ApplyFormStyling(this);
            InitializeDataGridView();
            LoadUserPets();  // Load only the logged-in user's pets
        }

        private void InitializeDataGridView()
        {
            if (dataGridView.Columns.Count == 0)
            {
                dataGridView.Columns.Add("Name", "Pet Name");
                dataGridView.Columns.Add("Type", "Pet Type");
                dataGridView.Columns.Add("Breed", "Pet Breed");
                dataGridView.Columns["Type"].Width = 100;
                dataGridView.Columns["Breed"].Width = 120;
                dataGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void LoadUserPets()
        {
            // Clear existing rows
            dataGridView.Rows.Clear();

            // Add pets only from the logged-in user
            foreach (var pet in loggedInUser.Pets)
            {
                dataGridView.Rows.Add(pet.Name, pet.Type, pet.Breed);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
