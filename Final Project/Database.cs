using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Project
{
    public static class Database
    {
        private static string connectionString = "Data Source = LUHKEY\\SQLEXPRESS02; Initial Catalog = PetCareApp; Integrated Security = True";

        // Load all users from the database
        public static List<User> LoadAllUsers()
        {
            List<User> users = new List<User>();
            string query = "SELECT * FROM Users";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            User user = new User
                            {
                                Name = reader["Name"].ToString(),
                                Username = reader["Username"].ToString(),
                                Password = reader["Password"].ToString()
                            };

                            user.Pets = LoadPetsForUser(user.Username);
                            users.Add(user);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return users;
        }

        // Load all pets for a specific user
        public static List<Pet> LoadPetsForUser(string username)
        {
            List<Pet> pets = new List<Pet>();
            string query = "SELECT * FROM Pets WHERE UserID = (SELECT UserID FROM Users WHERE Username = @Username)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Pet pet = new Pet
                            {
                                Name = reader["Name"].ToString(),
                                Type = reader["Type"].ToString(),
                                Breed = reader["Breed"].ToString(),
                                Weight = Convert.ToDouble(reader["Weight"]),
                                Age = Convert.ToInt32(reader["Age"]),
                                Height = Convert.ToDouble(reader["Height"]),
                                Tasks = LoadTasksForPet(Convert.ToInt32(reader["PetID"])),
                                Schedule = LoadSchedulesForPet(Convert.ToInt32(reader["PetID"]))
                            };

                            pets.Add(pet);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return pets;
        }

        // Load tasks for a specific pet
        public static List<PetTask> LoadTasksForPet(int petId)
        {
            List<PetTask> tasks = new List<PetTask>();
            string query = "SELECT * FROM PetTasks WHERE PetID = @PetID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PetID", petId);

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            PetTask task = new PetTask
                            {
                                Description = reader["Description"].ToString(),
                                IsCompleted = Convert.ToBoolean(reader["IsCompleted"]),
                                ScheduledDate = Convert.ToDateTime(reader["ScheduledDate"])
                            };

                            tasks.Add(task);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return tasks;
        }

        // Load schedules for a specific pet
        public static List<Schedule> LoadSchedulesForPet(int petId)
        {
            List<Schedule> schedules = new List<Schedule>();
            string query = "SELECT * FROM Schedules WHERE PetID = @PetID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PetID", petId);

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Schedule schedule = new Schedule
                            {
                                Date = Convert.ToDateTime(reader["Date"]),
                                Description = reader["Description"].ToString()
                            };

                            schedules.Add(schedule);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return schedules;
        }

        // Authenticate user
        public static User Authenticate(string username, string password)
        {
            string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            User user = new User
                            {
                                Name = reader["Name"].ToString(),
                                Username = reader["Username"].ToString(),
                                Password = reader["Password"].ToString(),
                                Pets = LoadPetsForUser(username)
                            };

                            return user;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return null;
        }
    }
}
