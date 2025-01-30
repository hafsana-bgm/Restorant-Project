using System.ComponentModel.DataAnnotations;

namespace Restorant_Project.Models
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }
        public string? Icone { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        
    }
}
