using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restorant_Project.Data;
using Restorant_Project.Models;

namespace Restorant_Project.Controllers
{
   
    public class RestorantController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RestorantController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        } 
     

        public IActionResult About()
        {
            return View();
        } 

        public IActionResult Service()
        {
            return View();

        }


        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Reserv()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Reserv(ContactUs contact)
        {
            if (contact.Name !=null && contact.Email !=null && contact.DateTime !=null && contact.PeopleCount !=null)
            {
                _context.Add(contact);
                _context.SaveChanges();


            }
           return RedirectToAction ("Reserv");
        }

        public IActionResult ReservList()
        {
            var data = _context.Contactus.ToList();

            return View(data);
        }

        public IActionResult ReservEdit(int? id)
        {
            if (id == null)
                return NotFound();
            var customerdata = _context.Contactus.FirstOrDefault(customer => customer.Id == id);
           
            return View(customerdata);
        }

    }
}


