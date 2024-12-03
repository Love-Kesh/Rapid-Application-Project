using System;

namespace Final_Project
{
    public class PetTask
    {
        public int TaskID { get; set; }         // Unique identifier for the task
        public int PetID { get; set; }         // Foreign key linking to the pet
        public string Description { get; set; } // Description of the task
        public bool IsCompleted { get; set; }   // Indicates if the task is completed
        public DateTime ScheduledDate { get; set; } // Date when the task is scheduled
    }
}
