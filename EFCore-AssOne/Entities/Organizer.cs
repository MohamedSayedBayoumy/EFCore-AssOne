using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventHub.Entities
{
    [Table("EventOrganizers")]
    public class Organizer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string? CompanyName { get; set; }

        public bool IsVerified { get; set; }

        public virtual OrganizerProfile Profile { get; set; }
    }
}