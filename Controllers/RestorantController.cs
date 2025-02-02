using System.Reflection.Metadata;
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
            var customerdata = _context.Contactus.FirstOrDefault(x => x.Id == id);
           
            return View (customerdata);
        }

        [HttpPost]
        public IActionResult ReservEdit(ContactUs contact)
        {
            if (contact.Name != null && contact.Email != null && contact.DateTime != null && contact.PeopleCount != null)
            {
                _context.Update(contact);
                _context.SaveChanges();
            }
            return RedirectToAction("ReservList");
        }

        public IActionResult ReservDelete(int? id)
        {
            if(id==null)

            return NotFound();

            var customerdata = _context.Contactus.FirstOrDefault(x => x.Id == id);

            if(customerdata == null)
                return NotFound();

            _context.Remove(customerdata);
            _context.SaveChanges();

            return RedirectToAction("ReservList");
            
        }

    }
}


