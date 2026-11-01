using System;

namespace EventHub.Entities
{
    public class Badge
    {
        public int Id { get; set; }
        public string BadgeNumber { get; set; }
        public BadgeTier Tier { get; set; }

        public int AttendeeId { get; set; }
        public virtual Attendee Attendee { get; set; }
    }

    public enum BadgeTier
    {
        Standard,
        VIP
    }
}