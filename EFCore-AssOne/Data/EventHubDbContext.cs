using EventHub.Entities;
using EventHub.Configurations;
using Microsoft.EntityFrameworkCore;

namespace EventHub.Data
{
    public class EventHubDbContext : DbContext
    {
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Badge> Badges { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EventHubDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrganizerProfileConfiguration());
            modelBuilder.ApplyConfiguration(new EventConfiguration());

            modelBuilder.Entity<Badge>(builder =>
            {
                builder.HasKey(b => b.Id);
                builder.Property(b => b.BadgeNumber).IsRequired().HasMaxLength(50);
                builder.HasOne(b => b.Attendee)
                       .WithOne(a => a.Badge)
                       .HasForeignKey<Badge>(b => b.AttendeeId);
            });
        }
    }
}