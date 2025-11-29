using EventEase.Models;

namespace EventEase.Services
{
    public class EventService
    {
        // Mock Data (Part 1)
        private List<EventItem> _events = new List<EventItem>();

        public EventService()
        {
            // Generate mock data for testing performance (Part 2 Optimization)
            for (int i = 1; i <= 500; i++)
            {
                _events.Add(new EventItem
                {
                    Id = i,
                    Name = $"Event {i}",
                    Date = DateTime.Now.AddDays(i),
                    Location = i % 2 == 0 ? "Conference Hall A" : "Online",
                    Description = "This is a detailed description of the event."
                });
            }
        }

        public List<EventItem> GetEvents() => _events;

        public EventItem? GetEventById(int id) => _events.FirstOrDefault(e => e.Id == id);

        // Attendance Tracker Logic (Part 3)
        public void RegisterAttendee(int eventId)
        {
            var evt = GetEventById(eventId);
            if (evt != null)
            {
                evt.Attendees++;
            }
        }
    }
}