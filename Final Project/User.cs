using System.Collections.Generic;

namespace Final_Project
{
    public class User
    {
        public int UserID { get; set; }       // Unique identifier for the user
        public string Name { get; set; }     // Full name of the user
        public string Username { get; set; } // Username for login
        public string Password { get; set; } // Password for login
        public List<Pet> Pets { get; set; } = new List<Pet>(); // List of pets owned by the user
    }
}
