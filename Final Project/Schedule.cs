using System;

namespace Final_Project
{
    public class Schedule
    {
        public int ScheduleID { get; set; }     // Unique identifier for the schedule
        public int PetID { get; set; }         // Foreign key linking to the pet
        public DateTime Date { get; set; }      // Date of the scheduled event
        public string Description { get; set; } // Description of the scheduled event
    }
}
