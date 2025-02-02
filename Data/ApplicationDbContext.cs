using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Restorant_Project.Models;

namespace Restorant_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<ContactUs> Contactus { get; set; } = default!;
        public DbSet<AboutUs> Aboutus { get; set; } = default!;
        public DbSet<Chefs> chefs { get; set; } = default!;
        public DbSet<Client> clients { get; set; } = default!;
        public DbSet<Menu> Menu { get; set; } = default!;
        public DbSet<Lebel> Lebels { get; set; } = default!;
        public DbSet<Service> Services { get; set; } = default!;
       
    }
}
