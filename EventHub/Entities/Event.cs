using System;

namespace EventHub.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MaxAttendees { get; set; }

        public int OrganizerId { get; set; }
        public virtual Organizer Organizer { get; set; }
    }
}