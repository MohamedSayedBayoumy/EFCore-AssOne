namespace EventHub.Entities
{
    public class OrganizerProfile
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }

        public int OrganizerId { get; set; }
        public virtual Organizer Organizer { get; set; }
    }
}