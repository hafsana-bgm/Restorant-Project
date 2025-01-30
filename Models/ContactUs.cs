using System.ComponentModel.DataAnnotations;

namespace Restorant_Project.Models
{
    public class ContactUs
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DateTime DateTime { get; set; }
        public int PeopleCount { get; set; }
        public string? Message { get; set; }
    }
}
