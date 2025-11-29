using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class EventItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Event Name is required.")]
        public string Name { get; set; } = string.Empty;

        [Required]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        
        // For Attendance Tracker (Part 3)
        public int Attendees { get; set; } = 0;
    }
}