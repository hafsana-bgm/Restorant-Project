using System.Reflection.Metadata;
using Restorant_Project.Models;

namespace Restorant_Project.ViewModel
{
    public class HomeVM
    {
        public List<AboutUs>? Abouts { get; set; }
        public List<Chefs>? Chefss { get; set; }
        public List<Client>? Clients { get; set; }
        public List<ContactUs>? ContactUs { get; set; }
        public List<Menu>? Menu { get; set; }
        public List<Service>? Service { get; set; }
    }
}
