using System.ComponentModel.DataAnnotations;

namespace Restorant_Project.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public String? Name { get; set; }
        public String? Description { get; set; }
        public String? Profession { get; set; }
        public String? Image { get; set; }
        

    }
}
