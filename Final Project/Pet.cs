using System.Collections.Generic;

namespace Final_Project
{
    public class Pet
    {
        public int PetID { get; set; }         // Unique identifier for the pet
        public int UserID { get; set; }       // Foreign key linking to the user
        public string Name { get; set; }      // Name of the pet
        public string Type { get; set; }      // Type of the pet (e.g., Dog, Cat)
        public string Breed { get; set; }     // Breed of the pet
        public double Weight { get; set; }    // Weight of the pet
        public int Age { get; set; }          // Age of the pet
        public double Height { get; set; }    // Height of the pet
        public List<PetTask> Tasks { get; set; } = new List<PetTask>(); // Tasks assigned to the pet
        public List<Schedule> Schedule { get; set; } = new List<Schedule>(); // Scheduled events for the pet
    }
}
