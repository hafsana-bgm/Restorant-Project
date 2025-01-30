using Microsoft.AspNetCore.Mvc;
using Restorant_Project.Data;
using Restorant_Project.Models;

namespace Restorant_Project.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

       
        public IActionResult Booking()
        {
            return View();
        } 
        public IActionResult Booking(ContactUs contact)
        {
            if (contact.Name != null && contact.Email != null) 
            {
                _context.Add(contact);
                _context.SaveChanges();
            }
            return RedirectToAction("Booking");
        }
    }
}
