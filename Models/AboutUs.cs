using System.ComponentModel.DataAnnotations;

namespace Restorant_Project.Models
{
    public class AboutUs
    {
        [Key]
        public int AboutUsId { get; set; }
        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
